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
    public partial class comercio_compras : Form
    {
        

        Cliente Cliente;

        public comercio_compras(Cliente Cliente)
        {
            InitializeComponent();
            this.Cliente = Cliente;
        }

        

        

        private void opcionCompra_Click(object sender, EventArgs e)
        {
            compras opcion4 = new compras(this.Cliente);
            opcion4.Show();
        }



        private void cerrarSesión_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRACIAS, POR LA COMPRA.!!  ", "UTN TECNO!  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            registroUsuario opcion5 = new registroUsuario();// vuelvo al menu anterior
            opcion5.Show();
            this.Hide();//se me cierra la ventana
        }

        private void salir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Esta seguro que desea salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (salir == DialogResult.No)
            {
                return;

            }
            else
            {

                MessageBox.Show("GRACIAS, POR LA COMPRA.!!  ", "UTN TECNO:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void opcionControl_Click(object sender, EventArgs e)
        {
            control_usuario opcionControl = new control_usuario();
            opcionControl.Show();

        }


      

        private void opcionControl_Click_1(object sender, EventArgs e)
        {
            control_usuario opcionControl = new control_usuario();
            opcionControl.Show();

        }

        private void VerEnTiempoReal_Click(object sender, EventArgs e)
        {
            Comercio1 comercio1 = new Comercio1();
            comercio1.Show();

         //   this.Hide();
        }
    }
}
