using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.MODELOS
{
    public class DetalleIng
    {
        public int IDDetalleIng { get; set; }
        public int IDIngreso { get; set; }
        public int IDProducto { get; set; }
        public DateTime FechaVenc { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set; }
        public string Estado { get; set; }

    }
}
