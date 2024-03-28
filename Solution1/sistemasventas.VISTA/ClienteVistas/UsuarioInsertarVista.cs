using sistemasventas.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasventas.BSS;
using sistemasventas.VISTA.PersonasVistas;

namespace sistemasventas.VISTA.PersonasVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss Bss = new PersonaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            fr.ShowDialog();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                persona persona = Bss.ObtenerIdBss(IdPersonaSeleccionada);
                //textBox1 = persona.Nombre + "" + persona.Apellido;
            }
        }

        private void UsuarioInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr= new PersonaListarVista();
            if (fr.ShowDialog()==DialogResult.OK)
            {
                //persona persona = Bss.ObtenerIdBss(); 
            }
        }
    }
}
