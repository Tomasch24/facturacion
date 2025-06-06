using System;
using ConexionDatos;
using capa_negocios;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace capa_presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           GenerarFactura();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        //TODO Evento del boton guardar para insertar los datos a la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            
            Factura factura = new Factura();

            if (cbTipo.SelectedItem.ToString() == "Contado")
                factura = new FacturaContado();
            else
                factura = new FacturaCredito();

            //TODO Capturas de error para no dejar los campos Cliente y Referencia de Producto en blanco
            try
            {
                factura.Cliente = txtCliente.Text;

                if (string.IsNullOrWhiteSpace(factura.Cliente))
                
                    throw new Exception("Favor ingrese Nombre del Cliente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el campo Cliente. " + ex.Message);
                return; 
            }
           
            try
            {
                factura.Descripcion = txtDescripcion.Text;

                if (string.IsNullOrWhiteSpace(factura.Descripcion))
                {
                    throw new Exception("Favor Coloque una Referencia del Producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el campo Referencia de Producto.  " + ex.Message);
                return; 
            }

            //TODO Captura de error para solo ingresar numeros en el campo precio
            decimal precio;

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio ingresado no es válido. Por favor igrese un valor numerico.");
                return;
            }
            factura.Precio = precio;

            factura.Telefono = txtTelef1.Text;
            factura.Rnc = txtRnc.Text;
            factura.Fecha = dtpFecha.Value;
            factura.Cantidad = int.Parse(txtCantidad.Text);

            //TODO captura de exito o error al infresar datos
            int result = FacturaDal.IngresarDatos(factura);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura");
            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar");
            }

            GenerarFactura();
            LimpiarCampos();    
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO se añaden contado y credito para el CB del tipo de factura
            cbTipo.Items.Add("Contado");
            cbTipo.Items.Add("Crédito");
            cbTipo.SelectedIndex = 0;
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TODO Metodo Generar Factura (Aqui esta)
        private void GenerarFactura()
        {
            FacturaDatos data = new FacturaDatos();
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                SqlDataAdapter adapt;
                conn.Open();

                DataTable dt = new DataTable();

                adapt = new SqlDataAdapter("SELECT * FROM Factura", conn);

                adapt.Fill(dt);

                dgvFactura.DataSource = dt;

                conn.Close();
            }
        }
        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelef1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            
        }
        //TODO Metodo para Limpiar Campos
        private void LimpiarCampos()
        {
            txtCliente.Text = "";
            txtTelef1.Text = "";
            txtRnc.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }
    }
}
