using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using Sbaglia_Santiago_1D_tp4;

namespace supermercado
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Producto> auxProd = new List<Producto>();

            string NombreArchivo = " Santiago Sbaglia Ticket";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string producto = txt_tikprod.Text;
             string monto =txt_tikMon.Text ;
           DateTime localDate = DateTime.Now;

            string texto = "--------Nuevo Ticket---------\n\n\n" +
                      "-------------TICKET----------------\n " +
                          "************** PRODUCTO:" + producto + "****************\n" +
                          "\n************** MONTO: " + monto +
                          "\n************** HORA: " + localDate.ToString();



            Guardar(texto);
           

            FIle<string>.EscribirArchivoTexto(ruta, NombreArchivo, texto, true);
            this.Hide();// cierra la otra venta del login
            MessageBox.Show( $"El ticket fue creado con exito, y se encuentra en el escritorio !:","Ticket", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        public static bool Guardar(string tex)
        {
            Serializador<string> xml = new Serializador<string>();
            string archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + ".\\Ticket.xml";
            if (xml.Guardar(archivo, tex))
            {
                return true;
            }
            return false;
        }

    }
}
