using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public class FormaPagoDAO:ObjectFactory<FormaPago,FormaPago>,IFormaPagoDAO
    {
        public List<FormaPago> GetAllFromFormaPago()
        {
            var command = base.CreateComand("GetAllFromFormaPago");

            var lista = base.GetListEntity(command);

            lista.Insert(0,new FormaPago{Id=0,Descripcion="[ Todos ]"});

            return lista;
        }
    }
}
