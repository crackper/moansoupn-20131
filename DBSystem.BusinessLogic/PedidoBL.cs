using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;
using DBSystem.DataAccess;

namespace DBSystem.BusinessLogic
{
    public class PedidoBL:IPedidoBL
    {
        IPedidoDAO pedidoDAO;

        public PedidoBL() 
        {
            if (pedidoDAO == null)
            {
                pedidoDAO = new PedidoDAO();
            }
        } 

        public List<PedidoDTO> GetFromPedidoByClienteAndFormaPagoIdDTO(string cliente, int idFormaPago)
        {
            return pedidoDAO.GetFromPedidoByClienteAndFormaPagoIdDTO(cliente, idFormaPago);
        }
    }
}
