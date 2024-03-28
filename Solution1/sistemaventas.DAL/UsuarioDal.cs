using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class UsuarioDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT     USUARIO.IDPERSONA, (PERSONA.NOMBRE+' '+ PERSONA.APELLIDO) NOMBRECOMPLETO, \\n \" +\r\n                \"USUARIO.NOMBREUSER, USUARIOROL.FECHAASIGNA, ROL.NOMBRE AS NOMBREROL\\n\" +\r\n                \"FROM        PERSONA INNER JOIN\\n\" +\r\n                \"USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN\\n  \" +\r\n                \"USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN\\n \" +\r\n                \"ROL ON USUARIOROL.IDROL = ROL.IDROL";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
