using Sbaglia_Santiago_1D_tp4;
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
    public partial class Alta_Cliente : Form
    {

        private Cliente miCliente;

        public Cliente MiCliente { get => miCliente; set => miCliente = value; }



        public Alta_Cliente()
        {
            InitializeComponent();
        }

    
        private void aceptar_alta_Click(object sender, EventArgs e)
        {
            int dni;
            if (int.TryParse(this.dnI_alta.Text, out dni ))
            {
                miCliente = new Cliente(this.nombre_alta.Text,
                     dni,
                    this.usuario_alta.Text,this.contraseña_alta.Text, this.apellido_alta.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        
    }
}
