using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class DetalleVentaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "\r\nSELECT     DETALLEVENTA.IDDETALLEVENTA, VENTA.FECHA, PRODUCTO.NOMBRE PRODUCTO, DETALLEVENTA.CANTIDAD, DETALLEVENTA.PRECIOVENTA, \r\n           DETALLEVENTA.SUBTOTAL, DETALLEVENTA.ESTADO\r\nFROM        DETALLEVENTA INNER JOIN\r\n                  VENTA ON DETALLEVENTA.IDVENTA = VENTA.IDVENTA INNER JOIN\r\n                  PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
