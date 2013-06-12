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

        private void brnEditar_Click(object sender, EventArgs e)
        {
            var productoDTO = productoDTOBindingSource.Current as ProductoDTO;

            if (productoDTO != null)
            {
                var frmProducto = new frmProducto();
                frmProducto.UpdateProducto(productoDTO.Id);
                frmProducto.ShowDialog();
            }

            
        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            var frmProducto = new frmProducto();
            frmProducto.AddProducto();
            frmProducto.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var productoDTO = productoDTOBindingSource.Current as ProductoDTO;

            if (productoDTO != null)
            {
                var rpt = MessageBox.Show(this,
                    "Desea eliminar el producto: " + productoDTO.Descripcion,
                    "Mensaje",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (rpt == DialogResult.Yes)
                {
                    productoBL.DeleteProducto(productoDTO.Id);
                    productoDTOBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
