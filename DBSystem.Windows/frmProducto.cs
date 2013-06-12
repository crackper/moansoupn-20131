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
    public partial class frmProducto : Form
    {
        IProductoBL productoBL;
        ICategoriaBL categoriaBL;

        public frmProducto()
        {
            InitializeComponent();

            if (productoBL == null)
            {
                productoBL = new ProductoBL();
            }

            if (categoriaBL == null)
            {
                categoriaBL = new CategoriaBL();
            }

            categoriaBindingSource.DataSource =
                categoriaBL.GetAllFromCategoria();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        public void UpdateProducto(Int32 id)
        {
            productoBindingSource.DataSource =
                productoBL.GetFromProductoById(id);
        }

        public void AddProducto()
        {
            productoBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = productoBindingSource.Current as Producto;

            productoBL.RegistrarProducto(producto);
        }
    }
}
