using AplicacionEscrito.Datos;
using AplicacionEscritoEntidad;
using System.Collections.Generic;

namespace AplicacionEscrito.Negocio
{
    public class PropiedadNegocio
    {
        private readonly PropiedadDatos propiedadDatos = new PropiedadDatos();

        public List<Propiedad> ObtenerPropiedades()
        {
            return propiedadDatos.ObtenerPropiedades();
        }

        public bool AgregarPropiedad(Propiedad propiedad)
        {
            return propiedadDatos.InsertarPropiedad(propiedad);
        }

        public bool ModificarPropiedad(Propiedad propiedad)
        {
            return propiedadDatos.ModificarPropiedad(propiedad);
        }

        public bool EliminarPropiedad(int id)
        {
            return propiedadDatos.EliminarPropiedad(id);
        }
    }
}
