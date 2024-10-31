namespace AplicacionEscritoEntidad
{
    public class Venta
    {
        public int Id_Venta { get; set; }
        public int Id_Prop { get; set; }
        public int Precio { get; set; }
        public int Descuento { get; set; }
        public int IVA { get; set; }
        public int Precio_Total { get; set; }
    }
}
