using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Area
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idArea { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }

        public Area() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_areas_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idArea", idArea);
            return dataAccess.Execute("stp_areas_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idArea", idArea);
            parameters.Add("@nombre", nombre);
            parameters.Add("@descripcion", descripcion);
            return dataAccess.Execute("stp_areas_update", parameters);
        }


        public IEnumerable<Area> GetAll()
        {
            return dataAccess.Query<Area>("stp_areas_getall");
        }


        public Area GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idArea", idArea);
            return dataAccess.QuerySingle<Area>("stp_areas_getbyid", parameters);
        }
    }
}
