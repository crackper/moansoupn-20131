using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public interface ICategoriaDAO
    {
        List<Categoria> GetAllFromCategoria();
        Categoria GetFromCategoriaById(Int32 id);
        void RegistrarCategoria(Categoria categoria);
    }
}
