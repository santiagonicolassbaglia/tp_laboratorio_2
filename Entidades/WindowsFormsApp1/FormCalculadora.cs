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

        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void txt_num2_TextChanged(object sender, EventArgs e)
        {

        }


        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void operadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RealizarCuenta_Click(object sender, EventArgs e)
        {
            string numero1Str = txt_num1.Text;
            string numero2Str = txt_num2.Text;
            string operador = operadores.Text;

            Numero n1 = new Numero(numero1Str);
            Numero n2 = new Numero(numero2Str);

            
           if( string.IsNullOrWhiteSpace(numero1Str))
            {
                MessageBox.Show("Debe ingresar un numero", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                // para que salga el cartel de alerta           

            /*    DialogResult result = MessageBox.Show("¿Desea continuar?", "ALERTA", MessageBoxButtons.YesNoCancel);

                if ( result== DialogResult.No)
                {
                    this.Close;
                }  para que el usuario eliga si quiere seguir o no */ 
            }



            double resultado = Calculadora.Operar(n1, n2, operador);
            
            
            
            if (operador == "")
            {
               operadores.Text = "+";
            }
            Resultado.Text = resultado.ToString();

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            operadores.Text = "";
            Resultado.Text = string.Empty;

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
