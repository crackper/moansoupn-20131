using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DBSystem.BusinessEntities;

namespace DBSystem.DataAccess
{
    public class ProductoDAO: ObjectFactory<ProductoDTO,Producto>,IProductoDAO
    {

        public List<ProductoDTO> GetAllFromProductoDTO()
        {
            var query = "GetAllFromProductoDTO";
 
            var command = base.CreateComand(query);

            return base.GetListDTO(command);
        }

        public List<ProductoDTO> GetFromProductoByCriterioAndCategoriaIdDTO(string criterio, int categoriaId)
        {

            var query = "GetFromProductoByCriterioAndCategoriaIdDTO";

            var command = base.CreateComand(query);

           base.AddParameter(command, "descripcion", criterio);
           base.AddParameter(command,"categoriaId", categoriaId);

           return base.GetListDTO(command);

        }

        public void RegistrarProducto(Producto producto)
        {
            var query = "RegistrarProducto";

            var command = base.CreateComand(query);

            base.AddParameter(command, "id", producto.Id);
            base.AddParameter(command, "codigo", producto.Codigo);
            base.AddParameter(command, "categoriaId", producto.CategoriaId);
            base.AddParameter(command, "descripcion", producto.Descripcion);
            base.AddParameter(command, "precio", producto.Precio);
            base.AddParameter(command, "stock", producto.Stock);
            base.AddParameter(command, "descontinuado", producto.Descontinuado);

            base.ExecuteNonQuery(command);
        }

        public void DeleteProducto(int id)
        {
            var command = base.CreateComand("DeleteProducto");
            base.AddParameter(command, "id", id);
            base.ExecuteNonQuery(command);
        }


        public Producto GetFromProductoById(int id)
        {
            var query = "GetFromProductoById";

            var command = base.CreateComand(query);

            base.AddParameter(command, "id", id);

            return base.GetEntity(command);
        }
    }
}
