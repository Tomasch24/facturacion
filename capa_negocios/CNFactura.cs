using System;
using System.Data;
using System.Runtime.CompilerServices;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace capa_negocios
{
    public class Factura
    {
        //TODO atributos que se guardaran en la base de datos
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Telefono { get; set; }
        public string Rnc { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total => Precio * Cantidad; //Calculo del total de la factura

        //TODO metodo virtual para sobrescribir en clases hijas contado y credito
        public virtual string Tipo { get; set; }
    }
    public class FacturaContado : Factura
    {
        //TODO Se utiliza el "override" para sobrescribir el tipo
        public override string Tipo => "Contado";
    }
    public class FacturaCredito : Factura
    {
        //TODO Se utiliza el "override" para sobrescribir el tipo
        public override string Tipo => "Credito";
    }
    public class FacturaDal
    {
        //TODO Metodo para ingresar los datos de la factura
        public static int IngresarDatos(Factura factura)
        {
            int retorna = 0;
            FacturaDatos data = new FacturaDatos();
            //TODO Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                //TODO se abre la base de datos
                conn.Open();

                // TODO comando sql para que se guarden los datos que inserte el usuario en la base de datos
                string query = "INSERT INTO Factura(Cliente,Telefono,RNC,Fecha,Descripcion,Precio,Cantidad,Total,Tipo) VALUES(@Cliente, @Telefono, @RNC, @Fecha, @Descripcion, @Precio, @Cantidad, @Total, @Tipo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cliente", factura.Cliente);
                cmd.Parameters.AddWithValue("@Telefono", factura.Telefono);
                cmd.Parameters.AddWithValue("@RNC", factura.Rnc);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", factura.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", factura.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                cmd.Parameters.AddWithValue("@Total", factura.Total);
                cmd.Parameters.AddWithValue("@Tipo", factura.Tipo);

                retorna = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return retorna;
        }

        public void GenerarFactura()
        {
            DataTable dt = new DataTable();

            FacturaDatos data = new FacturaDatos();
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                SqlDataAdapter adapt;
                conn.Open();
                adapt = new SqlDataAdapter("SELECT * FROM Factura", conn);

                adapt.Fill(dt);
                
                conn.Close();
            }
        }
    }
}
    




