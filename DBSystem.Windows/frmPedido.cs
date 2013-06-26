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
        IClienteBL clienteBL;
        IProductoBL productoBL;
        IFormaPagoBL formaPagoBL;

        public frmPedido()
        {
            InitializeComponent();

            if (pedidoBL == null)
	        {
		        pedidoBL = new PedidoBL();
	        }

            if (clienteBL == null)
            {
                clienteBL = new ClienteBL();
            }

            if (productoBL == null)
            {
                productoBL = new ProductoBL();
            }

            if (formaPagoBL ==  null)
            {
                formaPagoBL = new FormaPagoBL();
            }

            formaPagoBindingSource.DataSource = 
                formaPagoBL.GetAllFromFormaPago();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            LodProductos();

        }

        private void LodProductos()
        {
            var criterio = txtCriterio.Text == string.Empty ? "%" : txtCriterio.Text;

            productoDTOBindingSource.DataSource =
                productoBL.GetFromProductoByCriterioAndCategoriaIdDTO(criterio, 0);
        }

        public void UpdatePedido(Int32 id)
        {
            pedidoDTOBindingSource.DataSource =
                pedidoBL.GetFromPedidoDTOById(id);
        }

        private void rucDniTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var cliente = clienteBL.GetFromclienteByRucDni(rucDniTextBox.Text);

                if (cliente != null)
                {
                    var pedido = pedidoDTOBindingSource.Current as PedidoDTO;

                    pedido.ClienteId = cliente.Id;
                    pedido.RazonSocial = cliente.RazonSocial;
                    pedido.RucDni = cliente.RucDni;
                    pedido.Direccion = cliente.Direccion;

                    pedidoDTOBindingSource.ResetBindings(true);
   
                }
                else
                {
                    MessageBox.Show("El cliente no existe");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LodProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = productoDTOBindingSource.Current as ProductoDTO;

            if (producto !=null)
            {
                var pedido = pedidoDTOBindingSource.Current as PedidoDTO;

                var existe = pedido.DetallePedido
                                .Where(d => d.ProductoId.Equals(producto.Id))
                                .SingleOrDefault();

                if (existe == null)
                {
                    var detalle = new DetallePedido()
                    {
                        ProductoId = producto.Id,
                        Descripcion = producto.Descripcion,
                        Codigo = producto.Codigo,
                        Precio = producto.Precio,
                        Cantidad = 1
                    };

                    pedido.DetallePedido.Add(detalle);
                }
                else
                {
                    var msg = "El producto ya se encuentra en el pedido, incrementar cantidad en  +1 ";
                    var rpt = MessageBox.Show(this,msg ,
                              "Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (rpt == DialogResult.Yes)
                    {
                        existe.Cantidad++;
                    }
                }

                pedido.Total = pedido.DetallePedido.Sum(d => d.Monto);

                pedidoDTOBindingSource.ResetBindings(true);
                detallePedidoBindingSource.ResetBindings(true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var pedido = pedidoDTOBindingSource.Current as PedidoDTO;
        }
    }
}
