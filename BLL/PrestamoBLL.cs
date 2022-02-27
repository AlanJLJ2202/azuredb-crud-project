using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PrestamoBLL
    {
        private static volatile PrestamoBLL instance = null;
        private static readonly object padlock = new object();
        private PrestamoDAL prestamoDAL = PrestamoDAL.Instance();


        public static PrestamoBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new PrestamoBLL();
            return instance;
        }


        //Sigue metodo para
        //Agregar, Eliminar, Actualizar

        public bool Add(Prestamo prestamo)
        {
            if (prestamoDAL.Add(prestamo) > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Prestamo prestamo)
        {
            if (prestamoDAL.Delete(prestamo) > 0)
                return true;
            else
                return false;
        }

        public Prestamos GetAll()
        {
            return prestamoDAL.GetAll();
        }

        public Prestamo GetByID(Prestamo prestamo)
        {
            return prestamoDAL.GetByID(prestamo);
        }

        public bool Update(Prestamo prestamo)
        {
            if (prestamoDAL.Update(prestamo) > 0)
                return true;
            else
                return false;
        }



    }
}
