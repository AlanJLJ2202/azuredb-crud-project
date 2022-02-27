using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Sucursal
    {
        public int idSucursal { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono{ get; set; }
        public bool activo { get; set; }

        public Sucursal() { }

    }
}
