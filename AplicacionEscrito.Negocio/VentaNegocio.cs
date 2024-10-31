using AplicacionEscrito.Datos;
using AplicacionEscritoEntidad;
using System.Collections.Generic;

namespace AplicacionEscrito.Negocio
{
    public class VentaNegocio
    {
        private readonly VentaDatos ventaDatos = new VentaDatos();

        public List<Venta> ObtenerVentas()
        {
            return ventaDatos.ObtenerVentas();
        }

        public bool AgregarVenta(Venta venta)
        {
            return ventaDatos.InsertarVenta(venta);
        }

        public bool ModificarVenta(Venta venta)
        {
            return ventaDatos.ModificarVenta(venta);
        }

        public bool EliminarVenta(int id)
        {
            return ventaDatos.EliminarVenta(id);
        }
    }
}
