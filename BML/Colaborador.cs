using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Colaborador
    {
        private DataAccess dataAccess = DataAccess.Instance();

        public int idColaborador { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public decimal sueldo { get; set; }
        public int idArea { get; set; }
        public int idSucursal { get; set; }
        public bool activo { get; set; }

        public Colaborador() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            parameters.Add("@edad", edad);
            parameters.Add("@direccion", direccion);
            parameters.Add("@sueldo", sueldo);
            parameters.Add("@idArea", idArea);
            parameters.Add("@idSucursal", idSucursal);
            return dataAccess.Execute("stp_colaboradores_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idColaborador", idColaborador);
            return dataAccess.Execute("stp_colaboradores_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idColaborador", idColaborador);
            parameters.Add("@nombre", nombre);
            parameters.Add("@apellido", apellido);
            parameters.Add("@edad", edad);
            parameters.Add("@direccion", direccion);
            parameters.Add("@sueldo", sueldo);
            parameters.Add("@idArea", idArea);
            parameters.Add("@idSucursal", idSucursal);
            return dataAccess.Execute("stp_colaboradores_update", parameters);
        }


        public IEnumerable<Colaborador> GetAll()
        {
            return dataAccess.Query<Colaborador>("stp_colaboradores_getall");
        }


        public Colaborador GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idColaborador", idColaborador);
            return dataAccess.QuerySingle<Colaborador>("stp_colaboradores_getbyid", parameters);
        }
    }
}
