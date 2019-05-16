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
			Registrarse formRegistro = new Registrarse(this);
			formRegistro.Show();
			this.Hide();
		}

        public void Login() {
            if (!AccesoDatos.ComprobarUsuario(txtNombreUsuario.Text, txtContrasenya.Text)) {
                MessageBox.Show("Datos incorrectos!");
            } else {
                MessageBox.Show("Usuario y contraseña correctos!");
                Home r1 = new Home(this);
                r1.Show();
                this.Hide();
            }
        }

        private bool ValidarInicioSesion() {
            bool error = false;
            string mensaje = "";

            if (txtNombreUsuario.Text == "") {
                error = true;
                mensaje += "El nombre de usuario no puede estar vacío. \n";
            }
            if (txtContrasenya.Text == "") {
                error = true;
                mensaje += "La contraseña no puede estar vacía. \n";
            }
            if (!AccesoDatos.ComprobarUsuario(txtNombreUsuario.Text, txtContrasenya.Text))
            {
                error = true;
                mensaje += "El usuario no existe. \n";
            }
            MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return error;
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            Login();
            txtNombreUsuario.Clear();
            txtContrasenya.Clear();
            /*
            if (ValidarInicioSesion()) {
                var formInicio = new InicioSesion();
                formInicio.Show();
                Close();
            }
            */
        }
    }
}


