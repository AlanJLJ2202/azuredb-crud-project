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
    public class PrestamoDAL
    {
        private static volatile PrestamoDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private PrestamoDAL() { }

        public static PrestamoDAL Instance()
        {
            if (instance == null)//verificar si hay una instancia creada
                lock (padlock)
                    if (instance == null)
                        instance = new PrestamoDAL();
            return instance;
        }

        public int Add(Prestamo prestamo)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@idSocio", prestamo.idSocio);
                parameters[1] = new SqlParameter("@fecha", prestamo.fecha);
                parameters[2] = new SqlParameter("@monto", prestamo.monto);
                parameters[3] = new SqlParameter("@tasaInteres", prestamo.tasaInteres);
                string query = "stp_prestamos_add";
                return dataAccess.Execute(query, parameters);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public int Delete(Prestamo prestamo)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPrestamo", prestamo.idPrestamo);
                string query = "stp_prestamos_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Prestamos GetAll()
        {
            try
            {
                string query = "stp_prestamos_getall";
                DataTable resultado = dataAccess.Query(query);
                Prestamos prestamos = new Prestamos();
                foreach (DataRow item in resultado.Rows)
                {
                    prestamos.Add(new Prestamo()
                    {
                        idPrestamo = (int)item["idPrestamo"],
                        idSocio = (int)item["idSocio"],
                        fecha = (DateTime)item["fecha"],
                        monto = (decimal)item["monto"],
                        tasaInteres = (decimal)item["tasaInteres"],
                        activo = (bool)item["activo"]
                    });
                }
                return prestamos;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Prestamo GetByID(Prestamo prestamo)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPrestamo", prestamo.idPrestamo);
                string query = "stp_prestamos_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    prestamo = new Prestamo()
                    {
                        idPrestamo = (int)resultado.Rows[0]["idPrestamo"],
                        idSocio = (int)resultado.Rows[0]["idSocio"],
                        fecha = (DateTime)resultado.Rows[0]["fecha"],
                        monto = (decimal)resultado.Rows[0]["monto"],
                        tasaInteres = (decimal)resultado.Rows[0]["tasaInteres"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };

                }
                return prestamo;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }


        public int Update(Prestamo prestamo)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[5];

                parameters[0] = new SqlParameter("@idPrestamo", prestamo.idSocio);
                parameters[1] = new SqlParameter("@idSocio", prestamo.idSocio);
                parameters[2] = new SqlParameter("@fecha", prestamo.fecha);
                parameters[3] = new SqlParameter("@monto", prestamo.monto);
                parameters[4] = new SqlParameter("@tasaInteres", prestamo.tasaInteres);

                string query = "stp_prestamos_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }



    }
}
