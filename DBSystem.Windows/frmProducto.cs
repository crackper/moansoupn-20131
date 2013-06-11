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

        public frmProducto()
        {
            InitializeComponent();

            if (productoBL == null)
            {
                productoBL = new ProductoBL();
            }
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {

        }

        public void UpdateProducto(Int32 id)
        {
            productoBindingSource.DataSource =
                productoBL.GetFromProductoById(id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var producto = productoBindingSource.DataSource as Producto;

            productoBL.RegistrarProducto(producto);
        }
    }
}
