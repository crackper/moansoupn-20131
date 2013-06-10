using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public interface IProductoDAO
    {
        List<ProductoDTO> GetAllFromProductoDTO();
        List<ProductoDTO> GetFromProductoByCriterioAndCategoriaIdDTO(string criterio, Int32 categoriaId);
        
        void RegistrarProducto(Producto producto);
        void DeleteProducto(Int32 id);
    }
}
