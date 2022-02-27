using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AreaBLL
    {
        private static volatile AreaBLL instance = null;
        private static readonly object padlock = new object();
        private AreaDAL areaDAL = AreaDAL.Instance();


        public static AreaBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new AreaBLL();
            return instance;
        }


        //Sigue metodo para
        //Agregar, Eliminar, Actualizar

        public bool Add(Area area)
        {
            if (areaDAL.Add(area) > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Area area)
        {
            if (areaDAL.Delete(area) > 0)
                return true;
            else
                return false;
        }

        public Areas GetAll()
        {
            return areaDAL.GetAll();
        }

        public Area GetByID(Area area)
        {
            return areaDAL.GetByID(area);
        }

        public Area GetByDescripcion(Area area)
        {
            return areaDAL.GetByDescripcion(area);
        }

        public bool Update(Area area)
        {
            if (areaDAL.Update(area) > 0)
                return true;
            else
                return false;
        }
    }
}
