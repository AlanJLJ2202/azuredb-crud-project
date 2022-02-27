﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class AhorroDAL
    {
        private static volatile AhorroDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private AhorroDAL() { }

        public static AhorroDAL Instance()
        {
            if (instance == null)//verificar si hay una instancia creada
                lock (padlock)
                    if (instance == null)
                        instance = new AhorroDAL();
            return instance;
        }

        public int Add(Ahorro ahorro)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@idSocio", ahorro.idSocio);
                parameters[1] = new SqlParameter("@monto", ahorro.monto);
                parameters[2] = new SqlParameter("@tasaInteres", ahorro.tasaInteres);
                string query = "stp_ahorros_add";
                return dataAccess.Execute(query, parameters);
            }

            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public int Delete(Ahorro ahorro)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idAhorro", ahorro.idAhorro);
                string query = "stp_ahorros_delete";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Ahorros GetAll()
        {
            try
            {
                string query = "stp_ahorros_getall";
                DataTable resultado = dataAccess.Query(query);
                Ahorros ahorros = new Ahorros();
                foreach (DataRow item in resultado.Rows)
                {
                    ahorros.Add(new Ahorro()
                    {
                        idAhorro = (int)item["idAhorro"],
                        idSocio = (int)item["idSocio"],
                        monto = (decimal)item["monto"],
                        tasaInteres = (decimal)item["tasaInteres"],
                        activo = (bool)item["activo"]
                    });
                }
                return ahorros;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }

        public Ahorro GetByID(Ahorro ahorro)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idAhorro", ahorro.idAhorro);
                string query = "stp_ahorros_getbyid";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    ahorro = new Ahorro()
                    {
                        idAhorro = (int)resultado.Rows[0]["idAhorro"],
                        idSocio = (int)resultado.Rows[0]["idSocio"],
                        monto = (decimal)resultado.Rows[0]["monto"],
                        tasaInteres = (decimal)resultado.Rows[0]["tasaInteres"],
                        activo = (bool)resultado.Rows[0]["activo"]
                    };

                }
                return ahorro;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }


        public int Update(Ahorro ahorro)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@idAhorro", ahorro.idAhorro);
                parameters[1] = new SqlParameter("@idSocio", ahorro.idSocio);
                parameters[2] = new SqlParameter("@monto", ahorro.monto);
                parameters[3] = new SqlParameter("@tasaInteres", ahorro.tasaInteres);

                string query = "stp_ahorros_update";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error" + ex.Message);
            }
        }
    }
}