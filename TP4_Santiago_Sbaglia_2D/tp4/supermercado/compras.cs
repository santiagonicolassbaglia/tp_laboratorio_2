using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using supermercado;

namespace Sbaglia_Santiago_1D_tp4
{
    public partial class compras : Form
    {
        public List<Cliente> MiClientess;



        public compras(Cliente Cliente)
        {
            InitializeComponent();



        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productosDBDataSet1);

        }

        private void compras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productosDBDataSet1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.productosDBDataSet1.Productos);

        }

       

        private void btn_GenerarTicket_Click(object sender, EventArgs e)
        {
          
            Ticket ticket = new Ticket();
            ticket.Show();

        }
    }

}








