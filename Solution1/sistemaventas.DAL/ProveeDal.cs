using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class ProveeDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT        PROVEE.IDPROVEE, PRODUCTO.NOMBRE, PROVEEDOR.NOMBRE AS NOMBRE_PROVEEDOR, PROVEE.FECHA, PROVEE.PRECIO\r\nFROM            PROVEE INNER JOIN\r\n                         PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\r\n                         PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
