using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBSystem.BusinessLogic;
using DBSystem.BusinessEntities;

namespace DBSystem.Windows
{
    public partial class frmPedido : Form
    {
        IPedidoBL pedidoBL;

        public frmPedido()
        {
            InitializeComponent();

            if (pedidoBL == null)
	        {
		        pedidoBL = new PedidoBL();
	        }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {

        }

        public void UpdatePedido(Int32 id)
        {
            pedidoDTOBindingSource.DataSource =
                pedidoBL.GetFromPedidoDTOById(id);
        }
    }
}
