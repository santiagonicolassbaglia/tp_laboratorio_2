using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Producto prod1 = new Producto(1, "savalo", 209.99f, null);
                ProductosDao productosDao = new ProductosDao();

                productosDao.InsertarProducto(prod1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();







        }
    }
}
