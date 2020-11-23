using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Archivos;
using System.Data;

namespace Sbaglia_Santiago_1D_tp4
{
    public static class BaseDeDatos
    {

        private static SqlConnection sqlConnection;



        static  BaseDeDatos()
        {
            string connectionString = "Server=.;Database=ProductosDB;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(connectionString);

        }


        public static void InsertarProducto(Producto producto)
        {
            try
            { 


                string command = "INSERT INTO Productos(nombre,precio)" + $"VALUES(Nombre , Precio, Descripcion )";
                
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);// generar un objeto


                sqlCommand.Parameters.AddWithValue("Nombre", producto.Nombre);
                sqlCommand.Parameters.AddWithValue("Precio", producto.Precio);
                sqlCommand.Parameters.AddWithValue("Descripcion", producto.Descripcion);



                sqlConnection.Open(); //abrir la coneccion 
                sqlCommand.ExecuteNonQuery();// nos devuelve la cantidad de filas
            }
            finally
            {
                if (sqlConnection.State==System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

           
            
            

        }







        public static void InsertarCliente(Cliente cliente)
        {
            try
            {


                string command = "INSERT INTO Clientes(Nombre,Precio,Descripcion)" + $"VALUES(Nombre , Precio, Descripcion )";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);// generar un objeto


                sqlCommand.Parameters.AddWithValue("Nombre", cliente.Nombre);
                sqlCommand.Parameters.AddWithValue("Dni", cliente.Dni);
                sqlCommand.Parameters.AddWithValue("Usuario", cliente.Usuario);
                sqlCommand.Parameters.AddWithValue("Contrasenia", cliente.Contrasenia);
                sqlCommand.Parameters.AddWithValue("Apellido", cliente.Apellido);



                sqlConnection.Open(); //abrir la coneccion 
                sqlCommand.ExecuteNonQuery();// nos devuelve la cantidad de filas
            }
            catch (Exception ex)
            {
               
                string NombreArchivo = "TP4 Santiago Sbaglia";
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                FIle<Exception>.EscribirArchivoTexto(ruta, NombreArchivo, ex, false);
                
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }



        }






        /// <summary>
        /// genero getCliente
        /// </summary>
        /// <returns></returns>

        public static List<Cliente> GetCliente()
        {
            List<Cliente> auxCliente = new List<Cliente>();
            try
            {

                SqlCommand comandito = new SqlCommand();

                comandito.Connection = sqlConnection;
                comandito.CommandType = CommandType.Text;
                comandito.CommandText = "SELECT * FROM Clientes";

                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();


                SqlDataReader datosDevueltos = comandito.ExecuteReader();


                while (datosDevueltos.Read())
                {
                    auxCliente.Add(new Cliente(datosDevueltos["Nombre"].ToString(),
                                              int.Parse(datosDevueltos["Dni"].ToString()),
                                                datosDevueltos["Usuario"].ToString(),
                                                datosDevueltos["Contraseña"].ToString(),
                                                datosDevueltos["Apellido"].ToString()));

                   
                }
                

                return auxCliente;
            }

            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                sqlConnection.Close();
            }
        }












        public static List<Producto> GetProducto()
        {
            List<Producto> auxProd = new List<Producto>();
            try
            {

                SqlCommand comandito = new SqlCommand();

                comandito.Connection = sqlConnection;
                comandito.CommandType = CommandType.Text;
                comandito.CommandText = "SELECT * FROM Productos";

                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();


                SqlDataReader datosDevueltos = comandito.ExecuteReader();


                while (datosDevueltos.Read())
                {
                    auxProd.Add(new Producto(int.Parse(datosDevueltos["Id"].ToString()),
                                                datosDevueltos["Nombre"].ToString(),
                                              float.Parse(datosDevueltos["Precio"].ToString()),
                                                datosDevueltos["Descripcion"].ToString()));
                                                

                }

                return auxProd;
            }

            catch (Exception ex)
            {
                return null;
            }

            finally
            {
                sqlConnection.Close();
            }
        }











    }
}
