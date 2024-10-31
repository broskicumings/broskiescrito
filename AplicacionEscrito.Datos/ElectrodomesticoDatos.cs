using AplicacionEscritoEntidad;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AplicacionEscrito.Datos
{
    public class ElectrodomesticoDatos
    {
        private readonly string connectionString = "Server=localhost;Database=ESCRITOFUERTE;Uid=root;Pwd=12345;";

        public List<Electrodomestico> ObtenerElectrodomesticos()
        {
            var electrodomesticos = new List<Electrodomestico>();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM Electrodomesticos", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var electrodomestico = new Electrodomestico
                {
                    Id = reader.GetInt32("Id"),
                    Nombre = reader.GetString("Nombre"),
                    Precio = reader.GetInt32("Precio"),
                    Marca = reader.GetString("Marca")
                };
                electrodomesticos.Add(electrodomestico);
            }
            return electrodomesticos;
        }

        public bool InsertarElectrodomestico(Electrodomestico electrodomestico)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("INSERT INTO Electrodomesticos (Id, Nombre, Precio, Marca) VALUES (@Id, @Nombre, @Precio, @Marca)", connection);
            command.Parameters.AddWithValue("@Id", electrodomestico.Id);
            command.Parameters.AddWithValue("@Nombre", electrodomestico.Nombre);
            command.Parameters.AddWithValue("@Precio", electrodomestico.Precio);
            command.Parameters.AddWithValue("@Marca", electrodomestico.Marca);
            return command.ExecuteNonQuery() > 0;
        }

        public bool ModificarElectrodomestico(Electrodomestico electrodomestico)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("UPDATE Electrodomesticos SET Nombre = @Nombre, Precio = @Precio, Marca = @Marca WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", electrodomestico.Id);
            command.Parameters.AddWithValue("@Nombre", electrodomestico.Nombre);
            command.Parameters.AddWithValue("@Precio", electrodomestico.Precio);
            command.Parameters.AddWithValue("@Marca", electrodomestico.Marca);
            return command.ExecuteNonQuery() > 0;
        }

        public bool EliminarElectrodomestico(int id)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("DELETE FROM Electrodomesticos WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
