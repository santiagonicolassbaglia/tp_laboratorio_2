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

namespace supermercado
{
    public partial class Comercio2 : Form
    {
        


        
        Comercio3 comercio3;
        public Comercio2()
        {
            comercio3 = new Comercio3();
            comercio3.Show();
            InitializeComponent();
        }

        public void ActualizarDato(Cliente dato)
        {

            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.BeginInvoke((MethodInvoker)delegate ()
                {
                    comercio3.ActualizarDato(this.richTextBox1.Text);

                    this.richTextBox1.Text = dato.DatosCompletos();
                }
                );
            }
            else
            {
                this.richTextBox1.Text = dato.DatosCompletos();
            }

        }







      
    }
}
