using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public class ClienteDAO:
        ObjectFactory<Cliente,Cliente>,
        IClienteDAO
    {
        public List<Cliente> GetFromClienteByCriterio(string criterio)
        {
            var command = base.CreateComand("GetFromClienteByRazonSocial");
            base.AddParameter(command, "razonSocial", criterio);
            return base.GetListEntity(command);
        }

        public Cliente GetFromClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente GetFromclienteByRucDni(string rucDNI)
        {
            var command = base.CreateComand("GetFromClienteByRucDni");
            base.AddParameter(command, "rucDni", rucDNI);
            return base.GetEntity(command);
        }

        public void RegistraCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
