using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public interface IClienteDAO
    {
        List<Cliente> GetFromClienteByCriterio(string criterio);
        Cliente GetFromClienteById(Int32 id);
        Cliente GetFromclienteByRucDni(string rucDNI);
        void RegistraCliente(Cliente cliente);
        void EliminarCliente(Int32 id);
     }
}
