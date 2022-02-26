using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Socio
    {
        public int idSocio { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }
        public string direccion { get; set; }

        public int idSucursal { get; set; }

        public decimal idAhorro { get; set; }

        public decimal idPrestamo { get; set; }
        public bool activo { get; set; }

        public Socio() { }

    }
}
