using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBSystem.Windows
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProductos frmProductos = new frmListProductos();
            frmProductos.MdiParent = this;
            frmProductos.Show();  
        }

        private void pedidosDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var  frmPedidos = new frmListPedidos();
            frmPedidos.MdiParent = this;
            frmPedidos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmListClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }
    }
}
