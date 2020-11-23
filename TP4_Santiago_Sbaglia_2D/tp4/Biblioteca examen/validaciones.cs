using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbaglia_Santiago_1D_tp4
{
    public class validaciones
    {





        public static int ValidarEntero(int opcionMin, int opcionMax)
        {
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < opcionMin || opcion > opcionMax)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre {0} y {1}", opcionMin, opcionMax);
            }
            Console.ResetColor();

            return opcion;

        }

        public static string ValidarSoN(string auxDatoIngresado)
        {
            while (string.IsNullOrEmpty(auxDatoIngresado) || (auxDatoIngresado.ToLower().Trim() != "a" && auxDatoIngresado.ToLower().Trim() != "p"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre A o P");
                auxDatoIngresado = Console.ReadLine();
            }
            Console.ResetColor();

            return auxDatoIngresado;

        }






        /// <summary>
        /// Verifica si el numero ingresado es menor o igual a 0
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns>true si es menor a 0, false si no lo es</returns>
        public static bool CerosYnegativos(double auxNumero)
        {
            if (auxNumero <= 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica si el elemento ingresado es un string null, vacio o menor a 2 caracteres
        /// </summary>
        /// <param name="auxString"></param>
        /// <returns>true si cumple los requisitos, false si no los cumple</returns>
        public static bool ValidarString(string auxString)
        {
            if (String.IsNullOrEmpty(auxString) || auxString.Length < 2)
            {
                return true;

            }
            else
            {
                return false;
            }
        }





        public class Validaciones
        {

            /// <summary>
            /// Verifica si el numero ingresado es menor o igual a 0
            /// </summary>
            /// <param name="auxNumero"></param>
            /// <returns>true si es menor a 0, false si no lo es</returns>
            public static bool CerosYnegativos(double auxNumero)
            {
                if (auxNumero <= 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }







        }


    }
}