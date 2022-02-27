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
    public class ColaboradorDAL
    {
        private static volatile ColaboradorDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private ColaboradorDAL() { }

        public static ColaboradorDAL Instance()
        {
            if (instance == null)//verificar si hay una instancia creada
                lock (padlock)
                    if (instance == null)
                        instance = new ColaboradorDAL();
            return instance;
        }

        public int Add(Colaborador colaborador)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[7];
                parameters[0] = new SqlParameter("@nombre", colaborador.nombre);
                parameters[1] = new SqlParameter("@apellido", colaborador.apellido);
                parameters[2] = new SqlParameter("@edad", colaborador.edad);
                parameters[3] = new SqlParameter("@direccion", colaborador.direccion);
                parameters[4] = new SqlParameter("@sueldo", colaborador.sueldo);
                parameters[5] = new SqlParameter("@idSucursal", colaborador.idSucursal);
                parameters[6] = new SqlParameter("@idArea", colaborador.idArea);
                
                string query = "stp_colaboradores_add";
                return dataAccess.Execute(query, parameters);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public int Delete(Colaborador colaborador)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idColaborador", colaborador.idColaborador);
                string query = "stp_colaboradores_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Colaboradores GetAll()
        {
            try
            {
                string query = "stp_colaboradores_getall";
                DataTable resultado = dataAccess.Query(query);
                Colaboradores colaboradores = new Colaboradores();
                foreach (DataRow item in resultado.Rows)
                {
                    colaboradores.Add(new Colaborador()
                    {
                        idColaborador = (int)item["idColaborador"],
                        nombre = (string)item["nombre"],
                        apellido = (string)item["apellido"],
                        edad = (int)item["edad"],
                        direccion = (string)item["direccion"],
                        sueldo = (decimal)item["sueldo"],
                        idSucursal = (int)item["idSucursal"],
                        idArea = (int)item["idArea"],
                        activo = (bool)item["activo"]
                    });
                }
                return colaboradores;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Colaborador GetByID(Colaborador colaborador)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idColaborador", colaborador.idColaborador);
                string query = "stp_colaboradores_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    colaborador = new Colaborador()
                    {
                        idColaborador = (int)resultado.Rows[0]["idAhorro"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        apellido = (string)resultado.Rows[0]["apellido"],
                        edad = (int)resultado.Rows[0]["edad"],
                        sueldo = (decimal)resultado.Rows[0]["sueldo"],
                        idSucursal = (int)resultado.Rows[0]["idSucursal"],
                        idArea = (int)resultado.Rows[0]["idArea"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };

                }
                return colaborador;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }


        public int Update(Colaborador colaborador)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@nombre", colaborador.nombre);
                parameters[1] = new SqlParameter("@apellido", colaborador.apellido);
                parameters[2] = new SqlParameter("@edad", colaborador.edad);
                parameters[3] = new SqlParameter("@direccion", colaborador.direccion);
                parameters[4] = new SqlParameter("@sueldo", colaborador.sueldo);
                parameters[5] = new SqlParameter("@idSucursal", colaborador.idSucursal);
                parameters[6] = new SqlParameter("@idArea", colaborador.idArea);

                string query = "stp_colaboradores_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }


    }
}
