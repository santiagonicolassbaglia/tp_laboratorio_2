using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region constructores
        /// <summary>
        /// Constructor sin parametros inicializa la cola y llama al metodo _randomclases
        /// </summary>
        public Profesor()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        /// <summary>
        /// constructor statico inicializa el atributo random estatitco
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor con varios parametros los mismos seran pasados a la clase de la que hereda
        /// </summary>
        /// <param name="id">campo a ser pasado por herencia</param>
        /// <param name="nombre">campo a ser pasado por herencia</param>
        /// <param name="apellido">campo a ser pasado por herencia</param>
        /// <param name="dni">campo a ser pasado por herencia</param>
        /// <param name="nacionalidad">campo a ser pasado por herencia</param>
        public Profesor(int id, string nombre, string apellido, string dni, Persona.ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        #endregion

        #region metodos

        /// <summary>
        /// asignarán dos clases al azar al Profesor mediante el método randomClases.
        /// </summary>
        private void _randomClases()//ANDA
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(Enum.GetNames(typeof(Universidad.EClases)).Length));
        }

        
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da
        /// </summary>
        /// <returns>string con los datos</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA:");

            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

       
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region sobrecarga de operadores


        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion

    }
}
