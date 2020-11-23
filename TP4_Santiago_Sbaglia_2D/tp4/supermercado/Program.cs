using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using Sbaglia_Santiago_1D_tp4;

namespace supermercado
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm: new registroUsuario());

            
    //        //****** para archivos******
    //        try
    //        {

    //        string texto = " kwik e mart";
    //        string nombreArchivo = "Productos";
    //        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    //        FIle file = new FIle();
    //        file.EscribirArchivoTexto(ruta,nombreArchivo,texto, false);// si esta en face sobre escribe el texto anterior
    //                                                                    // si esta en true continua con el codigo anterior             
       
    //            /*    Console.WriteLine(file.LeerArchivoTexto(ruta, nombreArchivo));
    //        Console.ReadKey();*/ // poner cuando lo use
         
            
    //        }                                                        
    //         catch ( Exception ex)

    //        {
                
    //        }


    //        try
    //        {
    //            List<Cliente> clientes = new List<Cliente>();


    //            clientes.Add(new Cliente("santiago", 40009286, "ssanntii_96", "1234","sbaglia"));
    //            clientes.Add(new Cliente("Alan", 42009259, "Velascosss", "4087", "Velasco"));
    //            Serializador <List<Cliente>> serializador = new Serializador<List<Cliente>>();

    //            serializador.Serializar(clientes, "santi.xml");

    //            List<Cliente> clientes2 = new List<Cliente>();
    //            clientes2 = serializador.Deserializar("santi.xml");

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"ocurrio un error: { ex.ToString()}");
    //        }

    //      //  Console.ReadKey();




    //    
 }   
}

}
