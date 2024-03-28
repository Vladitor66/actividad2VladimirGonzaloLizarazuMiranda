using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaventas.DAL;

namespace sistemaventas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "\r\nSELECT     CLIENTE.IDCLIENTE, PERSONA.NOMBRE, CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO\r\nFROM        CLIENTE INNER JOIN\r\n                  PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA\r\n";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
