using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sbaglia_Santiago_1D_tp4;
using Archivos;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
     
        public void NombreCliIdem()
        {
            
                string nombre = "santiago";
                Cliente testProd = new Cliente( nombre, 405045, "santi","1234","sbaglia");

                Assert.AreEqual(nombre, testProd.Nombre);

        }





        [TestMethod]
        public void CrearProd()
        {
            Producto testPelicula = new Producto(6, "ps5", 100000.99f,"pro");

            Assert.IsNotNull(testPelicula);

        }










    }



    


   


}
