using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//revisar namespace
namespace DBSystem.BusinessEntities
{
    public partial class Pedido
    {

        public Int32 Id { get; set; }
        public Int32 ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public Int32 FormaPagoId { get; set; }

        public string  RucDniLabel { get; set; }

        private Cliente _cliente;

        public Cliente Cliente
        {
            get { return _cliente; }
            set 
            {  _cliente = value;
                //por cada cliente que asigno
                //tambien asigno el rucdnilabel
                RucDniLabel = _cliente.RucDni; 
            }
        }

        //public Cliente Cliente { get; set; }

        public FormaPago  FormaPago { get; set; }

        public List<DetallePedido> Detalle { get; set; }  
    }
}
