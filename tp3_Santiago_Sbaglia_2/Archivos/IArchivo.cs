using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Archivos
{
    public interface IArchivo<T>
    {
        #region metodos
        
        /// METODO A SER IMPLEMENTADO POR AQUELLAS CLASES QUE HEREDEN ESTA INTERFAz
        bool Guardar(string archivo, T datos);

        /// METODO A SER IMPLEMENTADO POR AQUELLAS CLASES QUE HEREDEN ESTA INTERFAZ
        
        bool Leer(string archivo, out T datos);
        #endregion
    }
}
