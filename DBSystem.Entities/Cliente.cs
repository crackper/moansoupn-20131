using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//revisar namespace
namespace DBSystem.BusinessEntities
{
    public partial class Cliente
    {
        public Int32 Id { get; set; }
        public string RucDni { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        //sobreescribir la propiedad tostring
        public override string ToString()
        {
            //devuelvo el valor por defecto
            return RazonSocial; 
        }

    }
}
