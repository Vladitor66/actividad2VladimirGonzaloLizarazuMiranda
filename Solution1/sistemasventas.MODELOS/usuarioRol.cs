using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.MODELOS
{
    public class usuarioRol
    {
        public int IDUsuarioRol { get; set; }
        public int IDUsuario { get; set; }
        public int IDRol { get; set; }
        public DateTime FechaAsigna { get; set; }
        public string Estado { get; set; }

    }
}
