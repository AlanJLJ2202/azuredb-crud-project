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
    public class SucursalDAL
    {
        private static volatile SucursalDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private SucursalDAL() { }

        public static SucursalDAL Instance()
        {
            if (instance == null)//verificar si hay una instancia creada
                lock (padlock)
                    if (instance == null)
                        instance = new SucursalDAL();
            return instance;
        }

        public int Add(Sucursal sucursal)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@nombre", sucursal.nombre);
                parameters[1] = new SqlParameter("@direccion", sucursal.direccion);
                parameters[2] = new SqlParameter("@telefono", sucursal.telefono);
                string query = "stp_sucursales_add";
                return dataAccess.Execute(query, parameters);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public int Delete(Sucursal sucursal)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idSucursal", sucursal.idSucursal);
                string query = "stp_sucursales_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Sucursales GetAll()
        {
            try
            {
                string query = "stp_sucursales_getall";
                DataTable resultado = dataAccess.Query(query);
                Sucursales sucursales = new Sucursales();
                foreach (DataRow item in resultado.Rows)
                {
                    sucursales.Add(new Sucursal()
                    {
                        idSucursal = (int)item["idSucursal"],
                        nombre = (string)item["nombre"],
                        direccion = (string)item["direccion"],
                        telefono = (string)item["telefono"],
                        activo = (bool)item["activo"]
                    });
                }
                return sucursales;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Sucursal GetByID(Sucursal sucursal)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idSucursal", sucursal.idSucursal);
                string query = "stp_sucursales_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    sucursal = new Sucursal()
                    {
                        idSucursal = (int)resultado.Rows[0]["idSucursal"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        direccion = (string)resultado.Rows[0]["direccion"],
                        telefono = (string)resultado.Rows[0]["telefono"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };

                }
                return sucursal;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Sucursal GetByDescripcion(Sucursal sucursal)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@nombre", sucursal.nombre);
                string query = "stp_sucursales_getbydescripcion";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    sucursal = new Sucursal()
                    {
                        idSucursal = (int)resultado.Rows[0]["idSucursal"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        direccion = (string)resultado.Rows[0]["direccion"],
                        telefono = (string)resultado.Rows[0]["telefono"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };
                }
                return sucursal;
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }



        public int Update(Sucursal sucursal)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@idSucursal", sucursal.idSucursal);
                parameters[1] = new SqlParameter("@nombre", sucursal.nombre);
                parameters[2] = new SqlParameter("@direccion", sucursal.direccion);
                parameters[3] = new SqlParameter("@telefono", sucursal.telefono);

                string query = "stp_sucursales_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }




    }
}
