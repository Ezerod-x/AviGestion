using AviGestion_.Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AviGestion_.Interfaz
{
    public partial class FormClientes : Form
    {
        private ClienteLogica clienteLogica = new ClienteLogica();
        private List<Cliente> listaOriginalClientes = new List<Cliente>();
        private int idClienteSeleccionado = -1;
        private Usuario usuarioActual; 

        public FormClientes(Usuario usuario)//Modificado
        {
            InitializeComponent();
            usuarioActual = usuario;
            splitContainer1.Panel2Collapsed = false;
            grbRegistrarModificar.Visible = false;
            dgvTablaClientes.MultiSelect = false;
            dgvTablaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CenterToScreen();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            dgvTablaClientes.AutoGenerateColumns = false;
            //Configuración de grilla a solo lectura//
            dgvTablaClientes.ReadOnly = true;
            dgvTablaClientes.AllowUserToAddRows = false;
            dgvTablaClientes.AllowUserToDeleteRows = false;
            dgvTablaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaClientes.MultiSelect = false;
            // Enlaces entre las columnas de la Grilla y las propiedades de la Clase
            if (dgvTablaClientes.Columns.Contains("colId"))
                dgvTablaClientes.Columns["colId"].DataPropertyName = "Id_Cliente";

            if (dgvTablaClientes.Columns.Contains("colEmpresa"))
                dgvTablaClientes.Columns["colEmpresa"].DataPropertyName = "Empresa";

            if (dgvTablaClientes.Columns.Contains("colNombre"))
                dgvTablaClientes.Columns["colNombre"].DataPropertyName = "Nombre";

            if (dgvTablaClientes.Columns.Contains("colApellido"))
                dgvTablaClientes.Columns["colApellido"].DataPropertyName = "Apellido";

            if (dgvTablaClientes.Columns.Contains("colTelefono"))
                dgvTablaClientes.Columns["colTelefono"].DataPropertyName = "Telefono";

            if (dgvTablaClientes.Columns.Contains("colDireccion"))
                dgvTablaClientes.Columns["colDireccion"].DataPropertyName = "Direccion";

            if (dgvTablaClientes.Columns.Contains("colCorreo"))
                dgvTablaClientes.Columns["colCorreo"].DataPropertyName = "CorreoElectronico";

            if (dgvTablaClientes.Columns.Contains("colDniCuil"))
                dgvTablaClientes.Columns["colDniCuil"].DataPropertyName = "DniCuil";

            lblAyuda.Text = "Doble clic en un cliente para poder modificar sus datos o ver su historial";
            lblAyuda.ForeColor = Color.FromArgb(91, 107, 79);
            lblAyuda.Font = new Font("Segoe UI", 9F, FontStyle.Italic);

            txtBusquedaFiltrado.TextChanged += txtBusquedaFiltrado_TextChanged;
            CargarDatosClientes();
        }

        private void txtBusquedaFiltrado_TextChanged(object sender, EventArgs e)
        {
            string textoABuscar = txtBusquedaFiltrado.Text.Trim().ToLower();

            List<Cliente> listaFiltrada = new List<Cliente>();

            if (string.IsNullOrEmpty(textoABuscar))
            {
                dgvTablaClientes.DataSource = null;
                dgvTablaClientes.DataSource = listaOriginalClientes;
                return;
            }

            foreach (Cliente cliente in listaOriginalClientes)
            {
                string empresa = (cliente.Empresa ?? "").ToLower();
                string nombre = (cliente.Nombre ?? "").ToLower();
                string apellido = (cliente.Apellido ?? "").ToLower();
                string dniCuil = (cliente.DniCuil ?? "").ToLower();

                if (empresa.Contains(textoABuscar) ||
                    nombre.Contains(textoABuscar) ||
                    apellido.Contains(textoABuscar) ||
                    dniCuil.Contains(textoABuscar))
                {
                    listaFiltrada.Add(cliente);
                }
            }

            dgvTablaClientes.DataSource = null;
            dgvTablaClientes.DataSource = listaFiltrada;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            idClienteSeleccionado = -1; // Nos aseguramos que está en modo Alta

            LimpiarCampos();
            grbRegistrarModificar.Text = "Alta";
            lblRegistrarModificar.Text = "Registrar Nuevo Cliente";
            grbRegistrarModificar.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> todosLosErrores = new List<string>();

                if (string.IsNullOrWhiteSpace(txtNombreNegocio.Text)) todosLosErrores.Add("- El nombre del negocio es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtResponsable.Text)) todosLosErrores.Add("- El responsable es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtTelefono.Text)) todosLosErrores.Add("- El teléfono es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtEmail.Text)) todosLosErrores.Add("- El correo es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtDniCuil.Text)) todosLosErrores.Add("- El DNI/CUIL es obligatorio.");

                if (todosLosErrores.Count == 0)
                {
                    List<string> erroresLogica = clienteLogica.ValidarFormatosLogicos(txtTelefono.Text, txtDniCuil.Text, txtEmail.Text, txtResponsable.Text.Trim());

                    todosLosErrores.AddRange(erroresLogica);
                }

                if (todosLosErrores.Count > 0)
                {
                    string mensajeFinal = string.Join("\n", todosLosErrores);
                    MessageBox.Show("Por favor, corrija los siguientes errores:\n\n" + mensajeFinal,
                                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string responsableCompleto = txtResponsable.Text.Trim();
                string nombreGuardar = responsableCompleto;
                string apellidoGuardar = "";
                int primerEspacio = responsableCompleto.IndexOf(' ');

                if (primerEspacio > 0)
                {
                    nombreGuardar = responsableCompleto.Substring(0, primerEspacio).Trim();
                    apellidoGuardar = responsableCompleto.Substring(primerEspacio).Trim();
                }

                Cliente cliente = new Cliente
                {
                    Id_Cliente = idClienteSeleccionado,
                    Empresa = txtNombreNegocio.Text.Trim(),
                    Nombre = nombreGuardar,
                    Apellido = apellidoGuardar,
                    Telefono = txtTelefono.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    CorreoElectronico = txtEmail.Text.Trim(),
                    DniCuil = txtDniCuil.Text.Trim()
                };

                clienteLogica.GuardarCliente(cliente);

                MessageBox.Show("Los datos se guardaron correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grbRegistrarModificar.Visible = false;
                CargarDatosClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoloNumerosYGuiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bloquea cualquier cosa que no sea número, tecla de borrar o guion
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grbRegistrarModificar.Visible = false;
        }

        //Evento para capturar el Doble Clic en cualquier celda de la fila
        private void dgvTablaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que se haya hecho doble clic sobre una fila de datos real y no en el encabezado
            if (e.RowIndex >= 0)
            {
                MapearFilaAFormulario(e.RowIndex);

                // Como seleccionamos un cliente existente, habilitamos el botón de historial
                btnVerHistorial.Visible = true;
            }
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            // Validamos que realmente haya un cliente seleccionado
            if (idClienteSeleccionado == -1) return;

            // Obtenemos la fila seleccionada actualmente para armar los datos del constructor
            if (dgvTablaClientes.CurrentRow != null)
            {
                var fila = dgvTablaClientes.CurrentRow;

                string nombreCompleto = txtResponsable.Text.Trim();
                string contacto = $"{txtEmail.Text.Trim()} | {txtTelefono.Text.Trim()}";
                string direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? "Sin dirección registrada" : txtDireccion.Text.Trim();

                FormHistorialCliente frmHistorial = new FormHistorialCliente(idClienteSeleccionado, nombreCompleto, contacto, direccion);
                frmHistorial.ShowDialog();
            }
        }

        #region Métodos para cargar, mapear datos y limpiar campos 
        private void CargarDatosClientes()
        {
            try
            {
                // Guarda la lectura de la base de datos enla lista fija de memoria
                listaOriginalClientes = clienteLogica.ObtenerClientes();

                dgvTablaClientes.DataSource = null;
                dgvTablaClientes.DataSource = listaOriginalClientes; // Enlace directo inicial

                if (dgvTablaClientes.Rows.Count > 0)
                {
                    dgvTablaClientes.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MapearFilaAFormulario(int rowIndex)
        {
            var fila = dgvTablaClientes.Rows[rowIndex];
            idClienteSeleccionado = Convert.ToInt32(fila.Cells["colId"].Value);

            txtNombreNegocio.Text = fila.Cells["colEmpresa"].Value?.ToString();
            string nombre = fila.Cells["colNombre"].Value?.ToString() ?? "";
            string apellido = fila.Cells["colApellido"].Value?.ToString() ?? "";
            txtResponsable.Text = $"{nombre.Trim()} {apellido.Trim()}".Trim();
            txtTelefono.Text = fila.Cells["colTelefono"].Value?.ToString();
            txtEmail.Text = fila.Cells["colCorreo"].Value?.ToString();
            txtDniCuil.Text = fila.Cells["colDniCuil"].Value?.ToString();
            txtDireccion.Text = fila.Cells["colDireccion"].Value?.ToString();

            grbRegistrarModificar.Text = "Modificar";
            lblRegistrarModificar.Text = "Modificar Datos";
            grbRegistrarModificar.Visible = true;
        }

        private void LimpiarCampos()
        {
            txtNombreNegocio.Text = "";
            txtResponsable.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtDniCuil.Text = "";
        }
        #endregion
    }
}
