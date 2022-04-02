using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Ahorro
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idAhorro { get; set; }
        public int idSocio { get; set; }
        public decimal monto { get; set; }
        public decimal tasaInteres { get; set; }
        public bool activo { get; set; }

        public Ahorro() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSocio", idSocio);
            parameters.Add("@monto", monto);
            parameters.Add("@tasaInteres", tasaInteres);
            return dataAccess.Execute("stp_ahorros_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idAhorro", idAhorro);
            return dataAccess.Execute("stp_ahorros_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idAhorro", idAhorro);
            parameters.Add("@idSocio", idSocio);
            parameters.Add("@monto", monto);
            parameters.Add("@tasaInteres", tasaInteres);
            return dataAccess.Execute("stp_ahorros_update", parameters);
        }


        public IEnumerable<Ahorro> GetAll()
        {
            return dataAccess.Query<Ahorro>("stp_ahorros_getall");
        }


        public Ahorro GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idAhorro", idAhorro);
            return dataAccess.QuerySingle<Ahorro>("stp_ahorros_getbyid", parameters);
        }
    }
}
