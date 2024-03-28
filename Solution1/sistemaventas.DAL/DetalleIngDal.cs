using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "SELECT        DETALLEING.IDDETALLEING, PRODUCTO.NOMBRE, INGRESO.TOTAL, DETALLEING.FECHAVENC, DETALLEING.CANTIDAD, DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL, \r\n                         DETALLEING.ESTADO\r\nFROM            DETALLEING INNER JOIN\r\n                         PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\r\n                         INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
