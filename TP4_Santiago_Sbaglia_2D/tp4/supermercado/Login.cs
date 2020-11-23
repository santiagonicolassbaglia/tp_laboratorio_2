using Sbaglia_Santiago_1D_tp4;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercado
{

    public partial class registroUsuario : Form
    {

        public List<Cliente> clientes;
      


        public registroUsuario()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_alta_Click(object sender, EventArgs e)
        {
            clientes = new List<Cliente>();

            Alta_Cliente alta_Cliente = new Alta_Cliente();
            

            if (alta_Cliente.ShowDialog() == DialogResult.OK)
            {
                clientes.Add(alta_Cliente.MiCliente);

               
                MessageBox.Show(" Se Agregó correctamente ", " Alta de Cliente");
            }




        }



        private void btn_IngresarUsuario_Click(object sender, EventArgs e)
        {

            string user, pass;

            user = txt_usuario.Text;
            pass = txt_contraseña.Text;
            
            bool aux = false;

            comercio_compras wikieMart;
            if (!validaciones.ValidarString(user))
            {
                 Cliente Clientee = DB.validaUsuario(user,pass);
            if (!(Clientee is null))
            {
             //   DB clientes = new DB();
            

                    wikieMart = new comercio_compras(Clientee);
                    wikieMart.Show();
                    this.Hide();// cierra la otra venta del login
                    MessageBox.Show(user, $"Bienvenido a UTN TECNO!!!:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    aux = true;

                }



                if (!aux)
                {
                    MessageBox.Show("El usuario o la contraseña no son compatibles!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text=="USUARIO")
            {
                txt_usuario.Text = "";
                txt_usuario.ForeColor = Color.LightGray;           
            }
               


        }

       

        private void txt_usuario_Leave(object sender, EventArgs e)// cuando el mouse sale fuera del cursor del texto
        {
            if( txt_usuario.Text=="")
            {
                txt_usuario.Text = "USUARIO";
                txt_usuario.ForeColor = Color.DimGray;
            }
        }

      
    }

}

