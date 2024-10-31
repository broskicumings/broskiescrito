namespace AplicacionEscritoEntidad
{
    public enum TipoPropiedad
    {
        Terreno,
        Mansion,
        Monoambiente
    }

    public class Propiedad
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public int Precio { get; set; }
        public TipoPropiedad Tipo { get; set; }
        public string MetrosCuadrados { get; set; }
    }
}
