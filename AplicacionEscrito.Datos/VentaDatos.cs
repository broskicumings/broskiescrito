using AplicacionEscritoEntidad;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AplicacionEscrito.Datos
{
    public class VentaDatos
    {
        private readonly string connectionString = "Server=localhost;Database=Inmobiliarias;Uid=root;Pwd=12345;";

        public List<Venta> ObtenerVentas()
        {
            var ventas = new List<Venta>();
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT * FROM Ventas", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var venta = new Venta
                {
                    Id_Venta = reader.GetInt32("Id_Venta"),
                    Id_Prop = reader.GetInt32("Id_Prop"),
                    Precio = reader.GetInt32("Precio"),
                    Descuento = reader.GetInt32("Descuento"),
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
            using var command = new MySqlCommand("INSERT INTO Ventas (Id_Venta, Id_Prop, Precio, Descuento, IVA, Precio_Total) VALUES (@Id_Venta, @Id_Prop, @Precio, @Descuento, @IVA, @Precio_Total)", connection);
            command.Parameters.AddWithValue("@Id_Venta", venta.Id_Venta);
            command.Parameters.AddWithValue("@Id_Prop", venta.Id_Prop);
            command.Parameters.AddWithValue("@Precio", venta.Precio);
            command.Parameters.AddWithValue("@Descuento", venta.Descuento);
            command.Parameters.AddWithValue("@IVA", venta.IVA);
            command.Parameters.AddWithValue("@Precio_Total", venta.Precio_Total);
            return command.ExecuteNonQuery() > 0;
        }

        public bool ModificarVenta(Venta venta)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("UPDATE Ventas SET Id_Prop = @Id_Prop, Precio = @Precio, Descuento = @Descuento, IVA = @IVA, Precio_Total = @Precio_Total WHERE Id_Venta = @Id_Venta", connection);
            command.Parameters.AddWithValue("@Id_Venta", venta.Id_Venta);
            command.Parameters.AddWithValue("@Id_Prop", venta.Id_Prop);
            command.Parameters.AddWithValue("@Precio", venta.Precio);
            command.Parameters.AddWithValue("@Descuento", venta.Descuento);
            command.Parameters.AddWithValue("@IVA", venta.IVA);
            command.Parameters.AddWithValue("@Precio_Total", venta.Precio_Total);
            return command.ExecuteNonQuery() > 0;
        }

        public bool EliminarVenta(int id)
        {
            using var connection = new MySqlConnection(connectionString);
            connection.Open();
            using var command = new MySqlCommand("DELETE FROM Ventas WHERE Id_Venta = @Id_Venta", connection);
            command.Parameters.AddWithValue("@Id_Venta", id);
            return command.ExecuteNonQuery() > 0;
        }
    }
}
