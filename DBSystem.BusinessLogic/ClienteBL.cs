using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;
using DBSystem.DataAccess;

namespace DBSystem.BusinessLogic
{
    public class ClienteBL:IClienteBL
    {
        IClienteDAO clienteDAO;

        public ClienteBL()
        {
            if (clienteDAO == null)
            {
                clienteDAO = new ClienteDAO();
            }
        }

        public List<Cliente> GetFromClienteByCriterio(string criterio)
        {
            return clienteDAO.GetFromClienteByCriterio(criterio);
        }

        public Cliente GetFromClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente GetFromclienteByRucDni(string rucDNI)
        {
            return clienteDAO.GetFromclienteByRucDni(rucDNI);
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
