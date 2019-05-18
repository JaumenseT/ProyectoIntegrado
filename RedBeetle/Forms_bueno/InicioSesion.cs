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
		private static bool error = false;

        public InicioSesion()
        {
            InitializeComponent();
        }

		private bool ValidarInicioSesion()
		{
			bool correcto = false;
			string mensaje = "";

			if (txtNombreUsuario.Text == "")
			{
				correcto = true;
				mensaje += "El nombre de usuario no puede estar vacío. \n";
			}
			if (txtContrasenya.Text == "")
			{
				correcto = true;
				mensaje += "La contraseña no puede estar vacía. \n";
			}
			/*if (!AccesoDatos.ComprobarUsuario(txtNombreUsuario.Text, txtContrasenya.Text))
			{
				error = true;
				mensaje += "El usuario no existe. \n";
			}*/
			if(mensaje != ""){

				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
			return correcto;
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

		public void Login2()
		{
			if (!ValidarInicioSesion())
			{ //Si no hay ningun campo vacio

                Usuario usu = AccesoDatos.DevolverUsuario(txtNombreUsuario.Text);

				if (usu == null)
				{
					error = true;
					MessageBox.Show("Este usuario no existe en la base de datos.");
				}
				else
				{
					if (usu.Contrasenya != txtContrasenya.Text)
					{
						MessageBox.Show("La contraseña introducida es incorrecta.");
						error = true;
					}
				}
			}
			else
			{
				error = true;
			}
		}

        private void btnEntrar_Click(object sender, EventArgs e) {
            Login2();
			if (!error)
			{
				Home r1 = new Home(this);
				r1.Show();
				Hide();
			}
			else
			{
				error = false;
			}
		}
        
        public string ObtenerNombreUsuario() {
            return txtNombreUsuario.Text;
        }

		private void InicioSesion_Load(object sender, EventArgs e)
		{
			ActiveControl = picLogo;
		}
	}
}


