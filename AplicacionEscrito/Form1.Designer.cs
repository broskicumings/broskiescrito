namespace AplicacionEscrito
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvElectrodomesticos;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtIdElectrodomestico;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.TextBox txtIdElectrodomesticoVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Button btnModificarElectrodomestico;
        private System.Windows.Forms.Button btnEliminarElectrodomestico;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnImprimirBoleta;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvElectrodomesticos = new DataGridView();
            dgvVentas = new DataGridView();
            txtIdElectrodomestico = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtMarca = new TextBox();
            txtIdVenta = new TextBox();
            txtIdElectrodomesticoVenta = new TextBox();
            txtPrecioVenta = new TextBox();
            txtCantidad = new TextBox();
            txtIVA = new TextBox();
            txtPrecioTotal = new TextBox();
            btnModificarElectrodomestico = new Button();
            btnEliminarElectrodomestico = new Button();
            btnAgregarVenta = new Button();
            btnModificarVenta = new Button();
            btnEliminarVenta = new Button();
            btnImprimirBoleta = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAgregarElectrodomestico = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvElectrodomesticos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvElectrodomesticos
            // 
            dgvElectrodomesticos.Location = new Point(20, 100);
            dgvElectrodomesticos.Name = "dgvElectrodomesticos";
            dgvElectrodomesticos.Size = new Size(400, 150);
            dgvElectrodomesticos.TabIndex = 0;
            // 
            // dgvVentas
            // 
            dgvVentas.Location = new Point(20, 360);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(400, 150);
            dgvVentas.TabIndex = 1;
            // 
            // txtIdElectrodomestico
            // 
            txtIdElectrodomestico.Location = new Point(450, 100);
            txtIdElectrodomestico.Name = "txtIdElectrodomestico";
            txtIdElectrodomestico.PlaceholderText = "ID Electrodoméstico";
            txtIdElectrodomestico.Size = new Size(200, 23);
            txtIdElectrodomestico.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(450, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(450, 183);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 4;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(450, 227);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(200, 23);
            txtMarca.TabIndex = 5;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(450, 345);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.PlaceholderText = "ID Venta";
            txtIdVenta.Size = new Size(200, 23);
            txtIdVenta.TabIndex = 6;
            // 
            // txtIdElectrodomesticoVenta
            // 
            txtIdElectrodomesticoVenta.Location = new Point(450, 379);
            txtIdElectrodomesticoVenta.Name = "txtIdElectrodomesticoVenta";
            txtIdElectrodomesticoVenta.PlaceholderText = "ID Electrodoméstico";
            txtIdElectrodomesticoVenta.Size = new Size(200, 23);
            txtIdElectrodomesticoVenta.TabIndex = 7;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(450, 408);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.PlaceholderText = "Precio";
            txtPrecioVenta.Size = new Size(200, 23);
            txtPrecioVenta.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(450, 446);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "Cantidad";
            txtCantidad.Size = new Size(200, 23);
            txtCantidad.TabIndex = 9;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(450, 487);
            txtIVA.Name = "txtIVA";
            txtIVA.PlaceholderText = "IVA";
            txtIVA.Size = new Size(200, 23);
            txtIVA.TabIndex = 10;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Location = new Point(450, 523);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.PlaceholderText = "Precio Total";
            txtPrecioTotal.Size = new Size(200, 23);
            txtPrecioTotal.TabIndex = 11;
            // 
            // btnModificarElectrodomestico
            // 
            btnModificarElectrodomestico.Location = new Point(700, 176);
            btnModificarElectrodomestico.Name = "btnModificarElectrodomestico";
            btnModificarElectrodomestico.Size = new Size(150, 30);
            btnModificarElectrodomestico.TabIndex = 13;
            btnModificarElectrodomestico.Text = "Modificar Electrodoméstico";
            btnModificarElectrodomestico.Click += btnModificarElectrodomestico_Click;
            // 
            // btnEliminarElectrodomestico
            // 
            btnEliminarElectrodomestico.Location = new Point(700, 222);
            btnEliminarElectrodomestico.Name = "btnEliminarElectrodomestico";
            btnEliminarElectrodomestico.Size = new Size(150, 30);
            btnEliminarElectrodomestico.TabIndex = 14;
            btnEliminarElectrodomestico.Text = "Eliminar Electrodoméstico";
            btnEliminarElectrodomestico.Click += btnEliminarElectrodomestico_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(700, 345);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(150, 30);
            btnAgregarVenta.TabIndex = 15;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Location = new Point(700, 408);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(150, 30);
            btnModificarVenta.TabIndex = 16;
            btnModificarVenta.Text = "Modificar Venta";
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(700, 467);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(150, 30);
            btnEliminarVenta.TabIndex = 17;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnImprimirBoleta
            // 
            btnImprimirBoleta.Location = new Point(700, 523);
            btnImprimirBoleta.Name = "btnImprimirBoleta";
            btnImprimirBoleta.Size = new Size(150, 30);
            btnImprimirBoleta.TabIndex = 18;
            btnImprimirBoleta.Text = "Imprimir Boleta";
            btnImprimirBoleta.Click += btnImprimirBoleta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(302, 47);
            label1.TabIndex = 19;
            label1.Text = "Electrodomesticos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(20, 300);
            label2.Name = "label2";
            label2.Size = new Size(123, 47);
            label2.TabIndex = 20;
            label2.Text = "Ventas";
            label2.Click += label2_Click;
            // 
            // btnAgregarElectrodomestico
            // 
            btnAgregarElectrodomestico.Location = new Point(700, 128);
            btnAgregarElectrodomestico.Name = "btnAgregarElectrodomestico";
            btnAgregarElectrodomestico.Size = new Size(150, 30);
            btnAgregarElectrodomestico.TabIndex = 12;
            btnAgregarElectrodomestico.Text = "Agregar Electrodoméstico";
            btnAgregarElectrodomestico.Click += btnAgregarElectrodomestico_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1000, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvElectrodomesticos);
            Controls.Add(dgvVentas);
            Controls.Add(txtIdElectrodomestico);
            Controls.Add(txtNombre);
            Controls.Add(txtPrecio);
            Controls.Add(txtMarca);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIdElectrodomesticoVenta);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCantidad);
            Controls.Add(txtIVA);
            Controls.Add(txtPrecioTotal);
            Controls.Add(btnAgregarElectrodomestico);
            Controls.Add(btnModificarElectrodomestico);
            Controls.Add(btnEliminarElectrodomestico);
            Controls.Add(btnAgregarVenta);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnImprimirBoleta);
            Name = "Form1";
            Text = "Gestión de Electrodomésticos y Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvElectrodomesticos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Button btnAgregarElectrodomestico;
    }
}
