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
    public class CategoriaDAO:ICategoriaDAO
    {
        SqlConnection cnx;

        public CategoriaDAO()
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=(local);Initial Catalog=DBSystem;Integrated Security=True";//ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;
        }

        public List<Categoria> GetAllFromCategoria()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "GetAllFromCategoria";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = cnx;

            var lista = SlectObjectFactory(command);

            lista.Insert(0, new Categoria() {Id = 0,Descripcion = "[ Ver Todas ]" });  

            return lista ; 
        }

        public Categoria GetFromCategoriaById(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "GetFromCategoriaById";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = cnx;

            command.Parameters.AddWithValue("id", id);

            return SlectObjectFactory(command).SingleOrDefault();   
        }

        private List<Categoria> SlectObjectFactory(SqlCommand command)
        {
            List<Categoria> lista = new List<Categoria>();

            cnx.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Categoria categoria = new Categoria()
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Descripcion = reader.GetString(reader.GetOrdinal("descripcion")),
                        Comentario = reader.GetString(reader.GetOrdinal("comentario"))
                    };

                    lista.Add(categoria);
                }
            }
            cnx.Close();
            return lista;
        }




        public void RegistrarCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
