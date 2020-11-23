using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercado
{
    public partial class Comercio3 : Form
    {
        public Comercio3()
        {
            InitializeComponent();
        }




        public void ActualizarDato(string dato)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.richTextBox2.Text += this.richTextBox1.Text;
                    this.richTextBox1.Text = dato;
                }
                );
            }
            else
            {
                this.richTextBox2.Text += this.richTextBox1.Text + "\n";
                this.richTextBox1.Text = dato;
            }

        }












    }
}
