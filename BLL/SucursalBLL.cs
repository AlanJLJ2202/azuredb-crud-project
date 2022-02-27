using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SucursalBLL
    {
        private static volatile SucursalBLL instance = null;
        private static readonly object padlock = new object();
        private SucursalDAL sucursalDAL = SucursalDAL.Instance();


        public static SucursalBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new SucursalBLL();
            return instance;
        }


        //Sigue metodo para
        //Agregar, Eliminar, Actualizar

        public bool Add(Sucursal sucursal)
        {
            if (sucursalDAL.Add(sucursal) > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Sucursal sucursal)
        {
            if (sucursalDAL.Delete(sucursal) > 0)
                return true;
            else
                return false;
        }

        public Sucursales GetAll()
        {
            return sucursalDAL.GetAll();
        }

        public Sucursal GetByID(Sucursal sucursal)
        {
            return sucursalDAL.GetByID(sucursal);
        }

        public Sucursal GetByDescripcion(Sucursal sucursal)
        {
            return sucursalDAL.GetByDescripcion(sucursal);
        }

        public bool Update(Sucursal sucursal)
        {
            if (sucursalDAL.Update(sucursal) > 0)
                return true;
            else
                return false;
        }

    }
}
