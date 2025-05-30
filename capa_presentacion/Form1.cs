using System;
using ConexionDatos;
using capa_negocios;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();

            if (cbTipo.SelectedItem.ToString() == "Contado")
                factura = new FacturaContado();
            else
                factura = new FacturaCredito();

            factura.Cliente = txtCliente.Text;
            factura.Telefono = txtTelef.Text;
            factura.Rnc = txtRnc.Text;
            factura.Fecha = dtpFecha.Value;
            factura.Descripcion = txtDescripcion.Text;
            factura.Precio = decimal.Parse(txtPrecio.Text);
            factura.Cantidad = int.Parse(txtCantidad.Text);



            int result = FacturaDal.IngresarDatos(factura);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura");
            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del autor de este codigo dejo de compilar");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
