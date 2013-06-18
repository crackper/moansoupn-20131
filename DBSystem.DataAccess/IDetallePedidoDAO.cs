using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public interface IDetallePedidoDAO
    {
        List<DetallePedido> GetFromDetallePedidoByPedidoIdDTO(Int32 idPedido);
    }
}
