using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Sucursal
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idSucursal { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public bool activo { get; set; }

        public Sucursal() { }


        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@direccion", direccion);
            parameters.Add("@telefono", telefono);
            return dataAccess.Execute("stp_sucursales_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSucursal", idSucursal);
            return dataAccess.Execute("stp_sucursales_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSucursal", idSucursal);
            parameters.Add("@nombre", nombre);
            parameters.Add("@direccion", direccion);
            parameters.Add("@telefono", telefono);
            return dataAccess.Execute("stp_sucursales_update", parameters);
        }


        public IEnumerable<Sucursal> GetAll()
        {
            return dataAccess.Query<Sucursal>("stp_sucursales_getall");
        }


        public Sucursal GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSucursal", idSucursal);
            return dataAccess.QuerySingle<Sucursal>("stp_sucursales_getbyid", parameters);
        }

    }
}
