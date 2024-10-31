namespace AplicacionEscrito
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPropiedades;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtIdPropiedad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtMetrosCuadrados;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.TextBox txtIdProp;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Button btnAgregarPropiedad;
        private System.Windows.Forms.Button btnModificarPropiedad;
        private System.Windows.Forms.Button btnEliminarPropiedad;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnModificarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.Button btnImprimirBoleta;

        private void InitializeComponent()
        {
            dgvPropiedades = new DataGridView();
            dgvVentas = new DataGridView();
            txtIdPropiedad = new TextBox();
            txtDireccion = new TextBox();
            txtPrecio = new TextBox();
            cbTipo = new ComboBox();
            txtMetrosCuadrados = new TextBox();
            txtIdVenta = new TextBox();
            txtIdProp = new TextBox();
            txtPrecioVenta = new TextBox();
            txtDescuento = new TextBox();
            txtIVA = new TextBox();
            txtPrecioTotal = new TextBox();
            btnAgregarPropiedad = new Button();
            btnModificarPropiedad = new Button();
            btnEliminarPropiedad = new Button();
            btnAgregarVenta = new Button();
            btnModificarVenta = new Button();
            btnEliminarVenta = new Button();
            btnImprimirBoleta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // dgvPropiedades
            // 
            dgvPropiedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropiedades.Location = new Point(12, 12);
            dgvPropiedades.Name = "dgvPropiedades";
            dgvPropiedades.Size = new Size(400, 200);
            dgvPropiedades.TabIndex = 0;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(12, 236);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(400, 200);
            dgvVentas.TabIndex = 1;
            // 
            // txtIdPropiedad
            // 
            txtIdPropiedad.Location = new Point(450, 12);
            txtIdPropiedad.Name = "txtIdPropiedad";
            txtIdPropiedad.Size = new Size(200, 23);
            txtIdPropiedad.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(450, 40);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(200, 23);
            txtDireccion.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(450, 70);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 4;
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(450, 100);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(200, 23);
            cbTipo.TabIndex = 5;
            // 
            // txtMetrosCuadrados
            // 
            txtMetrosCuadrados.Location = new Point(450, 130);
            txtMetrosCuadrados.Name = "txtMetrosCuadrados";
            txtMetrosCuadrados.Size = new Size(200, 23);
            txtMetrosCuadrados.TabIndex = 6;
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(450, 223);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(200, 23);
            txtIdVenta.TabIndex = 7;
            // 
            // txtIdProp
            // 
            txtIdProp.Location = new Point(450, 252);
            txtIdProp.Name = "txtIdProp";
            txtIdProp.Size = new Size(200, 23);
            txtIdProp.TabIndex = 8;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(450, 291);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(200, 23);
            txtPrecioVenta.TabIndex = 9;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(450, 329);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(200, 23);
            txtDescuento.TabIndex = 10;
            txtDescuento.TextChanged += txtDescuento_TextChanged;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(450, 358);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(200, 23);
            txtIVA.TabIndex = 11;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Location = new Point(450, 397);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(200, 23);
            txtPrecioTotal.TabIndex = 12;
            // 
            // btnAgregarPropiedad
            // 
            btnAgregarPropiedad.Location = new Point(700, 12);
            btnAgregarPropiedad.Name = "btnAgregarPropiedad";
            btnAgregarPropiedad.Size = new Size(150, 23);
            btnAgregarPropiedad.TabIndex = 13;
            btnAgregarPropiedad.Text = "Agregar Propiedad";
            btnAgregarPropiedad.UseVisualStyleBackColor = true;
            btnAgregarPropiedad.Click += btnAgregarPropiedad_Click;
            // 
            // btnModificarPropiedad
            // 
            btnModificarPropiedad.Location = new Point(700, 42);
            btnModificarPropiedad.Name = "btnModificarPropiedad";
            btnModificarPropiedad.Size = new Size(150, 23);
            btnModificarPropiedad.TabIndex = 14;
            btnModificarPropiedad.Text = "Modificar Propiedad";
            btnModificarPropiedad.UseVisualStyleBackColor = true;
            btnModificarPropiedad.Click += btnModificarPropiedad_Click;
            // 
            // btnEliminarPropiedad
            // 
            btnEliminarPropiedad.Location = new Point(700, 72);
            btnEliminarPropiedad.Name = "btnEliminarPropiedad";
            btnEliminarPropiedad.Size = new Size(150, 23);
            btnEliminarPropiedad.TabIndex = 15;
            btnEliminarPropiedad.Text = "Eliminar Propiedad";
            btnEliminarPropiedad.UseVisualStyleBackColor = true;
            btnEliminarPropiedad.Click += btnEliminarPropiedad_Click;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(700, 223);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(150, 23);
            btnAgregarVenta.TabIndex = 16;
            btnAgregarVenta.Text = "Agregar Venta";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // btnModificarVenta
            // 
            btnModificarVenta.Location = new Point(700, 252);
            btnModificarVenta.Name = "btnModificarVenta";
            btnModificarVenta.Size = new Size(150, 23);
            btnModificarVenta.TabIndex = 17;
            btnModificarVenta.Text = "Modificar Venta";
            btnModificarVenta.UseVisualStyleBackColor = true;
            btnModificarVenta.Click += btnModificarVenta_Click;
            // 
            // btnEliminarVenta
            // 
            btnEliminarVenta.Location = new Point(700, 281);
            btnEliminarVenta.Name = "btnEliminarVenta";
            btnEliminarVenta.Size = new Size(150, 23);
            btnEliminarVenta.TabIndex = 18;
            btnEliminarVenta.Text = "Eliminar Venta";
            btnEliminarVenta.UseVisualStyleBackColor = true;
            btnEliminarVenta.Click += btnEliminarVenta_Click;
            // 
            // btnImprimirBoleta
            // 
            btnImprimirBoleta.Location = new Point(700, 310);
            btnImprimirBoleta.Name = "btnImprimirBoleta";
            btnImprimirBoleta.Size = new Size(150, 23);
            btnImprimirBoleta.TabIndex = 19;
            btnImprimirBoleta.Text = "Descargar Boleta PDF";
            btnImprimirBoleta.UseVisualStyleBackColor = true;
            btnImprimirBoleta.Click += btnImprimirBoleta_Click;
            // 
            // Form1
            // 
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1006, 477);
            Controls.Add(dgvPropiedades);
            Controls.Add(dgvVentas);
            Controls.Add(txtIdPropiedad);
            Controls.Add(txtDireccion);
            Controls.Add(txtPrecio);
            Controls.Add(cbTipo);
            Controls.Add(txtMetrosCuadrados);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIdProp);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtDescuento);
            Controls.Add(txtIVA);
            Controls.Add(txtPrecioTotal);
            Controls.Add(btnAgregarPropiedad);
            Controls.Add(btnModificarPropiedad);
            Controls.Add(btnEliminarPropiedad);
            Controls.Add(btnAgregarVenta);
            Controls.Add(btnModificarVenta);
            Controls.Add(btnEliminarVenta);
            Controls.Add(btnImprimirBoleta);
            Name = "Form1";
            Text = "Aplicación Inmobiliaria";
            ((System.ComponentModel.ISupportInitialize)dgvPropiedades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

