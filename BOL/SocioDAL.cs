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
    public class SocioDAL
    {
        private static volatile SocioDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private SocioDAL() { }

        public static SocioDAL Instance()
        {
            if (instance == null)//verificar si hay una instancia creada
                lock (padlock)
                    if (instance == null)
                        instance = new SocioDAL();
            return instance;
        }

        public int Add(Socio socio)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@nombre", socio.nombre);
                parameters[1] = new SqlParameter("@apellido", socio.apellido);
                parameters[2] = new SqlParameter("@edad", socio.edad);
                parameters[3] = new SqlParameter("@direccion", socio.direccion);
                parameters[4] = new SqlParameter("@idSucursal", socio.idSucursal);
                


                string query = "stp_socios_add";
                return dataAccess.Execute(query, parameters);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public int Delete(Socio socio)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idSocio", socio.idSocio);
                string query = "stp_socios_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Socios GetAll()
        {
            try
            {
                string query = "stp_socios_getall";
                DataTable resultado = dataAccess.Query(query);
                Socios socios = new Socios();
                foreach (DataRow item in resultado.Rows)
                {
                    socios.Add(new Socio()
                    {
                        idSocio = (int)item["idSocio"],
                        nombre = (string)item["nombre"],
                        apellido = (string)item["apellido"],
                        edad = (int)item["edad"],
                        direccion = (string)item["direccion"],
                        idSucursal = (int)item["idSucursal"],
                        
                        activo = (bool)item["activo"]
                    });
                }
                return socios;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Socio GetByID(Socio socio)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idSocio", socio.idSocio);
                string query = "stp_socios_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    socio = new Socio()
                    {
                        idSocio = (int)resultado.Rows[0]["idSocio"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        apellido = (string)resultado.Rows[0]["apellido"],
                        edad = (int)resultado.Rows[0]["edad"],
                        direccion = (string)resultado.Rows[0]["direccion"],
                        idSucursal = (int)resultado.Rows[0]["idSucursal"],
                       
                        activo = (bool)resultado.Rows[0]["activo"]
                    };

                }
                return socio;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Socio GetByDescripcion(Socio socio)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@nombre", socio.nombre);
                string query = "stp_socios_getbydescripcion";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    socio = new Socio()
                    {
                        idSocio = (int)resultado.Rows[0]["idSocio"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        apellido = (string)resultado.Rows[0]["apellido"],
                        edad = (int)resultado.Rows[0]["edad"],
                        idSucursal = (int)resultado.Rows[0]["idSucursal"],
                       
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return socio;
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }


        public int Update(Socio socio)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[6];
                parameters[0] = new SqlParameter("@idSocio", socio.idSocio);
                parameters[1] = new SqlParameter("@nombre", socio.nombre);
                parameters[2] = new SqlParameter("@apellido", socio.apellido);
                parameters[3] = new SqlParameter("@edad", socio.edad);
                parameters[4] = new SqlParameter("@direccion", socio.direccion);
                parameters[5] = new SqlParameter("@idSucursal", socio.idSucursal);
                

                string query = "stp_socios_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }


    }
}
