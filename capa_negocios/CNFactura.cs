using System;
using System.Runtime.CompilerServices;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace capa_negocios
{
    public class Factura
    {
        public int ID { get; set; }
        public string Cliente { get; set; }
        public string Telefono { get; set; }
        public string Rnc { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total => Precio * Cantidad;

        public virtual string Tipo { get; set; }




    }
    public class FacturaContado : Factura
    {
        public override string Tipo => "Contado";

    }
    public class FacturaCredito : Factura
    {
        public override string Tipo => "Credito";

    }
    public class FacturaDal
    {
        public static int IngresarDatos(Factura factura)
        {
            int retorna = 0;
            FacturaDatos data = new FacturaDatos();
            //Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                //se abre la base de datos

                conn.Open();

                // comando sql
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

            }
            return retorna;
        }

        public static List<Factura> GenerarFactura()
        {
            List<Factura> lista = new List<Factura>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();

                string query = "SELECT * FROM Factura";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Factura factura = new Factura();

                    string tipo = reader["Tipo"].ToString();

                    if (tipo == "Contado")
                        factura = new FacturaContado();
                    else
                        factura = new FacturaCredito();


                    factura.ID = Convert.ToInt32(reader["ID"]);
                    factura.Cliente = reader["Cliente"].ToString();
                    factura.Telefono = reader["Telefono"].ToString();
                    factura.Rnc = reader["RNC"].ToString();
                    factura.Fecha = Convert.ToDateTime(reader["Fecha"]);
                    factura.Descripcion = reader["Descripcion"].ToString();
                    factura.Precio = Convert.ToDecimal(reader["Precio"]);
                    factura.Cantidad = Convert.ToInt32(reader["Cantidad"]);

                    lista.Add(factura);
                }
                conn.Close();
                return lista;
            }

            
        }

        
    }
     
    
}
    




