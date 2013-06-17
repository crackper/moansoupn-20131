using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public interface IPedidoDAO
    {
        List<PedidoDTO> GetFromPedidoByClienteAndFormaPagoIdDTO(string cliente, Int32 idFormaPago);
    }
}
