﻿using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SocioBLL
    {
        private static volatile SocioBLL instance = null;
        private static readonly object padlock = new object();
        private SocioDAL socioDAL = SocioDAL.Instance();


        public static SocioBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new SocioBLL();
            return instance;
        }


        //Sigue metodo para
        //Agregar, Eliminar, Actualizar

        public bool Add(Socio socio)
        {
            if (socioDAL.Add(socio) > 0)
                return true;
            else
                return false;
        }

        public bool Delete(Socio socio)
        {
            if (socioDAL.Delete(socio) > 0)
                return true;
            else
                return false;
        }

        public Socios GetAll()
        {
            return socioDAL.GetAll();
        }

        public Socio GetByID(Socio socio)
        {
            return socioDAL.GetByID(socio);
        }

        public Socio GetByDescripcion(Socio socio)
        {
            return socioDAL.GetByDescripcion(socio);
        }

        public bool Update(Socio socio)
        {
            if (socioDAL.Update(socio) > 0)
                return true;
            else
                return false;
        }

    }
}