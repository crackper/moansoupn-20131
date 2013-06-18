using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public class DetallePedidoDAO:
        ObjectFactory<DetallePedido,DetallePedido>,
        IDetallePedidoDAO
    {
        public List<DetallePedido> GetFromDetallePedidoByPedidoIdDTO(int idPedido)
        {
            var command = base.CreateComand("GetFromDetallePedidoByPedidoIdDTO");
            base.AddParameter(command, "pedidoId", idPedido);

            return base.GetListDTO(command);
        }
    }
}
