using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public class PedidoDAO:ObjectFactory<PedidoDTO,PedidoDTO>,IPedidoDAO
    {
        public List<PedidoDTO> GetFromPedidoByClienteAndFormaPagoIdDTO(string cliente, int idFormaPago)
        {
            var command = base.CreateComand("GetFromPedidoByClienteAndFormaPagoIdDTO");

            base.AddParameter(command, "criterio ", cliente);
            base.AddParameter(command, "formaPagoId", idFormaPago);

            return base.GetListDTO(command);
        }
    }
}
