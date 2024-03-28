using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class UsuarioRol
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT     USUARIOROL.IDUSUARIOROL, USUARIO.NOMBREUSER, ROL.NOMBRE ROLNAME, USUARIOROL.FECHAASIGNA, USUARIOROL.ESTADO\r\nFROM        USUARIOROL INNER JOIN\r\n                  USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN\r\n                  ROL ON USUARIOROL.IDROL = ROL.IDROL\r\n";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
