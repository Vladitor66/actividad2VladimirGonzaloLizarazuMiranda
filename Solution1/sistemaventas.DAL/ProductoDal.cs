using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class ProductoDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT        PRODUCTO.IDPRODUCTO, TIPOPROD.NOMBRE, PRODUCTO.NOMBRE AS NOMBRE_MARCA, PRODUCTO.CODIGOBARRA, MARCA.NOMBRE AS Expr2, PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION, PRODUCTO.ESTADO\r\nFROM            PRODUCTO INNER JOIN\r\n                         TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN\r\n                         MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
