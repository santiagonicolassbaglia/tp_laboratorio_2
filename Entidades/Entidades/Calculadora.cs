using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Calculadora 


    {

        private static string ValidarOperador(string operador)
        {
            string retorno = "+";

            if (operador == "-" || operador == "*" || operador == "/")
            {
                retorno = operador;
            }
            return retorno;
        }


        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string operadorValidado = ValidarOperador(operador);
            double resultado = 0;

            switch (operadorValidado)
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
