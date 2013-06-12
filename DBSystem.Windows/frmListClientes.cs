using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBSystem.BusinessLogic;

namespace DBSystem.Windows
{
    public partial class frmListClientes : Form
    {
        IClienteBL clienteBL;

        public frmListClientes()
        {
            InitializeComponent();

            if (clienteBL == null)
            {
                clienteBL = new ClienteBL();
            }
        }

        private void frmListClientes_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = clienteBL.GetFromClienteByCriterio("%");
        }
    }
}
