namespace AplicacionEscritoEntidad
{
    public class Venta
    {
        public int Id_Venta { get; set; }
        public int Id_Electrodomestico { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public int IVA { get; set; }
        public int Precio_Total { get; set; }
    }
}
