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

            // ---- FormAsignarPedidos ----
            { "AviGestión - Asignar pedidos", "AviGestión - Assign orders" },
            { "Asignación de pedidos", "Order Assignment" },
            { "Volver al menú", "Back to menu" },
            { "En preparación", "In Preparation" },
            { "Camiones en depósito", "Trucks in Warehouse" },
            { "En camino", "On the Way" },
            { "Entregados", "Delivered" },

            // ---- FormBackup ----
            { "Se generará una copia de seguridad completa (Backup Full) de la base de datos AviGestion, incluyendo todas las tablas del sistema.", "A full backup (Full Backup) of the AviGestion database will be generated, including all system tables." },
            { "CARPETA DE DESTINO", "DESTINATION FOLDER" },
            { "Examinar...", "Browse..." },
            { "💾 Generar Backup", "💾 Generate Backup" },
            { "⬇ Descargar copia", "⬇ Download copy" },

            // ---- FormBitacora ----
            { "Aplicar filtros de búsqueda: escribí texto, elegí acción y módulo, o filtrá por fecha", "Apply search filters: type text, choose an action and module, or filter by date" },
            { "Filtrar por fecha", "Filter by date" },
            { "Desde:", "From:" },
            { "Hasta:", "To:" },
            { "Limpiar Filtros", "Clear Filters" },
            { "Fecha y Hora", "Date and Time" },
            { "Módulo", "Module" },
            { "Detalle", "Details" },

            // ---- FormClientes ----
            { "+ Agregar Cliente", "+ Add Customer" },
            { "Nombre", "Name" },
            { "Apellido", "Last Name" },
            { "Empresa", "Company" },
            { "Teléfono", "Phone" },
            { "Correo electronico", "Email Address" },
            { "DNI/CUIL", "National ID (DNI/CUIL)" },
            { "Direccion", "Address" },
            { "Modificacion", "Modification" },
            { "Campos con ( * ) son obligatorios", "Fields marked with ( * ) are required" },
            { "Ver Historial", "View History" },
            { "Guardar Cambios", "Save Changes" },
            { "*NOMBRE DEL NEGOCIO", "*BUSINESS NAME" },
            { "*RESPONSABLE (nombre y apellido)", "*CONTACT PERSON (first and last name)" },
            { "*TELÉFONO", "*PHONE" },
            { "*DNI / CUIL", "*NATIONAL ID (DNI / CUIL)" },
            { "*CORREO ELÉCTRONICO", "*EMAIL" },
            { "*DIRECCIÓN", "*ADDRESS" },

            // ---- FormControlEntregas ----
            { "Control Entregas de Pedidos", "Order Delivery Control" },
            { "Doble clic en un camión para ver sus pedidos. Destilda los que no se entregaron y adjuntá el comprobante", "Double-click a truck to see its orders. Uncheck the ones that were not delivered and attach the proof of delivery" },
            { "COMPROBANTE DE ENTREGA", "PROOF OF DELIVERY" },
            { "Adjuntar Imagen ...", "Attach Image ..." },
            { "RESPONSABLE DE LA ENTREGA (usuario registrado)", "PERSON IN CHARGE OF DELIVERY (registered user)" },
            { "Confirmar Entrega", "Confirm Delivery" },

            // ---- FormFacturacion ----
            { "Pedidos pendientes a facturar (últimos 30 días)", "Pending orders to invoice (last 30 days)" },
            { "Pendientes", "Pending" },
            { "FacturadosDelDia", "Invoiced by Day" },
            { "Importe total facturado", "Total invoiced amount" },
            { "Solo lectura", "Read only" },
            { "Confirmar Despacho", "Confirm Dispatch" },
            { "Facturados", "Invoiced" },

            // ---- FormAlertas ----
            { "Aplicar filtros de búsqueda: escribí texto, elegí tipo y estado, o filtrá por fecha", "Apply search filters: type text, choose type and status, or filter by date" },
            { "📊 Ver Gráficos", "📊 View Charts" },
            { "Producto", "Product" },
            { "Código", "Code" },
            { "Categoría", "Category" },
            { "Tipo de Alerta", "Alert Type" },
            { "Generada", "Generated" },
            { "Resuelta", "Resolved" },
            { "No existen alertas con los criterios aplicados.", "No alerts match the applied criteria." },
            { "Detalle del Producto Seleccionado", "Selected Product Details" },
            { "Código:", "Code:" },
            { "Producto:", "Product:" },
            { "Categoría:", "Category:" },
            { "Stock Actual:", "Current Stock:" },
            { "Stock Mínimo:", "Minimum Stock:" },
            { "Stock Máximo:", "Maximum Stock:" },
            { "Estado Actual:", "Current Status:" },
            { "Alertas Históricas:", "Historical Alerts:" },

            // ---- FormHistorialCliente ----
            { "Historial Cliente", "Customer History" },
            { "Limpiar", "Clear" },
            { "CLIENTE", "CUSTOMER" },
            { "CONTACTO", "CONTACT" },
            { "DIRECCIÓN", "ADDRESS" },
            { "TOTAL COMPRADO", "TOTAL PURCHASED" },
            { "TOTAL PAGADO", "TOTAL PAID" },
            { "SALDO PENDIENTE", "OUTSTANDING BALANCE" },
            { "NumeroFila", "Row Number" },
            { "N°Pedido", "Order No." },
            { "Fecha", "Date" },
            { "Monto", "Amount" },
            { "Pagado", "Paid" },
            { "Saldo", "Balance" },
            { "RESUMEN FINANCIERO", "FINANCIAL SUMMARY" },
            { "Promedio de Compra", "Average Purchase" },
            { "% Pagado", "% Paid" },
            { "Antigüedad", "Time as Customer" },
            { "Monto Mínimo", "Minimum Amount" },
            { "Monto Máximo", "Maximum Amount" },
            { "Última Compra", "Last Purchase" },
            { "Cerrar", "Close" },

            // ---- FormHistorialEntrega ----
            { "Filtra por patente, vehículo o responsable y actualiza el resumen", "Filter by license plate, vehicle or person in charge and update the summary" },
            { "Ver Comprobante", "View Receipt" },

            // ---- FormProducto ----
            { "Eliminar Producto", "Delete Product" },
            { "+ Agregar Producto", "+ Add Product" },
            { "Precio", "Price" },
            { "Alta / Modificación", "Add / Edit" },
            { "Registrar Producto", "Register Product" },
            { "CÓDIGO", "CODE" },
            { "DESCRIPCIÓN", "DESCRIPTION" },
            { "CATEGORÍA", "CATEGORY" },
            { "PRECIO", "PRICE" },
            { "STOCK MÍNIMO", "MINIMUM STOCK" },
            { "STOCK MÁXIMO", "MAXIMUM STOCK" },

            // ---- FormRecuperoContrasena ----
            { "Recuperar Contraseña", "Recover Password" },
            { "Paso 1 de 3", "Step 1 of 3" },
            { "Paso 2 de 3", "Step 2 of 3" },
            { "Paso 3 de 3", "Step 3 of 3" },
            { "Correo electrónico", "Email address" },
            { "Enviar código", "Send code" },
            { "Verificar código", "Verify code" },
            { "Reenviar código", "Resend code" },
            { "Cambiar correo", "Change email" },
            { "Contraseña nueva", "New password" },
            { "Repetí la contraseña", "Repeat the password" },
            { "Mínimo 8 caracteres, con letras y números.", "Minimum 8 characters, with letters and numbers." },
            { "Guardar contraseña", "Save password" },
            { "Volver al inicio de sesión", "Back to login" },

            // ---- FormRegistrarPago ----
            { "Cliente", "Customer" },
            { "Saldo Pendiente", "Outstanding Balance" },
            { "Estado de Pago", "Payment Status" },
            { "Método de Pago", "Payment Method" },
            { "MÉTODO DE PAGO", "PAYMENT METHOD" },
            { "IMPORTE A ABONAR (MÁX. )", "AMOUNT TO PAY (MAX. )" },
            { "Confirmar Pago", "Confirm Payment" },

            // ---- FormUsuarios ----
            { "+ Agregar Usuario", "+ Add User" },
            { "Rol", "Role" },
            { "Doble clic en un usuario para modificarlo o eliminarlo.", "Double-click a user to edit or delete it." },
            { "Registrar Usuario", "Register User" },
            { "NOMBRE", "NAME" },
            { "APELLIDO", "LAST NAME" },
            { "ROL", "ROLE" },
            { "CONTRASEÑA", "PASSWORD" },
            { "Registrar", "Register" },
            { "Eliminar", "Delete" },

            // ---- FrmAgregarCliente ----
            { "Registrar Nuevo Cliente", "Register New Customer" },
            { "NOMBRE DEL NEGOCIO", "BUSINESS NAME" },
            { "RESPONSABLE", "CONTACT PERSON" },
            { "TELÉFONO", "PHONE" },
            { "DNI/ CUIL", "NATIONAL ID (DNI/CUIL)" },
            { "CORREO ELECTRÓNICO", "EMAIL ADDRESS" },
            { "Guardar", "Save" },

            // ---- FrmCambiarContrasena ----
            { "Cambiar Contraseña", "Change Password" },
            { "Ingresá tu contraseña actual y elegí una nueva.", "Enter your current password and choose a new one." },
            { "Contraseña actual", "Current password" },
            { "Repetí la contraseña nueva", "Repeat the new password" },

            // ---- FormCargaStock ----
            { "↻ Actualizar Inventario", "↻ Update Inventory" },
            { "Stock Actual", "Current Stock" },
            { "Stock Mín.", "Min. Stock" },
            { "Stock Máx.", "Max. Stock" },
            { "Registrar Ingreso de Stock", "Register Stock Entry" },
            { "PRODUCTO SELECCIONADO", "SELECTED PRODUCT" },
            { "STOCK ACTUAL", "CURRENT STOCK" },
            { "CANTIDAD A INGRESAR", "QUANTITY TO ADD" },
            { "NUEVO STOCK RESULTANTE", "RESULTING NEW STOCK" },
            { "Registrar Ingreso", "Register Entry" },

            // ---- FrmCategorias ----
            { "+ Nueva Categoría", "+ New Category" },
            { "Descripción", "Description" },
            { "Doble clic en una categoría para modificarla.", "Double-click a category to edit it." },
            { "Registrar Categoría", "Register Category" },

            // ---- FrmPedidos ----
            { "+ Agregar Pedido", "+ Add Order" },
            { "N° Pedido", "Order Number" },
            { "Doble clic en un pedido para ver el detalle y realizar acciones.", "Double-click an order to see its details and take actions." },
            { "Detalle del Pedido", "Order Details" },
            { "FECHA", "DATE" },
            { "PRODUCTOS DEL PEDIDO", "ORDER PRODUCTS" },
            { "Cantidad", "Quantity" },
            { "Generar Comprobante", "Generate Receipt" },
            { "Cancelar Pedido", "Cancel Order" },
            { "Registrar Nuevo Pedido", "Register New Order" },
            { "PRODUCTOS", "PRODUCTS" },
            { "CANTIDAD", "QUANTITY" },
            { "+ Agregar", "+ Add" },
            { "DETALLE DEL PEDIDO", "ORDER DETAILS" },
            { "Stock disponible", "Available stock" },
            { "Quitar", "Remove" },
            { "Registrar Pedido", "Register Order" },

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
