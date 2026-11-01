using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AviGestion_.Logica;

namespace AviGestion_.Interfaz
{
    public partial class FrmAgregarCliente : Form
    {
        private ClienteLogica clienteLogica = new ClienteLogica();

        public string NuevoClienteNombre { get; private set; }

        public FrmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos obligatorios
                List<string> errores = new List<string>();

                if (string.IsNullOrWhiteSpace(txtNombreNegocio.Text))
                    errores.Add("- El nombre del negocio es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtResponsable.Text))
                    errores.Add("- El responsable es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                    errores.Add("- El teléfono es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    errores.Add("- El correo es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtDniCuil.Text))
                    errores.Add("- El DNI/CUIL es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                    errores.Add("- La dirección es obligatoria.");

                if (errores.Count == 0)
                {
                    List<string> erroresLogica = clienteLogica.ValidarFormatosLogicos(
                        txtTelefono.Text,
                        txtDniCuil.Text,
                        txtEmail.Text,
                        txtResponsable.Text.Trim(), 
                        txtDireccion.Text);

                    errores.AddRange(erroresLogica);
                }

                if (errores.Count > 0)
                {
                    MessageBox.Show("Por favor corregí los siguientes errores:\n\n" +
                        string.Join("\n", errores),
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Separar nombre y apellido del responsable
                string responsable = txtResponsable.Text.Trim();
                string nombre = responsable;
                string apellido = "";
                int primerEspacio = responsable.IndexOf(' ');
                if (primerEspacio > 0)
                {
                    nombre = responsable.Substring(0, primerEspacio).Trim();
                    apellido = responsable.Substring(primerEspacio).Trim();
                }

                Cliente cliente = new Cliente
                {
                    Id_Cliente = -1, // Alta
                    Empresa = txtNombreNegocio.Text.Trim(),
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = txtTelefono.Text.Trim(),
                    Direccion = txtDireccion.Text.Trim(),
                    CorreoElectronico = txtEmail.Text.Trim(),
                    DniCuil = txtDniCuil.Text.Trim()
                };

                clienteLogica.GuardarCliente(cliente);

                NuevoClienteNombre = txtNombreNegocio.Text.Trim();

                MessageBox.Show("Cliente registrado exitosamente.",
                    "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}