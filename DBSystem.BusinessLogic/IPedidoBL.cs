using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.BusinessLogic
{
    public interface IPedidoBL
    {
        List<PedidoDTO> GetFromPedidoByClienteAndFormaPagoIdDTO(string cliente, Int32 idFormaPago);
        PedidoDTO GetFromPedidoDTOById(Int32 id);
    }
}
