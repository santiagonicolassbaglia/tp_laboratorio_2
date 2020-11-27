using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();

            string[] operadores = { "+", "-", "/", "*" };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();  
        }
       

        private void RealizarCuenta_Click(object sender, EventArgs e)
        {
            double result;

            if ( this.operadores.Text =="" )
            {
                this.operadores.Text = "+";
            }

            result = Operar(this.txt_num1.Text, this.txt_num2.Text, this.operadores.SelectedItem.ToString());

            this.Resultado.Text = result.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que decea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }  //para que el usuario eliga si quiere seguir o no 
        }

        private void Binario_Click(object sender, EventArgs e)
        {
            string resultado = Resultado.Text;
            Numero num1 = new Numero();
            Resultado.Text = num1.DecimalBinario(resultado);
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            string resultado = Resultado.Text;
            Numero num1 = new Numero();
            Resultado.Text = num1.BinarioDecimal(resultado);
        }


        private void Limpiar()
        {
            txt_num1.ResetText();
            txt_num2.ResetText();
            operadores.ResetText();
      
            Resultado.Text = string.Empty;

            
           

        }





        private static double Operar(string numero1, string numero2, string operador)
        {
            
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }




    }
}
