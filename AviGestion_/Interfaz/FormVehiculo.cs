using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AviGestion_.Datos;
using AviGestion_.Logica;
using Microsoft.VisualBasic;

namespace AviGestion
{
    public partial class FormVehiculo : Form
    {
        private readonly Usuario _usuarioActual;

        public FormVehiculo(Usuario usuarioActual) : this()
        {
            _usuarioActual = usuarioActual;
        }
        private int _idVehiculoSeleccionado = -1;
        // Textos de ayuda (placeholders)
        private const string PhBuscar = "🔍 Buscar por marca, modelo o patente...";
        private const string PhModelo = "Ej: Atego 1721";
        private const string PhPatente = "Ej: AB 123 CD";

        // Alto de la grilla según el panel de alta esté visible u oculto
        private const int AltoGrillaConPanel = 190;
        private const int AltoGrillaSinPanel = 445;

        private static readonly Color Verde = Color.FromArgb(46, 92, 45);
        private static readonly Color Rojo = Color.FromArgb(150, 30, 30);

        private readonly VehiculoLogica _logica = new VehiculoLogica();
        private List<Vehiculo> _vehiculos = new List<Vehiculo>();

        // null = modo alta | distinto de null = modo edición de ese vehículo
        private Vehiculo _vehiculoEnEdicion;

        private Font _fuenteNegrita;

        public FormVehiculo()
        {
            InitializeComponent();
            ConfigurarGrilla();
            ConfigurarPlaceholders();
            Load += FormVehiculo_Load;
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            MostrarPanelAlta(false); // el panel aparece recién al apretar "Agregar Vehículo"
            CargarVehiculos();
        }

        // =============================================================
        // Configuración inicial
        // =============================================================

        private void ConfigurarGrilla()
        {
            _fuenteNegrita = new Font(dgvVehiculos.DefaultCellStyle.Font, FontStyle.Bold);

            dgvVehiculos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVehiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ConfigurarPlaceholders()
        {
            AplicarPlaceholder(txtBuscar, PhBuscar);
            AplicarPlaceholder(txtModelo, PhModelo);
            AplicarPlaceholder(txtPatente, PhPatente);
        }

        private void AplicarPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;

            txt.Enter += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = string.Empty;
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // Helpers para trabajar con los TextBox con placeholder
        private static string ObtenerTexto(TextBox txt, string placeholder)
        {
            return txt.Text == placeholder ? string.Empty : txt.Text.Trim();
        }

        private static void SetTexto(TextBox txt, string valor)
        {
            txt.Text = valor;
            txt.ForeColor = Color.Black;
        }

        private static void RestaurarPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Gray;
        }

        // Muestra u oculta el panel de alta/edición y reacomoda la grilla
        private void MostrarPanelAlta(bool visible)
        {
            pnlAltaModificacion.Visible = visible;
            dgvVehiculos.Height = visible ? AltoGrillaConPanel : AltoGrillaSinPanel;
        }

        // =============================================================
        // Carga y visualización de la grilla
        // =============================================================

        private void CargarVehiculos()
        {
            try
            {
                _vehiculos = _logica.ObtenerVehiculos();
                MostrarVehiculos();
            }
            catch (Exception ex)
            {
                MostrarError(ex, "cargar los vehículos");
            }
        }

        private void MostrarVehiculos()
        {
            string filtro = ObtenerFiltro();

            IEnumerable<Vehiculo> lista = _vehiculos;
            if (filtro.Length > 0)
            {
                lista = lista.Where(v => Contiene(v.Marca, filtro)
                                      || Contiene(v.Modelo, filtro)
                                      || Contiene(v.Patente, filtro));
            }

            dgvVehiculos.Rows.Clear();

            foreach (Vehiculo v in lista)
            {
                // Las 2 últimas columnas son botones (su texto lo pone CellFormatting)
                int fila = dgvVehiculos.Rows.Add(v.Marca, v.Modelo, v.Patente,
                                                 v.CapacidadMax, v.CapacidadActual,
                                                 v.Estado, null, null);
                dgvVehiculos.Rows[fila].Tag = v; // guardamos el vehículo completo en la fila
            }

            dgvVehiculos.ClearSelection();
        }

        private string ObtenerFiltro()
        {
            string texto = txtBuscar.Text.Trim();
            return texto == PhBuscar ? string.Empty : texto;
        }

        private static bool Contiene(string texto, string filtro)
        {
            return (texto ?? string.Empty).IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarVehiculos();
        }

        private void dgvVehiculos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Vehiculo v = dgvVehiculos.Rows[e.RowIndex].Tag as Vehiculo;
            if (v == null) return;

            bool activo = v.Estado == "Activo";
            string columna = dgvVehiculos.Columns[e.ColumnIndex].Name;

            if (columna == "colEstado")
            {
                Color color = activo ? Verde : Rojo;
                e.CellStyle.ForeColor = color;
                e.CellStyle.SelectionForeColor = color;
                e.CellStyle.Font = _fuenteNegrita;
            }
            else if (columna == "colEditar")
            {
                e.Value = activo ? "Editar" : "Reactivar";
                e.CellStyle.ForeColor = Verde;
                e.FormattingApplied = true;
            }
            else if (columna == "colBaja")
            {
                e.Value = activo ? "Dar de baja" : "—";
                e.CellStyle.ForeColor = activo ? Rojo : Color.Gray;
                e.FormattingApplied = true;
            }
        }

        // =============================================================
        // Botones de la grilla: Editar / Reactivar / Dar de baja
        // =============================================================

        private void dgvVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow fila = dgvVehiculos.Rows[e.RowIndex];

                // Opción 1: Si guardaste el objeto Vehiculo completo en fila.Tag
                if (fila.Tag is Vehiculo vGuardado)
                {
                    _vehiculoEnEdicion = vGuardado;
                }
                else
                {
                    // Opción 2: Si no usaste Tag, creas el objeto leyendo el texto de las celdas de la grilla
                    _vehiculoEnEdicion = new Vehiculo
                    {
                        Marca = fila.Cells[0].Value?.ToString(),
                        Modelo = fila.Cells[1].Value?.ToString(),
                        Patente = fila.Cells[2].Value?.ToString(),
                        CapacidadMax = Convert.ToInt32(fila.Cells[3].Value),
                        CapacidadActual = Convert.ToInt32(fila.Cells[4].Value),
                        Estado = fila.Cells[5].Value?.ToString()
                    };

                    // Si tienes el Id guardado en la capa de datos/lógica por patente:
                    // _vehiculoEnEdicion = _logica.ObtenerPorPatente(_vehiculoEnEdicion.Patente);
                }

                // Cargas los datos en los controles del formulario
                cmbMarca.Text = _vehiculoEnEdicion.Marca;
                txtModelo.Text = _vehiculoEnEdicion.Modelo;
                txtPatente.Text = _vehiculoEnEdicion.Patente;
                nudCapacidadMax.Value = _vehiculoEnEdicion.CapacidadMax;
                cmbEstado.Text = _vehiculoEnEdicion.Estado;

                cmbEstado.Enabled = true;
                lblAltaModificacion.Text = "Modificación de Vehículo";
                lblRegistrarVehiculo.Text = "Editar Vehículo";
                btnRegistrarVehiculo.Text = "Guardar Cambios";

                pnlAltaModificacion.Visible = true;
                pnlAltaModificacion.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar vehículo: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DarDeBaja(Vehiculo v)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Dar de baja el vehículo " + v.Marca + " " + v.Modelo + " (" + v.Patente + ")?",
                "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                _logica.DarDeBaja(v.Id);
            }
            catch (Exception ex)
            {
                MostrarError(ex, "dar de baja el vehículo");
                return;
            }

            // Si justo se estaba editando este vehículo, salimos del modo edición
            if (_vehiculoEnEdicion != null && _vehiculoEnEdicion.Id == v.Id)
            {
                LimpiarFormulario();
                MostrarPanelAlta(false);
            }

            CargarVehiculos();
        }

        private void Reactivar(Vehiculo v)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Reactivar el vehículo " + v.Marca + " " + v.Modelo + " (" + v.Patente + ")?",
                "Confirmar reactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;

            try
            {
                _logica.Reactivar(v.Id);
            }
            catch (Exception ex)
            {
                MostrarError(ex, "reactivar el vehículo");
                return;
            }

            CargarVehiculos();
        }

        // =============================================================
        // Panel de alta / edición
        // =============================================================

        // Pasa el panel a modo edición con los datos del vehículo elegido
        private void CargarEnFormulario(Vehiculo v)
        {
            _vehiculoEnEdicion = v;

            if (!cmbMarca.Items.Contains(v.Marca))
                cmbMarca.Items.Add(v.Marca);
            cmbMarca.SelectedItem = v.Marca;

            SetTexto(txtModelo, v.Modelo);
            SetTexto(txtPatente, v.Patente);

            nudCapacidadMax.Value = Math.Min(v.CapacidadMax, (int)nudCapacidadMax.Maximum);
            cmbEstado.SelectedItem = v.Estado;

            lblAltaModificacion.Text = "Modificación de Vehículo";
            lblRegistrarVehiculo.Text = "Editar Vehículo";
            btnRegistrarVehiculo.Text = "Guardar Cambios";

            MostrarPanelAlta(true);
            cmbMarca.Focus();
        }

        // Deja el panel vacío y en modo alta
        private void LimpiarFormulario()
        {
            _vehiculoEnEdicion = null;

            cmbMarca.SelectedIndex = -1;
            RestaurarPlaceholder(txtModelo, PhModelo);
            RestaurarPlaceholder(txtPatente, PhPatente);
            nudCapacidadMax.Value = 0;
            cmbEstado.SelectedIndex = 0; // "Activo"

            lblAltaModificacion.Text = "Alta de Vehículo";
            lblRegistrarVehiculo.Text = "Registrar Nuevo Vehículo";
            btnRegistrarVehiculo.Text = "Registrar Vehículo";
        }
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedItem?.ToString() == "+ Agregar nueva marca")
            {
                // Usa VB.NET Interaction.InputBox (requiere referencia a Microsoft.VisualBasic) 
                // o crea un cuadro de texto auxiliar sencillo:
                string nuevaMarca = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el nombre de la nueva marca:",
                    "Agregar Marca",
                    "");

                if (!string.IsNullOrWhiteSpace(nuevaMarca))
                {
                    nuevaMarca = nuevaMarca.Trim();

                    // Verificar si ya existe en la lista para no duplicar
                    if (!cmbMarca.Items.Contains(nuevaMarca))
                    {
                        // Insertar la nueva marca antes de la opción "+ Agregar nueva marca"
                        int index = cmbMarca.Items.Count - 1;
                        cmbMarca.Items.Insert(index, nuevaMarca);
                        cmbMarca.SelectedItem = nuevaMarca;
                    }
                    else
                    {
                        cmbMarca.SelectedItem = nuevaMarca;
                    }
                }
                else
                {
                    // Si cancela o deja vacío, deseleccionamos el combo
                    cmbMarca.SelectedIndex = -1;
                }
            }
        }
        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            // Limpiar campos
            cmbMarca.SelectedIndex = -1;
            txtModelo.Clear();
            txtPatente.Clear();
            nudCapacidadMax.Value = 0;

            // Estado automático predeterminado en "Disponible"
            cmbEstado.Text = "Disponible";
            cmbEstado.Enabled = false; // Bloqueado durante la creación nueva

            // Configurar títulos para alta
            lblAltaModificacion.Text = "Alta de Vehículo";
            lblRegistrarVehiculo.Text = "Registrar Nuevo Vehículo";
            btnRegistrarVehiculo.Text = "Registrar Vehículo";

            pnlAltaModificacion.Visible = true;
            pnlAltaModificacion.BringToFront();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _vehiculoEnEdicion = null;
            LimpiarFormulario();
            MostrarPanelAlta(false);
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            bool esEdicion = _vehiculoEnEdicion != null;

            Vehiculo vehiculo = new Vehiculo
            {
                Id = esEdicion ? _vehiculoEnEdicion.Id : 0,
                Marca = cmbMarca.Text,
                Modelo = ObtenerTexto(txtModelo, PhModelo),
                Patente = ObtenerTexto(txtPatente, PhPatente),
                CapacidadMax = (int)nudCapacidadMax.Value,
                CapacidadActual = esEdicion ? _vehiculoEnEdicion.CapacidadActual : 0,
                Estado = cmbEstado.Text
            };

            try
            {
                if (esEdicion)
                    _logica.Modificar(vehiculo);
                else
                    _logica.Registrar(vehiculo);
            }
            catch (Exception ex)
            {
                MostrarError(ex, "guardar el vehículo");
                return;
            }

            MessageBox.Show(
                esEdicion ? "Vehículo modificado correctamente." : "Vehículo registrado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _vehiculoEnEdicion = null; // Resetear la variable de edición
            LimpiarFormulario();
            MostrarPanelAlta(false);
            CargarVehiculos();
        }

        // =============================================================
        // Manejo de errores
        // =============================================================

        private void MostrarError(Exception ex, string accion)
        {
            if (ex is ReglaNegocioException)
            {
                // Error de validación: el mensaje ya es apto para el usuario
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al " + accion + ":\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}