using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        #region METODOS DE LA INTERFAZ

        /// <summary>
        /// Metodo implentado de la interfaz IArchivo
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a ser guardado</param>
        /// <returns>true si funciono false si no</returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(datos);

                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        /// <summary>
        /// Metodo implentado de la interfaz IArchivo
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a devolver es un parametro de tipo OUT</param>
        /// <returns>true si funciono false si no</returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using(StreamReader sr = new StreamReader(archivo))
                {
                    datos = string.Empty;
                    datos = sr.ReadToEnd();

                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        #endregion
    }
}
