using System;
using System.Windows.Forms;
using AplicacionEscrito.Negocio;
using AplicacionEscritoEntidad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace AplicacionEscrito
{
    public partial class Form1 : Form
    {
        private readonly PropiedadNegocio propiedadNegocio = new PropiedadNegocio();
        private readonly VentaNegocio ventaNegocio = new VentaNegocio();

        public Form1()
        {
            InitializeComponent();
            cbTipo.DataSource = Enum.GetValues(typeof(TipoPropiedad)); // Cargar tipos de propiedad
            CargarDatosPropiedades();
            CargarDatosVentas();
        }

        private void CargarDatosPropiedades()
        {
            dgvPropiedades.DataSource = propiedadNegocio.ObtenerPropiedades();
        }

        private void CargarDatosVentas()
        {
            dgvVentas.DataSource = ventaNegocio.ObtenerVentas();
        }

        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            var propiedad = new Propiedad
            {
                Id = int.Parse(txtIdPropiedad.Text),
                Direccion = txtDireccion.Text,
                Precio = int.Parse(txtPrecio.Text),
                Tipo = (TipoPropiedad)Enum.Parse(typeof(TipoPropiedad), cbTipo.SelectedItem.ToString()),
                MetrosCuadrados = txtMetrosCuadrados.Text
            };

            if (propiedadNegocio.AgregarPropiedad(propiedad))
            {
                MessageBox.Show("Propiedad agregada con éxito.");
                CargarDatosPropiedades();
            }
            else
            {
                MessageBox.Show("Error al agregar propiedad.");
            }
        }

        private void btnModificarPropiedad_Click(object sender, EventArgs e)
        {
            var propiedad = new Propiedad
            {
                Id = int.Parse(txtIdPropiedad.Text),
                Direccion = txtDireccion.Text,
                Precio = int.Parse(txtPrecio.Text),
                Tipo = (TipoPropiedad)Enum.Parse(typeof(TipoPropiedad), cbTipo.SelectedItem.ToString()),
                MetrosCuadrados = txtMetrosCuadrados.Text
            };

            if (propiedadNegocio.ModificarPropiedad(propiedad))
            {
                MessageBox.Show("Propiedad modificada con éxito.");
                CargarDatosPropiedades();
            }
            else
            {
                MessageBox.Show("Error al modificar propiedad.");
            }
        }

        private void btnEliminarPropiedad_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdPropiedad.Text);

            if (propiedadNegocio.EliminarPropiedad(id))
            {
                MessageBox.Show("Propiedad eliminada con éxito.");
                CargarDatosPropiedades();
            }
            else
            {
                MessageBox.Show("Error al eliminar propiedad.");
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            int precio = int.Parse(txtPrecioVenta.Text);
            int descuento = 0;

            // Aplicar descuento si el tipo de propiedad es "Terreno"
            if (cbTipo.SelectedItem.ToString() == "Terreno")
            {
                descuento = (int)(precio * 0.15); // 15% de descuento
            }

            var venta = new Venta
            {
                Id_Venta = int.Parse(txtIdVenta.Text),
                Id_Prop = int.Parse(txtIdProp.Text),
                Precio = precio,
                Descuento = descuento,
                IVA = int.Parse(txtIVA.Text),
                Precio_Total = precio - descuento + int.Parse(txtIVA.Text) // Asegúrate de calcular el total correctamente
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
            int precio = int.Parse(txtPrecioVenta.Text);
            int descuento = 0;

            // Aplicar descuento si el tipo de propiedad es "Terreno"
            if (cbTipo.SelectedItem.ToString() == "Terreno")
            {
                descuento = (int)(precio * 0.15); // 15% de descuento
            }

            var venta = new Venta
            {
                Id_Venta = int.Parse(txtIdVenta.Text),
                Id_Prop = int.Parse(txtIdProp.Text),
                Precio = precio,
                Descuento = descuento,
                IVA = int.Parse(txtIVA.Text),
                Precio_Total = (precio - descuento) % 22 
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
            int idProp = Convert.ToInt32(selectedRow.Cells["Id_Prop"].Value);
            int precio = Convert.ToInt32(selectedRow.Cells["Precio"].Value);
            int descuento = Convert.ToInt32(selectedRow.Cells["Descuento"].Value);
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
            doc.Add(new Paragraph($"ID Propiedad: {idProp}"));
            doc.Add(new Paragraph($"Precio: {precio}"));
            doc.Add(new Paragraph($"Descuento: {descuento}"));
            doc.Add(new Paragraph($"IVA: {iva}"));
            doc.Add(new Paragraph($"Precio Total: {precioTotal}"));
            doc.Add(new Paragraph("Gracias por su compra"));

            // Cierra el documento PDF
            doc.Close();

            MessageBox.Show($"Boleta generada con éxito en el escritorio: {path}");
        }

        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
