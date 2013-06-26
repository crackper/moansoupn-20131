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
        PedidoDTO GetFromPedidoDTOById(Int32 id);
        void RegistarPedido(PedidoDTO pedido);
        void RemovePedido(Int32 id);
        void QuitarDetalle(Int32 idDetalle);
    }
}
