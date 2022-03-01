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
    public class AreaDAL
    {
        private static volatile AreaDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private AreaDAL() { }

        public static AreaDAL Instance()
        {
            if (instance == null)//verificar si hay una instancia creada
                lock (padlock)
                    if (instance == null)
                        instance = new AreaDAL();
            return instance;
        }

        public int Add(Area area)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@nombre", area.nombre);
                parameters[1] = new SqlParameter("@descripcion", area.descripcion);
                string query = "stp_areas_add";
                return dataAccess.Execute(query, parameters);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public int Delete(Area area)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idArea", area.idArea);
                string query = "stp_areas_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Areas GetAll()
        {
            try
            {
                string query = "stp_areas_getall";
                DataTable resultado = dataAccess.Query(query);
                Areas areas = new Areas();
                foreach (DataRow item in resultado.Rows)
                {
                    areas.Add(new Area()
                    {
                        idArea = (int)item["idArea"],
                        nombre = (string)item["nombre"],
                        descripcion = (string)item["descripcion"],
                        activo = (bool)item["activo"]
                    });
                }
                return areas;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Area GetByID(Area area)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idArea", area.idArea);
                string query = "stp_areas_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    area = new Area()
                    {
                        idArea = (int)resultado.Rows[0]["idArea"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        descripcion = (string)resultado.Rows[0]["descripcion"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };

                }
                return area;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Area GetByDescripcion(Area area)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@nombre", area.nombre);
                string query = "stp_areas_getbydescripcion";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    area = new Area()
                    {
                        idArea = (int)resultado.Rows[0]["idArea"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        descripcion = (string)resultado.Rows[0]["descripcion"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return area;
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }



        public int Update(Area area)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@idArea", area.idArea);
                parameters[1] = new SqlParameter("@nombre", area.nombre);
                parameters[2] = new SqlParameter("@descripcion", area.descripcion);
                
                string query = "stp_areas_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

    }



}

