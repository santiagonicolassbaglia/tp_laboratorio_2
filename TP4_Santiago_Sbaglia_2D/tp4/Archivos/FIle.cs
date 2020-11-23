using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Archivos
{
    public class FIle<T>
    {
        public static void EscribirArchivoTexto(string ruta, string nombre, T texto, bool anexar)
        {
            StreamWriter streamWriter = null;

            try
            {


                string rutaCompleta = ruta + @"\" + nombre + ".txt";
                streamWriter = new StreamWriter(rutaCompleta, anexar);

                streamWriter.WriteLine(texto);



            }
            finally
            {
                if (streamWriter != null)
                    streamWriter.Close();

            }


        }

        public string LeerArchivoTexto(string ruta, string nombre)
        {
            StreamReader streamReader = null;

            try
            {
                string rutaCompleta = ruta + @"\" + nombre + ".txt";


                streamReader = new StreamReader(rutaCompleta);
                streamReader.ReadLine();

                string text = string.Empty;
                string nuevaLinea = streamReader.ReadLine();

                while ((nuevaLinea != null))
                {
                    text += nuevaLinea;
                    nuevaLinea = streamReader.ReadLine();
                }

                return text;

            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();

            }


        }









    }
}
