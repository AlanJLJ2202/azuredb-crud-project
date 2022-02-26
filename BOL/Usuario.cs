using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Usuario
    {
        public int idUsuario { get; set; }

        public string nombre { get; set; }

        public string password { get; set; }

        public bool activo { get; set; }

        public Usuario() { }
    }
}
