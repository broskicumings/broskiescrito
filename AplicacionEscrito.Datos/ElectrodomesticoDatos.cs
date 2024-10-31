using AplicacionEscritoEntidad;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AplicacionEscrito.Datos
{
    public class PropiedadDatos
    {
        private readonly string connectionString = "Server=localhost;Database=Inmobiliarias;Uid=root;Pwd=12345;";

        public List<Propiedad> ObtenerPropiedades()
        {
            var propiedades = new List<Propiedad>();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM Propiedades", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var propiedad = new Propiedad
                {
                    Id = reader.GetInt32("Id"),
                    Direccion = reader.GetString("Direccion"),
                    Precio = reader.GetInt32("Precio"),
                    Tipo = (TipoPropiedad)Enum.Parse(typeof(TipoPropiedad), reader.GetString("Tipo")),
                    MetrosCuadrados = reader.GetString("Metros_Cuadrados")
                };
                propiedades.Add(propiedad);
            }
            return propiedades;
        }

        public bool InsertarPropiedad(Propiedad propiedad)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("INSERT INTO Propiedades (Id, Direccion, Precio, Tipo, Metros_Cuadrados) VALUES (@Id, @Direccion, @Precio, @Tipo, @MetrosCuadrados)", connection);
            command.Parameters.AddWithValue("@Id", propiedad.Id);
            command.Parameters.AddWithValue("@Direccion", propiedad.Direccion);
            command.Parameters.AddWithValue("@Precio", propiedad.Precio);
            command.Parameters.AddWithValue("@Tipo", propiedad.Tipo.ToString());
            command.Parameters.AddWithValue("@MetrosCuadrados", propiedad.MetrosCuadrados);
            return command.ExecuteNonQuery() > 0;
        }

        public bool ModificarPropiedad(Propiedad propiedad)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("UPDATE Propiedades SET Direccion = @Direccion, Precio = @Precio, Tipo = @Tipo, Metros_Cuadrados = @MetrosCuadrados WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", propiedad.Id);
            command.Parameters.AddWithValue("@Direccion", propiedad.Direccion);
            command.Parameters.AddWithValue("@Precio", propiedad.Precio);
            command.Parameters.AddWithValue("@Tipo", propiedad.Tipo.ToString());
            command.Parameters.AddWithValue("@MetrosCuadrados", propiedad.MetrosCuadrados);
            return command.ExecuteNonQuery() > 0;
        }

        public bool EliminarPropiedad(int id)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("DELETE FROM Propiedades WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
