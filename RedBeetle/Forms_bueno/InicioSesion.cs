using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedBeetle.Clases;
using RedBeetle.Forms;

namespace RedBeetle
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

		private void lblCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void llbRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var formRegistro = new Registrarse();
			formRegistro.Show();
			Hide();
		}

        public void Join() {
            if (!AccesoDatos.ComprobarUsuario(txtNombreUsuario.Text, txtContrasenya.Text)) {
                MessageBox.Show("Datos incorrectos!");
            } else {
                MessageBox.Show("Usuario y contraseña correctos!");
                Home r1 = new Home();
                r1.Show();
                this.Hide();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            Join();
        }
    }
}


