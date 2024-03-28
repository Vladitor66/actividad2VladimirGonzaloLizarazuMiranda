using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class IngresoDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT        INGRESO.IDINGRESO, PROVEEDOR.NOMBRE, INGRESO.FECHAINGRESO, INGRESO.TOTAL, INGRESO.ESTADO\r\nFROM            INGRESO INNER JOIN\r\n                         PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
