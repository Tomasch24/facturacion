namespace capa_presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblCliente = new Label();
            lblTelef = new Label();
            lblRnc = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblTipo = new Label();
            label9 = new Label();
            lblSistema = new Label();
            txtCliente = new TextBox();
            txtTelef = new TextBox();
            txtRnc = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            dtpFecha = new DateTimePicker();
            button1 = new Button();
            cbTipo = new ComboBox();
            facturaDalBindingSource = new BindingSource(components);
            dgvFactura = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(29, 143);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 25);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            lblCliente.Click += label1_Click;
            // 
            // lblTelef
            // 
            lblTelef.AutoSize = true;
            lblTelef.Location = new Point(29, 202);
            lblTelef.Name = "lblTelef";
            lblTelef.Size = new Size(79, 25);
            lblTelef.TabIndex = 2;
            lblTelef.Text = "Telefono";
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.Location = new Point(29, 256);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(47, 25);
            lblRnc.TabIndex = 3;
            lblRnc.Text = "RNC";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(29, 353);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 25);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(29, 399);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(29, 448);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(83, 25);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(29, 498);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 25);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            lblTipo.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 305);
            label9.Name = "label9";
            label9.Size = new Size(57, 25);
            label9.TabIndex = 9;
            label9.Text = "Fecha";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.Location = new Point(57, 24);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(193, 25);
            lblSistema.TabIndex = 11;
            lblSistema.Text = "Sistema de Facturacion";
            lblSistema.Click += label11_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(147, 137);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(318, 31);
            txtCliente.TabIndex = 12;
            txtCliente.TextChanged += textBox1_TextChanged;
            // 
            // txtTelef
            // 
            txtTelef.Location = new Point(147, 196);
            txtTelef.Name = "txtTelef";
            txtTelef.Size = new Size(318, 31);
            txtTelef.TabIndex = 13;
            // 
            // txtRnc
            // 
            txtRnc.Location = new Point(147, 250);
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(318, 31);
            txtRnc.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(147, 347);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(318, 31);
            txtDescripcion.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(147, 393);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(318, 31);
            txtPrecio.TabIndex = 17;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(147, 442);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(318, 31);
            txtCantidad.TabIndex = 18;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(147, 299);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(318, 31);
            dtpFecha.TabIndex = 22;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(147, 590);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 24;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(147, 490);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(318, 33);
            cbTipo.TabIndex = 25;
            cbTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // facturaDalBindingSource
            // 
            facturaDalBindingSource.DataSource = typeof(capa_negocios.FacturaDal);
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(556, 94);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 62;
            dgvFactura.Size = new Size(761, 530);
            dgvFactura.TabIndex = 26;
            dgvFactura.CellContentClick += dgvFactura_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 792);
            Controls.Add(dgvFactura);
            Controls.Add(cbTipo);
            Controls.Add(button1);
            Controls.Add(dtpFecha);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtRnc);
            Controls.Add(txtTelef);
            Controls.Add(txtCliente);
            Controls.Add(lblSistema);
            Controls.Add(label9);
            Controls.Add(lblTipo);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblRnc);
            Controls.Add(lblTelef);
            Controls.Add(lblCliente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCliente;
        private Label lblTelef;
        private Label lblRnc;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblTipo;
        private Label label9;
        private Label lblSistema;
        private TextBox txtCliente;
        private TextBox txtTelef;
        private TextBox txtRnc;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private DateTimePicker dtpFecha;
        private Button button1;
        private ComboBox cbTipo;
        private BindingSource facturaDalBindingSource;
        private DataGridView dgvFactura;
    }
}
