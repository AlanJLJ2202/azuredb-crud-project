using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AhorroBLL
    {
        private static volatile AhorroBLL instance = null;
        private static readonly object padlock = new object();
        private AhorroDAL ahorroDAL = AhorroDAL.Instance();


        public static AhorroBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new AhorroBLL();
            return instance;
        }


        //Sigue metodo para
        //Agregar, Eliminar, Actualizar

        public bool Add(Ahorro ahorro)
        {
            if (ahorroDAL.Add(ahorro) > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Ahorro ahorro)
        {
            if (ahorroDAL.Delete(ahorro) > 0)
                return true;
            else
                return false;
        }

        public Ahorros GetAll()
        {
            return ahorroDAL.GetAll();
        }

        public Ahorro GetByID(Ahorro ahorro)
        {
            return ahorroDAL.GetByID(ahorro);
        }

        public bool Update(Ahorro ahorro)
        {
            if (ahorroDAL.Update(ahorro) > 0)
                return true;
            else
                return false;
        }
    }
}
