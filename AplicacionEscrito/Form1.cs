using System;
using System.Windows.Forms;
using AplicacionEscrito.Negocio;
using AplicacionEscritoEntidad;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace AplicacionEscrito
{
    public partial class Form1 : Form
    {
        private readonly ElectrodomesticoNegocio electrodomesticoNegocio = new ElectrodomesticoNegocio();
        private readonly VentaNegocio ventaNegocio = new VentaNegocio();

        public Form1()
        {
            InitializeComponent();
            CargarDatosElectrodomesticos();
            CargarDatosVentas();
        }

        private void CargarDatosElectrodomesticos()
        {
            dgvElectrodomesticos.DataSource = electrodomesticoNegocio.ObtenerElectrodomesticos();
        }

        private void CargarDatosVentas()
        {
            dgvVentas.DataSource = ventaNegocio.ObtenerVentas();
        }

        private void btnAgregarElectrodomestico_Click(object sender, EventArgs e)
        {
            var electrodomestico = new Electrodomestico
            {
                Id = int.Parse(txtIdElectrodomestico.Text),
                Nombre = txtNombre.Text,
                Precio = int.Parse(txtPrecio.Text),
                Marca = txtMarca.Text
            };

            if (electrodomesticoNegocio.AgregarElectrodomestico(electrodomestico))
            {
                MessageBox.Show("Electrodoméstico agregado con éxito.");
                CargarDatosElectrodomesticos();
            }
            else
            {
                MessageBox.Show("Error al agregar electrodoméstico.");
            }
        }

        private void btnModificarElectrodomestico_Click(object sender, EventArgs e)
        {
            var electrodomestico = new Electrodomestico
            {
                Id = int.Parse(txtIdElectrodomestico.Text),
                Nombre = txtNombre.Text,
                Precio = int.Parse(txtPrecio.Text),
                Marca = txtMarca.Text
            };

            if (electrodomesticoNegocio.ModificarElectrodomestico(electrodomestico))
            {
                MessageBox.Show("Electrodoméstico modificado con éxito.");
                CargarDatosElectrodomesticos();
            }
            else
            {
                MessageBox.Show("Error al modificar electrodoméstico.");
            }
        }

        private void btnEliminarElectrodomestico_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdElectrodomestico.Text);

            if (electrodomesticoNegocio.EliminarElectrodomestico(id))
            {
                MessageBox.Show("Electrodoméstico eliminado con éxito.");
                CargarDatosElectrodomesticos();
            }
            else
            {
                MessageBox.Show("Error al eliminar electrodoméstico.");
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            var venta = new Venta
            {
                Id_Venta = int.Parse(txtIdVenta.Text),
                Id_Electrodomestico = int.Parse(txtIdElectrodomesticoVenta.Text),
                Precio = int.Parse(txtPrecioVenta.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                IVA = int.Parse(txtIVA.Text),
                Precio_Total = int.Parse(txtPrecioTotal.Text)
            };

            if (ventaNegocio.AgregarVenta(venta))
            {
                MessageBox.Show("Venta agregada con éxito.");
                CargarDatosVentas();
            }
            else
            {
                MessageBox.Show("Error al agregar venta.");
            }
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            var venta = new Venta
            {
                Id_Venta = int.Parse(txtIdVenta.Text),
                Id_Electrodomestico = int.Parse(txtIdElectrodomesticoVenta.Text),
                Precio = int.Parse(txtPrecioVenta.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                IVA = int.Parse(txtIVA.Text),
                Precio_Total = int.Parse(txtPrecioTotal.Text)
            };

            if (ventaNegocio.ModificarVenta(venta))
            {
                MessageBox.Show("Venta modificada con éxito.");
                CargarDatosVentas();
            }
            else
            {
                MessageBox.Show("Error al modificar venta.");
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdVenta.Text);

            if (ventaNegocio.EliminarVenta(id))
            {
                MessageBox.Show("Venta eliminada con éxito.");
                CargarDatosVentas();
            }
            else
            {
                MessageBox.Show("Error al eliminar venta.");
            }
        }

        private void btnImprimirBoleta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una venta para imprimir la boleta.");
                return;
            }

            // Obtiene los datos de la venta seleccionada
            var selectedRow = dgvVentas.SelectedRows[0];
            int idVenta = Convert.ToInt32(selectedRow.Cells["Id_Venta"].Value);
            int idElectrodomestico = Convert.ToInt32(selectedRow.Cells["Id_Electrodomestico"].Value);
            int precio = Convert.ToInt32(selectedRow.Cells["Precio"].Value);
            int cantidad = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);
            int iva = Convert.ToInt32(selectedRow.Cells["IVA"].Value);
            int precioTotal = Convert.ToInt32(selectedRow.Cells["Precio_Total"].Value);

            // Ruta para guardar el archivo en el escritorio
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, $"Boleta_Venta_{idVenta}.pdf");

            // Crea el documento PDF
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();

            // Agrega contenido al PDF
            doc.Add(new Paragraph("Boleta de Venta"));
            doc.Add(new Paragraph($"ID Venta: {idVenta}"));
            doc.Add(new Paragraph($"ID Electrodoméstico: {idElectrodomestico}"));
            doc.Add(new Paragraph($"Precio Unitario: {precio}"));
            doc.Add(new Paragraph($"Cantidad: {cantidad}"));
            doc.Add(new Paragraph($"IVA: {iva}"));
            doc.Add(new Paragraph($"Precio Total: {precioTotal}"));
            doc.Add(new Paragraph("Gracias por su compra"));

            // Cierra el documento PDF
            doc.Close();

            MessageBox.Show($"Boleta generada con éxito en el escritorio: {path}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
