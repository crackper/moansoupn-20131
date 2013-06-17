using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBSystem.BusinessEntities;
using DBSystem.BusinessLogic;

namespace DBSystem.Windows
{
    public partial class frmListPedidos : Form
    {
        IFormaPagoBL formaPagoBL;
        IPedidoBL pedidoBL;

        public frmListPedidos()
        {
            InitializeComponent();

            if (formaPagoBL == null)
            {
                formaPagoBL = new FormaPagoBL();
            }

            if (pedidoBL == null)
            {
                pedidoBL = new PedidoBL();
            }
        }

        private void frmListPedidos_Load(object sender, EventArgs e)
        {
            formaPagoBindingSource.DataSource = formaPagoBL.GetAllFromFormaPago();

            LoadData();
        }

        private void LoadData()
        {
            var formaId = Int32.Parse(cbFormaPago.SelectedValue.ToString());
            var criterio = txtCriterio.Text == string.Empty ? "%" : txtCriterio.Text;

            pedidoDTOBindingSource.DataSource = pedidoBL.GetFromPedidoByClienteAndFormaPagoIdDTO(criterio, formaId);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
