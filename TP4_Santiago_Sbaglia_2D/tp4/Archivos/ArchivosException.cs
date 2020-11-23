using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos

{
    public class ArchivosException : Exception
    {
        #region constructores

        public ArchivosException(Exception innerException) : base("Ocurrio un error trabajando con el archivo", innerException)
        {

        }
        #endregion
    }
}
