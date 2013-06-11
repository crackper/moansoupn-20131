using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBSystem.BusinessEntities;
using DBSystem.DataAccess;

namespace DBSystem.BusinessLogic
{
    public class ProductoBL:IProductoBL
    {
        IProductoDAO productoDAO;

        public ProductoBL()
        {
            productoDAO = new ProductoDAO();
        }

        public List<ProductoDTO> GetAllFromProductoDTO()
        {
            return productoDAO.GetAllFromProductoDTO();  
        }

        public List<ProductoDTO> GetFromProductoByCriterioAndCategoriaIdDTO(string criterio, int categoriaId)
        {
            return productoDAO.GetFromProductoByCriterioAndCategoriaIdDTO(criterio,categoriaId); 
        }


        public void RegistrarProducto(Producto producto)
        {
            productoDAO.RegistrarProducto(producto);            
        }

        public void DeleteProducto(int id)
        {
            productoDAO.DeleteProducto(id);
        }


        public Producto GetFromProductoById(int id)
        {
            return productoDAO.GetFromProductoById(id);
        }
    }
}
