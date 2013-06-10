using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;
using DBSystem.DataAccess;

namespace DBSystem.BusinessLogic
{
    public class CategoriaBL:ICategoriaBL
    {
        ICategoriaDAO categoriaDAO;

        public CategoriaBL()
        {
            categoriaDAO = new CategoriaDAO(); 
        }

        public List<Categoria> GetAllFromCategoria()
        {
            return categoriaDAO.GetAllFromCategoria(); 
        }

        public Categoria GetFromCategoriaById(int id)
        {
            return categoriaDAO.GetFromCategoriaById(id); 
        }
    }
}
