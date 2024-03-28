using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.MODELOS
{
    public class Ingreso
    {
        public int IDIngreso { get; set; }
        public int IDProveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }

    }
}
