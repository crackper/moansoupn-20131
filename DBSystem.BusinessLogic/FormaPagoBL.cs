using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;
using DBSystem.DataAccess;

namespace DBSystem.BusinessLogic
{
    public class FormaPagoBL:IFormaPagoBL
    {
        IFormaPagoDAO formaPagoDAO;

        public FormaPagoBL()
        {
            if (formaPagoDAO == null)
            {
                formaPagoDAO = new FormaPagoDAO();
            }

            
        }
        public List<FormaPago> GetAllFromFormaPago()
        {
            return formaPagoDAO.GetAllFromFormaPago();
        }
    }
}
