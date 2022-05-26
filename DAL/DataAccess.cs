using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        #region Singleton

        private static volatile DataAccess instance = null;
        private static readonly object padlock = new object();
<<<<<<< HEAD
        public static string conString = "Server=proyectopacs.database.windows.net;Database=ProyectoPacsDB;User Id=adminPacs;Password=Admin12345";
=======
        // public static string conString = "Server=DESKTOP-21KVI4D;Database=Pacs1P;User Id=adminPacs;Password=Admin12345";
        public static string conString = "Server=proyectopacs.database.windows.net;Database=ProyectoPacsDB;User Id = adminPacs; Password=Admin12345";
>>>>>>> c7524d5726fe5e0e7e8e200a1c94f59fe5896d7e
        //public static string conString = "Data Source = DESKTOP-21KVI4D; Initial Catalog = Pacs1P; Integrated Security = true";
        public string InitialCatalog = "";
        public string DataSource = "";
        public string UserID = "";
        public string Password = "";
        private byte[] Clave = Encoding.ASCII.GetBytes("");
        private byte[] IV = Encoding.ASCII.GetBytes("DevJoker7.37hAES");

        private DataAccess()
        {

        }



        public static DataAccess Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
            instance = new DataAccess();
            return instance;

        }

        #endregion

        #region Query/Execute
        public T QuerySingle<T>(String query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public T QuerySingle<T>(String query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }


        //Este metodo sirve para el login 

        public T QuerySingleOrDefault<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingleOrDefault<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);

            }
        }

        //Metodo para obtener un valor especifico de una columna en especifico

        public string QueryString(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);

            }
        }

        //Para poder recibir parametros
        public string QueryString(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);

            }
        }


        public IEnumerable<T> Query<T>(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);

            }
        }

        public IEnumerable<T> Query<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);

            }
        }


        public int Execute(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Execute(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);

            }
        }

        public int Insert(string query, DynamicParameters parameters, string fieldName)
        {
            using (var con = new SqlConnection(conString))
            {
                return (int)((IDictionary<string, object>)con.QuerySingle(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300))[fieldName];

            }
        }
        #endregion


    }
}

