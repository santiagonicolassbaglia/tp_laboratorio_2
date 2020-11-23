using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sbaglia_Santiago_1D_tp4;
using System.Threading;

namespace supermercado
{
    public partial class Comercio1 : Form
    {
       


        Comercio2 comercio2;

        List<Cliente> clientess;

        Thread t1;



        public Comercio1()
        {
            clientess = new List<Cliente>();
          this.clientess = BaseDeDatos.GetCliente();
            InitializeComponent();

           
            comercio2 = new Comercio2();
            comercio2.Show();


            t1 = new Thread(IniciarCiclo);
          
        }




        private void Comercio1_Load(object sender, EventArgs e)
        {
            ActualizarLista();
            t1.Start();

        }



        public void ActualizarLista()
        {
            if (this.listView1.InvokeRequired)
            {
                this.listView1.BeginInvoke((MethodInvoker)delegate ()
                {
                    List<string> clientsNameAndLastName = new List<string>();
                    this.listView1.Items.Clear();
                    foreach (Cliente item in clientess)
                    {
                        clientsNameAndLastName.Add(item.DatosCompletos());
                        listView1.Items.Add(item.DatosCompletos());
                        //listView1.Items.Add(item.ToString() + "\n");
                    }
                }
                );
            }
            else
            {
                List<string> clientsNameAndLastName = new List<string>();
                foreach (Cliente item in clientess)
                 {
                    
                    
                    clientsNameAndLastName.Add(item.DatosCompletos());
                    listView1.Items.Add(item.DatosCompletos());
                 }

              
               


            }

        }



        public void IniciarCiclo()
        {
            
          

           while (clientess.Count !=0)
            {
                

             comercio2.ActualizarDato(clientess[0]);
                Thread.Sleep(3000);

                clientess.Remove(clientess[0]);

                this.ActualizarLista();
            }

            if (clientess.Count == 0)
            {
                MessageBox.Show("Ya no quedan mas clientes", $"Lista de clientes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                { 
                this.Close();
                }

            }
        }










    }
}
