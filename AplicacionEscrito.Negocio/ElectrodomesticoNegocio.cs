using AplicacionEscrito.Datos;
using AplicacionEscritoEntidad;
using System.Collections.Generic;

namespace AplicacionEscrito.Negocio
{
    public class ElectrodomesticoNegocio
    {
        private readonly ElectrodomesticoDatos electrodomesticoDatos = new ElectrodomesticoDatos();

        public List<Electrodomestico> ObtenerElectrodomesticos()
        {
            return electrodomesticoDatos.ObtenerElectrodomesticos();
        }

        public bool AgregarElectrodomestico(Electrodomestico electrodomestico)
        {
            return electrodomesticoDatos.InsertarElectrodomestico(electrodomestico);
        }

        public bool ModificarElectrodomestico(Electrodomestico electrodomestico)
        {
            return electrodomesticoDatos.ModificarElectrodomestico(electrodomestico);
        }

        public bool EliminarElectrodomestico(int id)
        {
            return electrodomesticoDatos.EliminarElectrodomestico(id);
        }
    }
}
