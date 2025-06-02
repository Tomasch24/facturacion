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
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            dtpFecha = new DateTimePicker();
            button1 = new Button();
            cbTipo = new ComboBox();
            facturaDalBindingSource = new BindingSource(components);
            dgvFactura = new DataGridView();
            label1 = new Label();
            txtTelef1 = new MaskedTextBox();
            txtRnc = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(29, 119);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(81, 27);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            lblCliente.Click += label1_Click;
            // 
            // lblTelef
            // 
            lblTelef.AutoSize = true;
            lblTelef.BackColor = Color.Transparent;
            lblTelef.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelef.Location = new Point(29, 173);
            lblTelef.Name = "lblTelef";
            lblTelef.Size = new Size(96, 27);
            lblTelef.TabIndex = 100;
            lblTelef.Text = "Telefono";
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.Transparent;
            lblRnc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRnc.Location = new Point(29, 225);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(61, 27);
            lblRnc.TabIndex = 3;
            lblRnc.Text = "RNC";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(30, 349);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(262, 32);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion de venta";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(29, 497);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(74, 27);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(29, 539);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(99, 27);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(29, 586);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(55, 27);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            lblTipo.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 276);
            label9.Name = "label9";
            label9.Size = new Size(70, 27);
            label9.TabIndex = 9;
            label9.Text = "Fecha";
            label9.Click += label9_Click;
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.BackColor = Color.Transparent;
            lblSistema.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistema.Location = new Point(57, 24);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(374, 41);
            lblSistema.TabIndex = 11;
            lblSistema.Text = "Sistema de Facturacion";
            lblSistema.Click += label11_Click;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(164, 115);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(318, 28);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += textBox1_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 430);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(318, 31);
            txtDescripcion.TabIndex = 5;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(164, 493);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(318, 31);
            txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(164, 537);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(318, 31);
            txtCantidad.TabIndex = 7;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(164, 276);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(318, 28);
            dtpFecha.TabIndex = 4;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(147, 656);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
            button1.TabIndex = 24;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(164, 584);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(318, 33);
            cbTipo.TabIndex = 8;
            cbTipo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AllowUserToResizeColumns = false;
            dgvFactura.AllowUserToResizeRows = false;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(556, 94);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowHeadersWidth = 62;
            dgvFactura.Size = new Size(761, 530);
            dgvFactura.TabIndex = 26;
            dgvFactura.TabStop = false;
            dgvFactura.CellContentClick += dgvFactura_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 420);
            label1.Name = "label1";
            label1.Size = new Size(129, 54);
            label1.TabIndex = 27;
            label1.Text = "Referencia \r\nde Producto\r\n";
            // 
            // txtTelef1
            // 
            txtTelef1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelef1.Location = new Point(164, 169);
            txtTelef1.Mask = "+1 (999) 000-0000";
            txtTelef1.Name = "txtTelef1";
            txtTelef1.Size = new Size(318, 30);
            txtTelef1.TabIndex = 2;
            // 
            // txtRnc
            // 
            txtRnc.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRnc.Location = new Point(164, 221);
            txtRnc.Mask = "000-0000000-0";
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(318, 28);
            txtRnc.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1392, 792);
            Controls.Add(txtRnc);
            Controls.Add(txtTelef1);
            Controls.Add(label1);
            Controls.Add(dgvFactura);
            Controls.Add(cbTipo);
            Controls.Add(button1);
            Controls.Add(dtpFecha);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
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
            ForeColor = SystemColors.ControlText;
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
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private DateTimePicker dtpFecha;
        private Button button1;
        private ComboBox cbTipo;
        private BindingSource facturaDalBindingSource;
        private DataGridView dgvFactura;
        private Label label1;
        private MaskedTextBox txtTelef1;
        private MaskedTextBox txtRnc;
    }
}
