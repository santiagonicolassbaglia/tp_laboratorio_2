using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sbaglia_Santiago_1D_tp4;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {




            try
            {              
                

                Producto prod1 = new Producto(1, "savalo", 209.99f, null);
          

                BaseDeDatos.InsertarProducto(prod1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();


            try
            {

                int numero = 55;

                bool par = numero.EsPar();

                Console.WriteLine("{0} es {1}", numero, par);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            try
            {
                double valor = 55.18;

            Console.WriteLine(valor.Dobletea());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }







            try
            {


                Cliente prod1 = new Cliente("rodrigo", 4080808, "rodrii", "1324","evez");


                BaseDeDatos.InsertarCliente(prod1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();











        }
    }
}
