using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public class PedidoDAO:ObjectFactory<PedidoDTO,PedidoDTO>,IPedidoDAO
    {
        IDetallePedidoDAO detalleDAO;

        public PedidoDAO()
        {
            if (detalleDAO == null)
            {
                detalleDAO = new DetallePedidoDAO();
            }
        }

        public List<PedidoDTO> GetFromPedidoByClienteAndFormaPagoIdDTO(string cliente, int idFormaPago)
        {
            var command = base.CreateComand("GetFromPedidoByClienteAndFormaPagoIdDTO");

            base.AddParameter(command, "criterio ", cliente);
            base.AddParameter(command, "formaPagoId", idFormaPago);

            return base.GetListDTO(command);
        }


        public PedidoDTO GetFromPedidoDTOById(int id)
        {
            var commandPedido = base.CreateComand("GetFromPedidoByIdDTO");
            base.AddParameter(commandPedido, "id", id);
            var pedido = base.GetDTO(commandPedido);

            pedido.DetallePedido 
                = detalleDAO.GetFromDetallePedidoByPedidoIdDTO(id);

            return pedido;

        }
    }
}
