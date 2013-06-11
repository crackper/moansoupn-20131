using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DBSystem.DataAccess
{
    public class ObjectFactory<TDTO,TEntiy>:MasterDataAccess
        where TDTO:class
        where TEntiy:class
    {
        protected List<TDTO> GetListDTO(SqlCommand command)
        {
            var lista = new List<TDTO>();

            using (var reader = base.ExecuteReader(command))
            {
                if (reader.HasRows)
                {
                    AutoMapper.Mapper.CreateMap<IDataReader, TDTO>();
                    lista = AutoMapper.Mapper.Map<List<TDTO>>(reader);
                }
            }

            return lista;
        }

        protected TDTO GetDTO(SqlCommand command)
        {
            TDTO dto = null;

            var lista = this.GetListDTO(command);

            if (lista.Count > 0)
            {
                dto = lista.FirstOrDefault();
            }

            return dto;
        }

        protected List<TEntiy> GetListEntity(SqlCommand command)
        {
            var lista = new List<TEntiy>();

            using (var reader = base.ExecuteReader(command))
            {
                if (reader.HasRows)
                {
                    AutoMapper.Mapper.CreateMap<IDataReader, TEntiy>();
                    lista = AutoMapper.Mapper.Map<List<TEntiy>>(reader);
                }
            }

            return lista;
        }

        protected TEntiy GetEntity(SqlCommand command)
        {
            TEntiy entity = null;

            var lista = this.GetListEntity(command);

            if (lista.Count > 0)
            {
                entity = lista.FirstOrDefault();
            }

            return entity;
        }
    }
}
