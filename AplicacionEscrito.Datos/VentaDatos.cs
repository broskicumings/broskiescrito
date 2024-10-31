using AplicacionEscritoEntidad;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AplicacionEscrito.Datos
{
    public class VentaDatos
    {
        private readonly string connectionString = "Server=localhost;Database=ESCRITOFUERTE;Uid=root;Pwd=12345;";

        public List<Venta> ObtenerVentas()
        {
            var ventas = new List<Venta>();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM Venta", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var venta = new Venta
                {
                    Id_Venta = reader.GetInt32("Id_Venta"),
                    Id_Electrodomestico = reader.GetInt32("Id_Electrodomestico"),
                    Precio = reader.GetInt32("Precio"),
                    Cantidad = reader.GetInt32("Cantidad"),
                    IVA = reader.GetInt32("IVA"),
                    Precio_Total = reader.GetInt32("Precio_Total")
                };
                ventas.Add(venta);
            }
            return ventas;
        }

        public bool InsertarVenta(Venta venta)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("INSERT INTO Venta (Id_Venta, Id_Electrodomestico, Precio, Cantidad, IVA, Precio_Total) VALUES (@Id_Venta, @Id_Electrodomestico, @Precio, @Cantidad, @IVA, @Precio_Total)", connection);
            command.Parameters.AddWithValue("@Id_Venta", venta.Id_Venta);
            command.Parameters.AddWithValue("@Id_Electrodomestico", venta.Id_Electrodomestico);
            command.Parameters.AddWithValue("@Precio", venta.Precio);
            command.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
            command.Parameters.AddWithValue("@IVA", venta.IVA);
            command.Parameters.AddWithValue("@Precio_Total", venta.Precio_Total);
            return command.ExecuteNonQuery() > 0;
        }

        public bool ModificarVenta(Venta venta)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("UPDATE Venta SET Id_Electrodomestico = @Id_Electrodomestico, Precio = @Precio, Cantidad = @Cantidad, IVA = @IVA, Precio_Total = @Precio_Total WHERE Id_Venta = @Id_Venta", connection);
            command.Parameters.AddWithValue("@Id_Venta", venta.Id_Venta);
            command.Parameters.AddWithValue("@Id_Electrodomestico", venta.Id_Electrodomestico);
            command.Parameters.AddWithValue("@Precio", venta.Precio);
            command.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
            command.Parameters.AddWithValue("@IVA", venta.IVA);
            command.Parameters.AddWithValue("@Precio_Total", venta.Precio_Total);
            return command.ExecuteNonQuery() > 0;
        }

        public bool EliminarVenta(int id)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("DELETE FROM Venta WHERE Id_Venta = @Id_Venta", connection);
            command.Parameters.AddWithValue("@Id_Venta", id);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
