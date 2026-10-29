namespace AviGestion_.Logica
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }

        // Vínculo real con la tabla Categorias (0 = sin categoría). No se muestra en las grillas.
        [System.ComponentModel.Browsable(false)]
        public int Id_Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Estado { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public int DigitoVerificador { get; set; }

        // Propiedad calculada: no se guarda en la base, se calcula sola
        public string EstadoStock
        {
            get
            {
                if (Stock <= StockMinimo) return "Stock Mínimo";
                if (Stock >= StockMaximo) return "Stock Máximo";
                if (Stock >= StockMaximo * 0.9) return "Próx. a Máximo";
                return "Normal";
            }
        }
    }
}