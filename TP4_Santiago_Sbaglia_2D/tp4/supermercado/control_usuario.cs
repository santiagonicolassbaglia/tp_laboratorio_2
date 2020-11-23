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
    public partial class control_usuario : Form
    {
        public control_usuario()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productosDBDataSet1);

        }

        private void salir_Click(object sender, EventArgs e)
        {
            comercio_compras salir = new comercio_compras(null);// vuelvo al menu anterior
            salir.Show();
            this.Hide();//se me cierra la ventana
        }
    }
}
