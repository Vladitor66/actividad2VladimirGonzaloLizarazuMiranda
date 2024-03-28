using sistemasventas.BSS;
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

namespace sistemasventas.VISTA.PersonasVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        persona p = new persona();
        PersonaBss bss = new PersonaBss();

        public PersonaEditarVista()
        {
            idx = idx;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
            textBox3.Text = p.Telefono;
            textBox4.Text = p.Ci;
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text; 
            p.Telefono = textBox3.Text;
            p.Ci = textBox4.Text;
            bss.EditarPersonaBss(p);
            
        }
    }
}
