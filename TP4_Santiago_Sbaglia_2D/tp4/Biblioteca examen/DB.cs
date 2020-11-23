
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Archivos;

namespace Sbaglia_Santiago_1D_tp4
{
    public static  class DB
    {



        static SqlConnection conectarAlDB;



        static DB()
        {
            conectarAlDB = new SqlConnection("Server=.;Database=ProductosDB;Trusted_Connection=True;");
        }






        public static Cliente validaUsuario(string usuario, string pass)
        {
            SqlCommand commandd;
            commandd = new SqlCommand();
            SqlConnection sqlConnection;
            string connectionString = "Server=.;Database=ProductosDB;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(connectionString);

            string sql = "select * from Clientes  where  usuario = @usuario and contraseña = @password";
            commandd.CommandText = sql;
            commandd.Parameters.Clear();
            commandd.Parameters.Add(new SqlParameter("@usuario", usuario));
            commandd.Parameters.Add(new SqlParameter("@password", pass));

            commandd.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                SqlDataReader dr = commandd.ExecuteReader(); // envia a la base de datos , lo ejecuta y recibe la respuesta.. la motito
                if (dr.Read())
                {

                    Cliente user = new Cliente("Santiago", 4080800, "santi", "1234", "sbaglia");
                    user.Usuario = usuario;
                    user.Dni = int.Parse(dr["Dni"].ToString());

                    user.Nombre = dr["Nombre"].ToString();
                    user.Apellido = dr["Apellido"].ToString();
                    user.Contrasenia = pass;

                    return user;
                }
                else
                    return null;


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                sqlConnection.Close();
            }

        }






        public static string CreateMD5(string input) // genera un string .. es para validacion de contenido. 
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }















        /*


        public static List < Producto> InsertarCliente(Cliente cliente)
        {
            
            try
            {

              
                string sql = "INSERT INTO Clientes(Nombre,Dni,Usuario,Contraseña,Apellido)" + $"VALUES(@nombre , @dni ,@usuario,@contraseña,@apellido)";
                comand.CommandText = sql;
                comand.Parameters.Clear();
                comand = new SqlCommand();
                SqlCommand sqlCommand = new SqlCommand();// generar un objeto


                sqlCommand.Parameters.AddWithValue("Nombre", cliente.Nombre);
                sqlCommand.Parameters.AddWithValue("Dni", cliente.Dni);
                sqlCommand.Parameters.AddWithValue("Usuario", cliente.Usuario);
                sqlCommand.Parameters.AddWithValue("Contraseña", cliente.Contrasenia);
                sqlCommand.Parameters.AddWithValue("Apellido", cliente.Apellido);





                this.conectarAlDB.Open(); //abrir la coneccion 
                sqlCommand.ExecuteNonQuery();// nos devuelve la cantidad de filas y que no sea select min1 :15
                return cliente;

            }
            finally
            {
                if (this.conectarAlDB.State == System.Data.ConnectionState.Open)
                {
                    this.conectarAlDB.Close();
                }
            }





        }


       

       public static Cliente validaUsuario(string usuario, string pass)
        {
            
            comand = new SqlCommand(); 
             SqlConnection sqlConnection;
            string connectionString = "Server=.;Database=ProductosDB;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(connectionString);

          
            comand.Connection = sqlConnection;
            try
            {
                 sqlConnection.Open();
                SqlDataReader dr = comand.ExecuteReader(); // envia a la base de datos , lo ejecuta y recibe la respuesta.. la motito
                if (dr.Read())
                {
                    Cliente user = new Cliente("Santiago", 4080800, "santi", "1234", "sbaglia");
                    user.Usuario = usuario;
                    user.Dni = int.Parse(dr["Dni"].ToString());
          
                    user.Nombre = dr["Nombre"].ToString();
                    user.Apellido = dr["Apellido"].ToString();
                    user.Contrasenia = pass;

                    return user;
                }
                else
                    return null;


            }
            catch (Exception ex )
            {
               throw ex;

            }
            finally
            {
                sqlConnection.Close();
            }

        }






        public static string CreateMD5(string input) // genera un string .. es para validacion de contenido. 
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }






        */



    }




}
