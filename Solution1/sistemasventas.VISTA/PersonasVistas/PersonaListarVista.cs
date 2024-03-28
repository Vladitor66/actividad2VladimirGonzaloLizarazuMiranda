
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


namespace sistemasventas.VISTA.PersonasVistas
{
    public partial class PersonaListarVista : Form
    {
        public PersonaListarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void PersonaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            UsuarioInsertarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("estas seguro que quieres eliminar esta persona", "eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //bss.EditarPersonaBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaInsertarVista fr = new PersonaInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarPersonaBss();
            }
        }
    }
}
