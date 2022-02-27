using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        private static volatile UsuarioBLL instance = null;
        private static readonly object padlock = new object();
        private UsuarioDAL usuarioDAL = UsuarioDAL.Instance();


        private UsuarioBLL() { }

        public static UsuarioBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new UsuarioBLL();
            return instance;
        }


        //Sigue metodo para
        //Agregar, Eliminar, Actualizar


        public bool Login(Usuario usuario)
        {
            if (usuarioDAL.Login(usuario) != null)
                return true;
            else
                return false;
        }




        public bool Add(Usuario usuario)
        {
            if (usuarioDAL.Add(usuario) > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Usuario usuario)
        {
            if (usuarioDAL.Delete(usuario) > 0)
                return true;
            else
                return false;
        }

        public Usuarios GetAll()
        {
            return usuarioDAL.GetAll();
        }

        public Usuario GetByID(Usuario usuario)
        {
            return usuarioDAL.GetByID(usuario);
        }

        public bool Update(Usuario usuario)
        {
            if (usuarioDAL.Update(usuario) > 0)
                return true;
            else
                return false;
        }



    }
}
