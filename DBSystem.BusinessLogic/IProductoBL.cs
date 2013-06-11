using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.BusinessLogic
{
    public interface IProductoBL
    {
        List<ProductoDTO> GetAllFromProductoDTO();
        List<ProductoDTO> GetFromProductoByCriterioAndCategoriaIdDTO(string criterio, Int32 categoriaId);
        void RegistrarProducto(Producto producto);
        void DeleteProducto(int id);
        Producto GetFromProductoById(Int32 id);
    }
}
