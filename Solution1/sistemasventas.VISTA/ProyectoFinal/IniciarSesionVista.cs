using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasventas.VISTA.ProyectoFinal
{
    public partial class IniciarSesionVista : Form
    {
        public IniciarSesionVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox3.Text;
            string contraseña = textBox2.Text;

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesion exitoso");
                AdministradorPersonaVista formulario = new AdministradorPersonaVista();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
