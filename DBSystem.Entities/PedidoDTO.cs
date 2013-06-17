using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//revisar namespace
namespace DBSystem.BusinessEntities
{
    public partial class PedidoDTO
    {
        public Int32 Id { get; set; }
        public Int32 ClienteId { get; set; }
        public string RucDni { get; set; }
        public string RazonSocial { get; set; }
        public string Dirección { get; set; }
        public Int32 FormaPagoId { get; set; }
        public string FormaPago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; } 
    }
}
