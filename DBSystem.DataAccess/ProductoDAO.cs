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
    public class ProductoDAO: MasterDataAccess,IProductoDAO
    {

        public List<ProductoDTO> GetAllFromProductoDTO()
        {
            var query = "GetAllFromProductoDTO";
 
            var command = CreateComand(query);

            return SelectObjectFactory(command);
        }

        public List<ProductoDTO> GetFromProductoByCriterioAndCategoriaIdDTO(string criterio, int categoriaId)
        {

            var query = "GetFromProductoByCriterioAndCategoriaIdDTO";

            var command = base.CreateComand(query);

           base.AddParameter(command, "descripcion", criterio);
           base.AddParameter(command,"categoriaId", categoriaId);

           return SelectObjectFactory(command);

        }

       

        public void RegistrarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public void DeleteProducto(int id)
        {
            throw new NotImplementedException();
        }

        private List<ProductoDTO> SelectObjectFactory(SqlCommand command)
        {
            var lista = new List<ProductoDTO>();

            using (var reader = base.ExecuteReader(command))
            {

                if (reader.HasRows)
                {
                    AutoMapper.Mapper.CreateMap<IDataReader, ProductoDTO>();
                    lista = AutoMapper.Mapper.Map<IDataReader, List<ProductoDTO>>(reader);
                }
                /*while (reader.Read())
                {
                    var producto = new ProductoDTO()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Codigo = reader.GetString(reader.GetOrdinal("codigo")),
                        Categoria = reader.GetString(reader.GetOrdinal("categoria")),
                        Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                        Precio = reader.GetDecimal(reader.GetOrdinal("precio")),
                        Stock = reader.GetDecimal(reader.GetOrdinal("stock")),
                        Descontinuado = reader.GetBoolean(reader.GetOrdinal("descontinuado"))
                    };

                    lista.Add(producto);
                }*/

            }
            return lista;
        }


        
    }
}
