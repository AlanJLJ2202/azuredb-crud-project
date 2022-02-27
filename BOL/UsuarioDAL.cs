using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class UsuarioDAL
    {
        private static volatile UsuarioDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private UsuarioDAL() { }

        public static UsuarioDAL Instance()
        {
            if (instance == null)//verificar si hay una instancia creada
                lock (padlock)
                    if (instance == null)
                        instance = new UsuarioDAL();
            return instance;
        }

        public Usuario Login(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@nombre", usuario.nombre);
                parameters[1] = new SqlParameter("@password", usuario.password);
                string query = "stp_usuarios_login";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    Usuario ObjUsuario = new Usuario()
                    {
                        idUsuario = (int)resultado.Rows[0]["idUsuario"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        password = (string)resultado.Rows[0]["password"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                    return ObjUsuario;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }




        public int Add(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@nombre", usuario.nombre);
                parameters[1] = new SqlParameter("@password", usuario.password);
                string query = "stp_usuarios_add";
                return dataAccess.Execute(query, parameters);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public int Delete(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idUsuario", usuario.idUsuario);
                string query = "stp_usuarios_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Usuarios GetAll()
        {
            try
            {
                string query = "stp_usuarios_getall";
                DataTable resultado = dataAccess.Query(query);
                Usuarios usuarios = new Usuarios();
                foreach (DataRow item in resultado.Rows)
                {
                    usuarios.Add(new Usuario()
                    {
                        idUsuario = (int)item["idUsuario"],
                        nombre = (string)item["nombre"],
                        password = (string)item["password"],
                        activo = (bool)item["activo"]
                    });
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Usuario GetByID(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idUsuario", usuario.idUsuario);
                string query = "stp_usuarios_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    usuario = new Usuario()
                    {
                        idUsuario = (int)resultado.Rows[0]["idUsuario"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        password = (string)resultado.Rows[0]["password"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };

                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Usuario GetByDescripcion(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@nombre", usuario.nombre);
                string query = "stp_usuarios_getbydescripcion";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    usuario = new Usuario()
                    {
                        idUsuario = (int)resultado.Rows[0]["idUsuario"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        password = (string)resultado.Rows[0]["password"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return usuario;
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }



        public int Update(Usuario usuario)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@idUsuario", usuario.idUsuario);
                parameters[1] = new SqlParameter("@nombre", usuario.nombre);
                parameters[1] = new SqlParameter("@password", usuario.password);
                

                string query = "stp_usuarios_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

    }
}
