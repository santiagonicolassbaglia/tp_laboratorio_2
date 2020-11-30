using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
      public  enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        EMarca marca;
        string chasis;
        ConsoleColor color;




        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }




        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>

        public abstract ETamanio Tamanio { get; }

     

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
    

            sb.AppendLine($"CHASIS\n: {this.chasis}");
            sb.AppendLine($"MARCA\n: {this.marca}");
            sb.AppendLine($"COLOR\n: {this.color}");
            sb.AppendLine("---------------------");


            return sb.ToString();
        }




        public static explicit operator string(Vehiculo p)
        {
            return p.Mostrar();

        }





        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool identicos = false;
           if(v1.chasis == v2.chasis)
            {
                identicos = true;
            }
            return identicos;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }
}
