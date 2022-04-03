using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Socio
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idSocio { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }
        public string direccion { get; set; }

        public int idSucursal { get; set; }

        public bool activo { get; set; }

        public Socio() { }


        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            parameters.Add("@edad", edad);
            parameters.Add("@direccion", direccion);
            parameters.Add("@idSucursal", idSucursal);
            return dataAccess.Execute("stp_socios_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSocio", idSocio);
            return dataAccess.Execute("stp_socios_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSocio", idSocio);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            parameters.Add("@edad", edad);
            parameters.Add("@direccion", direccion);
            parameters.Add("@idSucursal", idSucursal);
            return dataAccess.Execute("stp_socios_update", parameters);
        }


        public IEnumerable<Socio> GetAll()
        {
            return dataAccess.Query<Socio>("stp_socios_getall");
        }


        public Socio GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSocio", idSocio);
            return dataAccess.QuerySingle<Socio>("stp_socios_getbyid", parameters);
        }
    }
}
