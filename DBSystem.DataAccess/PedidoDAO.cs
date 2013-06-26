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

        public void RegistarPedido(PedidoDTO pedido)
        {
            var command = base.CreateComand("RegistrarPedido");

           // base.AddParameter(command, "id", pedido.Id);

            var paramId = command.CreateParameter();
            paramId.DbType = System.Data.DbType.Int32;
            paramId.Direction = System.Data.ParameterDirection.InputOutput;
            paramId.Value = pedido.Id;

            command.Parameters.Add(paramId);

            base.AddParameter(command, "clienteId", pedido.ClienteId);
            base.AddParameter(command, "fecha", pedido.Fecha);
            base.AddParameter(command, "total", pedido.Total);

            base.ExecuteNonQuery(command);

            pedido.Id = Int32.Parse(paramId.Value.ToString());

            var commandDetalle = base.CreateComand("RegistrarDetallePedido");

            foreach (var detalle in pedido.DetallePedido)
            {
                base.AddParameter(commandDetalle, "item", detalle.Item);
                base.AddParameter(commandDetalle, "pedidoId", pedido.Id);
                base.AddParameter(commandDetalle, "productoId", detalle.ProductoId);
                base.AddParameter(commandDetalle, "cantidad", detalle.Cantidad);
                base.AddParameter(commandDetalle, "precio", detalle.Precio);

                base.ExecuteNonQuery(commandDetalle);
            }

        }

        public void RemovePedido(int id)
        {
            throw new NotImplementedException();
        }

        public void QuitarDetalle(int idDetalle)
        {
            throw new NotImplementedException();
        }
    }
}
