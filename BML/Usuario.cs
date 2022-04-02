using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario
    {
        public DataAccess dataAccess = DataAccess.Instance();
        public int idUsuario { get; set; }

        public string nombre { get; set; }

        public string password { get; set; }

        public bool activo { get; set; }

        public Usuario() { }

        public int Add()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@password", password);
            return dataAccess.Execute("stp_usuarios_add", parameters);
        }

        public int Delete()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.Execute("stp_usuarios_delete", parameters);
        }

        public int Update()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            parameters.Add("@nombre", nombre);
            parameters.Add("@password", password);
            return dataAccess.Execute("stp_usuarios_update", parameters);
        }


        public IEnumerable<Usuario> GetAll()
        {
            return dataAccess.Query<Usuario>("stp_usuarios_getall");
        }


        public Usuario GetById()
        {
            var parameters = new DynamicParameters();
            parameters.Add("@idUsuario", idUsuario);
            return dataAccess.QuerySingle<Usuario>("stp_usuarios_getbyid", parameters);
        }

        public Usuario Login() 
        {
            var parameters = new DynamicParameters();
            parameters.Add("@nombre", nombre);
            parameters.Add("@password", password);
            return dataAccess.QuerySingle<Usuario>("stp_usuarios_login", parameters);
        }

    }
}
