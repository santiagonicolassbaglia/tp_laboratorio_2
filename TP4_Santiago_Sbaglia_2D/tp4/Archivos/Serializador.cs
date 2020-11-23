
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;



namespace Archivos
{
    public class Serializador<T> : IArchivo<T>

    
    {
       

        /// <summary>
        /// Metodo implentado de la interfaz IArchivo
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a ser guardado</param>
        /// <returns>true si funciono false si no</returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));

                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    xml.Serialize(sw, datos);

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
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));

                using (TextReader tr = new StreamReader(archivo))
                {
                    datos = (T)xml.Deserialize(tr);

                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
      

    }



    






}
