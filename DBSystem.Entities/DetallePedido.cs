using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//revisar namespace
namespace DBSystem.BusinessEntities
{
    public partial class DetallePedido
    {
        public Int32 Item { get; set; }
        public Int32 PedidoId { get; set; }
        public Int32 ProductoId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
