using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.MODELOS
{
    public class Provee
    {
        public int IDProvee { get; set; }
        public int IDProducto { get; set; }
        public int IDProveedor { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }

    }
}
