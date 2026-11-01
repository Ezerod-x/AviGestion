using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// Ajustá el namespace al de tu capa de Lógica (o donde prefieras tenerla).
namespace AviGestion_.Logica
{
    public static class Idioma
    {
        public const string Espanol = "es";
        public const string Ingles = "en";

        private static string _actual = Espanol;
        public static string Actual { get { return _actual; } }

        // Español (tal cual está en los designers) -> Inglés.
        // Para traducir un texto nuevo, solo agregá una línea acá.
        private static readonly Dictionary<string, string> EsEn = new Dictionary<string, string>
        {
            // ---- FormMenu ----
            { "Menú Principal - Sistema AviGestión", "Main Menu - AviGestión System" },
            { "Productos Vendidos (30 Dias)", "Products Sold (30 Days)" },
            { "Pedidos por cliente ( 30 dias)", "Orders per Customer (30 days)" },
            { "Stock de los diferentes productos", "Stock of the Different Products" },
            { "Cambiar idioma", "Change language" },

            // ---- Menú lateral: secciones ----
            { "VENTAS", "SALES" },
            { "DEPÓSITO", "WAREHOUSE" },
            { "ADMINISTRACIÓN", "ADMINISTRATION" },
            { "SISTEMA", "SYSTEM" },

            // ---- Menú lateral: botones y etiquetas chicas ----
            { "Inicio", "Home" },
            { "Clientes", "Customers" },
            { "Pedidos", "Orders" },
            { "Facturación", "Invoicing" },
            { "Registrar Pagos", "Register Payments" },
            { "Productos", "Products" },
            { "Asignar Pedidos", "Assign Orders" },
            { "Alertas", "Alerts" },
            { "Categorías", "Categories" },
            { "Vehículos", "Vehicles" },
            { "Usuarios", "Users" },
            { "Bitácora", "Audit Log" },
            { "Cambiar contraseña", "Change password" },
            { "Ayuda", "Help" },
            { "catálogo", "catalog" },
            { "inventario", "inventory" },

            // ---- Menú lateral: títulos que se muestran en el header ----
            { "Gestión de Clientes", "Customer Management" },
            { "Gestión de Pedidos", "Order Management" },
            { "Facturación y Despacho de Pedidos", "Invoicing and Order Dispatch" },
            { "Registrar Pago", "Register Payment" },
            { "Gestión de Productos", "Product Management" },
            { "Stock e Inventario", "Stock and Inventory" },
            { "Gestión de Alertas", "Alert Management" },
            { "Gestión de Categorías", "Category Management" },
            { "Gestión de Usuarios", "User Management" },

            // ---- Cerrar sesión y mensajes de FormMenu ----
            { "Cerrar Sesión", "Log Out" },
            { "Cerrar sesión", "Log out" },
            { "¿Desea cerrar la sesión actual?", "Do you want to log out of the current session?" },
            { "Ayuda en construcción.", "Help is under construction." },
            { "No se pudieron cargar los datos.", "Could not load the data." },

            // ---- Login (Form1) ----
            { "Ingreso al Sistema AviGestión", "AviGestión System Login" },
            { "Por favor, introduzca sus credenciales para continuar.", "Please enter your credentials to continue." },
            { "Usuario", "Username" },
            { "Contraseña", "Password" },
            { "Iniciar Sesión", "Log In" },
            { "¿Olvidaste tu contraseña?", "Forgot your password?" },

            // ---- FormVehiculo ----
            { "Sistema AviGestión", "AviGestión System" },
            { "Gestión de Vehículos", "Vehicle Management" },
            { "+ Agregar Vehículo", "+ Add Vehicle" },
            { "Marca", "Brand" },
            { "Modelo", "Model" },
            { "Patente", "License Plate" },
            { "CapacidadMax", "MaxCapacity" },
            { "CapacidadActual", "CurrentCapacity" },
            { "Estado", "Status" },
            { "Acción", "Action" },
            { "Editar", "Edit" },
            { "Dar de baja", "Deactivate" },
            { "Reactivar", "Reactivate" },
            { "Alta de Vehículo", "Vehicle Registration" },
            { "Registrar Nuevo Vehículo", "Register New Vehicle" },
            { "MARCA", "BRAND" },
            { "MODELO", "MODEL" },
            { "PATENTE", "LICENSE PLATE" },
            { "CAPACIDAD MAX (Kg)", "MAX CAPACITY (Kg)" },
            { "ESTADO", "STATUS" },
            { "Cancelar", "Cancel" },
            { "Registrar Vehículo", "Register Vehicle" },
        };

        // Inglés -> Español (se arma sola a partir de la tabla de arriba, para poder volver).
        private static readonly Dictionary<string, string> EnEs = Invertir(EsEn);

        static Idioma()
        {
            Cargar();
        }

        private static Dictionary<string, string> Invertir(Dictionary<string, string> origen)
        {
            var resultado = new Dictionary<string, string>();
            foreach (var par in origen) resultado[par.Value] = par.Key;
            return resultado;
        }

        /// <summary>
        /// Traduce un texto al idioma actual. Si no está en el diccionario, lo devuelve igual.
        /// Usalo en el código para mensajes y textos dinámicos: Idioma.T("Dar de baja")
        /// </summary>
        public static string T(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return texto;

            var tabla = _actual == Ingles ? EsEn : EnEs;
            string traducido;
            return tabla.TryGetValue(texto.Trim(), out traducido) ? traducido : texto;
        }

        /// <summary>Cambia el idioma, lo guarda y refresca todos los forms abiertos.</summary>
        public static void Cambiar(string idioma)
        {
            if (idioma != Espanol && idioma != Ingles) return;

            _actual = idioma;
            Guardar();

            foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
                Aplicar(f);
        }

        /// <summary>
        /// Traduce un form completo. Llamalo después de InitializeComponent() en cada form.
        /// </summary>
        public static void Aplicar(Form form)
        {
            if (form == null) return;

            string titulo = T(form.Text);
            if (titulo != form.Text) form.Text = titulo;

            foreach (Control c in form.Controls)
                AplicarControl(c);
        }

        private static void AplicarControl(Control c)
        {
            // Lo que escribe el usuario o viene de la base no se traduce.
            if (c is TextBoxBase || c is ComboBox || c is NumericUpDown) return;

            string nuevo = T(c.Text);
            if (nuevo != c.Text) c.Text = nuevo;

            var grilla = c as DataGridView;
            if (grilla != null)
            {
                foreach (DataGridViewColumn col in grilla.Columns)
                {
                    string encabezado = T(col.HeaderText);
                    if (encabezado != col.HeaderText) col.HeaderText = encabezado;
                }
                grilla.Invalidate(); // redibuja (los botones de las celdas pasan de nuevo por CellFormatting)
            }

            var barra = c as ToolStrip; // MenuStrip, ToolStrip, StatusStrip
            if (barra != null) AplicarItems(barra.Items);

            foreach (Control hijo in c.Controls)
                AplicarControl(hijo);
        }

        private static void AplicarItems(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                string nuevo = T(item.Text);
                if (nuevo != item.Text) item.Text = nuevo;

                var desplegable = item as ToolStripDropDownItem;
                if (desplegable != null) AplicarItems(desplegable.DropDownItems);
            }
        }

        // ---- Persistencia: un archivito por usuario de Windows, sin tocar Settings ----

        private static string RutaConfig()
        {
            string carpeta = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AviGestion");
            return Path.Combine(carpeta, "idioma.cfg");
        }

        private static void Cargar()
        {
            try
            {
                string ruta = RutaConfig();
                if (File.Exists(ruta))
                {
                    string valor = File.ReadAllText(ruta).Trim();
                    if (valor == Ingles || valor == Espanol) _actual = valor;
                }
            }
            catch
            {
                _actual = Espanol;
            }
        }

        private static void Guardar()
        {
            try
            {
                string ruta = RutaConfig();
                Directory.CreateDirectory(Path.GetDirectoryName(ruta));
                File.WriteAllText(ruta, _actual);
            }
            catch
            {
                // Si no se puede guardar, el idioma igual queda activo durante esta sesión.
            }
        }
    }
}
