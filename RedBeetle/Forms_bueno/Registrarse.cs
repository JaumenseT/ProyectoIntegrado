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
using RedBeetle.Forms_bueno;

namespace RedBeetle
{
    
	public partial class Registrarse : Form
	{
        InicioSesion caller;
        public Registrarse(InicioSesion caller)
		{
            this.caller = caller;
			InitializeComponent();
		}

        private void Registrarse_Load(object sender, EventArgs e) {
            txtUsuario.Text = "Nombre de Usuario";
            txtNombre.Text = "Nombre";
            txtContrasenya.Text = "Contraseña";
            txtCorreo.Text = "Correo";
        }

		private bool ValidarDatos()
		{
			var error = false;
			var mensaje = "";

			if(txtUsuario.Text == "")
			{
				error = true;
				mensaje = "El campo \"Nombre de usuario\" no puede estar vacio. \n";
				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (txtNombre.Text == "")
			{
				error = true;
				mensaje += "El campo \"Nombre\" no puede estar vacio. \n";
				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (txtCorreo.Text == "")
			{
				error = true;
				mensaje += "El campo \"Correo electrónico\" no puede estar vacio. \n";
				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (txtContrasenya.Text == "")
			{
				error = true;
				mensaje += "El campo \"Contraseña\" no puede estar vacio. \n";
				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return error;
		}

        private void lblCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
            caller.Show();
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			if (ValidarDatos())
			{
				//ValidarDatos automaticamente te muestra un message box por lo que aqui no hay que hacer nada.
			}
			else
			{
				//Falta codigo esto va al final
				Usuario usu = new Usuario(txtUsuario.Text, txtNombre.Text, txtContrasenya.Text, txtCorreo.Text);
				AccesoDatos.AgregarUsuario(usu);
				var formInicio = new InicioSesion();
				formInicio.Show();
				Close();
			}
		}

        private void llbRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Close();
            caller.Show();
        }

        private void txtUsuario_Enter(object sender, EventArgs e) {

        }

        private void txtNombre_Enter(object sender, EventArgs e) {

        }

        private void txtContrasenya_Enter(object sender, EventArgs e) {

        }

        private void txtCorreo_Enter(object sender, EventArgs e) {

        }
    }
}
