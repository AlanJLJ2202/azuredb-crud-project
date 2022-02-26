using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Ahorro
    {
        public int idAhorro { get; set; }

        public int idSocio { get; set; }

        public decimal monto { get; set; }

        public decimal tasaInteres { get; set; }

        public bool activo { get; set; }
    }
}
