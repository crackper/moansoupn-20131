using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.BusinessLogic
{
    public interface ICategoriaBL
    {
        List<Categoria> GetAllFromCategoria();
        Categoria GetFromCategoriaById(Int32 id);
    }
}
