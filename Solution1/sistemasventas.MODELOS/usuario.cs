using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasventas.MODELOS
{
    public class usuario
    {
        public int IdUsuario {  get; set; }
        public int IdPersona {  get; set; }
        public string Nombreuser {  get; set; }
        public int Contraseña { get; set; }
        public DateTime Fecha { get; set; }
    }
}
