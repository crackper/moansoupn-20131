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
    public partial class frmListProductos : Form
    {
        IProductoBL productoBL;

        public frmListProductos()
        {
            InitializeComponent();

            productoBL = new ProductoBL();
        }

        private void frmListProductos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var criterio = txtCriterio.Text == string.Empty ? "%" : txtCriterio.Text;
            var categoriaId = 0;

            productoDTOBindingSource.DataSource = productoBL.GetFromProductoByCriterioAndCategoriaIdDTO(criterio, categoriaId);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
