using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.BusinessLogic
{
    public interface IFormaPagoBL
    {
        List<FormaPago> GetAllFromFormaPago();
    }
}
