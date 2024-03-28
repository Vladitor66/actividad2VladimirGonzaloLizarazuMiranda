using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.MODELOS
{
    public class DetalleVenta
    {
        public int IDDetalleVenta { get; set; }
        public int IDVenta { get; set; }
        public int IDProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set; }
        public string Estado { get; set; }

    }
}
