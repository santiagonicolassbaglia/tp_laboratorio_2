using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Calculadora 


    {

        private static string ValidarOperador(char operador)
        {
            string retorno = "+";

            if (operador == '-' || operador == '*' || operador == '/'||operador == '+')
            {
                retorno = Convert.ToString(operador);
            }
            return retorno;
        }


        public static double Operar(Numero num1, Numero num2, string operador)
        {
            char aux;
            string auxOperador;
            double resultado = 0;

            aux = Convert.ToChar(operador);

            auxOperador = ValidarOperador(aux);

            switch (auxOperador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

    }
}
