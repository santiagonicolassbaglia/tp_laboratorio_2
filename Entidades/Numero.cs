using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Numero
    {

        double numero;

        

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(float numero)
        {
            this.numero = numero;
        }

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public Numero()
        {
            this.numero = 0;
        }


        public Numero(string strNumero)
        {
            double num = 0;
            bool flag = double.TryParse(strNumero, out num);
            if (flag == true)
            {
                this.numero = num;
            }
        }


        private double ValidarNumero(string strNumero)
        {
            double retorno;
            bool resultadoParseo = double.TryParse(strNumero, out retorno);
            if (resultadoParseo == false)
            {
                retorno = 0;
            }
            return retorno;
        }


       private string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }









        //SOBRECARGAS




        /// <summary>
        /// es la sobrecarga del operador + para poder realizar la suma de dos numeros
        /// </summary>
        /// <param name="n1">numero 1 para realizar la operacion</param>
        /// <param name="n2">numero 2 para realizar la operacion</param>
        /// <returns>te devuelve la operacion ya realizada</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero; ;
        }

        /// <summary>
        /// es la sobrecarga del operador - para poder realizar la resta de dos numeros
        /// </summary>
        /// <param name="n1">numero 1 para realizar la operacion</param>
        /// <param name="n2">numero 2 para realizar la operacion</param>
        /// <returns>te devuelve la operacion ya realizada</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero; ;
        }

        /// <summary>
        /// es la sobrecarga del operador * para poder realizar la multiplicacion de dos numeros
        /// </summary>
        /// <param name="n1">numero 1 para realizar la operacion</param>
        /// <param name="n2">numero 2 para realizar la operacion</param>
        /// <returns>te devuelve la operacion ya realizada</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero; ;
        }

        /// <summary>
        /// es la sobrecarga del operador / para poder realizar la division de dos numeros
        /// </summary>
        /// <param name="n1">numero 1 para realizar la operacion</param>
        /// <param name="n2">numero 2 para realizar la operacion valida que no sea 0 </param>
        /// <returns>te devuelve la operacion ya realizada</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = 0;
            if (n2.numero == 0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = n1.numero / n2.numero;
            }
            return retorno;
        }











        public string BinarioDecimal(string binario)
        {
            char[] array = binario.ToCharArray();
            Array.Reverse(array);
            string retorno = "Valor inválido";
            double resultado = 0;
            bool bandera = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    resultado += Math.Pow(2, i);
                    bandera = true;
                }

            }
            if (bandera == true)
            {
                retorno = resultado.ToString();
            }


            return retorno;
        }


        //DECIMAL A BINARIO (SON 2)


        /// <summary>
        /// transforma un numero decimal a binario
        /// </summary>
        /// <param name="numero">numero a ser transformado</param>
        /// <returns>te devuelve ya el numero en binario o un "Valor Invalido"</returns>
        public string DecimalBinario(string numero)
        {
            double numeroRestante;
            bool eraNumero = double.TryParse(numero, out numeroRestante);
            string binario = "Valor inválido";


            if (eraNumero == true)
            {
                double resto = 0;
                binario = "";

                while (numeroRestante >= 1)
                {
                    resto = numeroRestante % 2;
                    numeroRestante = (int)numeroRestante / 2;
                    binario = resto.ToString() + binario;
                }
            }

            return binario;
        }

        /// <summary>
        /// transforma un numero decimal a binario
        /// </summary>
        /// <param name="numero">numero a ser transformado, este metodo es una sobrecarga y reutiliza el anterior</param>
        /// <returns>te devuelve ya el numero en binario o un "Valor Invalido"</returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }







    }










}

