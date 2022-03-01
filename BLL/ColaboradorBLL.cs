using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ColaboradorBLL
    {
        private static volatile ColaboradorBLL instance = null;
        private static readonly object padlock = new object();
        private ColaboradorDAL colaboradorDAL = ColaboradorDAL.Instance();


        public static ColaboradorBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ColaboradorBLL();
            return instance;
        }


        //Sigue metodo para
        //Agregar, Eliminar, Actualizar

        public bool Add(Colaborador colaborador)
        {
            if (colaboradorDAL.Add(colaborador) > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Colaborador colaborador)
        {
            if (colaboradorDAL.Delete(colaborador) > 0)
                return true;
            else
                return false;
        }

        public Colaboradores GetAll()
        {
            return colaboradorDAL.GetAll();
        }

        public Colaborador GetByID(Colaborador colaborador)
        {
            return colaboradorDAL.GetByID(colaborador);
        }
        public bool Update(Colaborador colaborador)
        {
            if (colaboradorDAL.Update(colaborador) > 0)
                return true;
            else
                return false;
        }


    }
}
