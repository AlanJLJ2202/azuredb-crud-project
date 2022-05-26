using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Prestamo
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idPrestamo { get; set; }
        public int idSocio { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto { get; set; }
        public decimal tasaInteres { get; set; }
        public bool activo { get; set; }

        public Prestamo() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSocio", idSocio);
            parameters.Add("@fecha", fecha);
            parameters.Add("@monto", monto);
            parameters.Add("@tasaInteres", tasaInteres);
            return dataAccess.Execute("stp_prestamos_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPrestamo", idPrestamo);
            return dataAccess.Execute("stp_prestamos_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPrestamo", idPrestamo);
            parameters.Add("@idSocio", idSocio);
            parameters.Add("@fecha", fecha);
            parameters.Add("@monto", monto);
            parameters.Add("@tasaInteres", tasaInteres);
            return dataAccess.Execute("stp_prestamos_update", parameters);
        }


        public IEnumerable<Prestamo> GetAll()
        {
            return dataAccess.Query<Prestamo>("stp_prestamos_getall");
        }


        public Prestamo GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idPrestamo", idPrestamo);

            return dataAccess.QuerySingle<Prestamo>("stp_prestamos_getbyid", parameters);
        }

        public IEnumerable <Prestamo> GetBySocio()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idSocio", idSocio);
            return dataAccess.Query<Prestamo>("stp_prestamos_getbysocio", parameters);
        }
    }
}
