using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Colaborador
    {
        public int idColaborador { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }
        public string direccion { get; set; }

        public decimal sueldo { get; set; }

        public int idArea { get; set; }

        public int idSucursal { get; set; }

        public bool activo { get; set; }

        public Colaborador() { }
    }

    
}
