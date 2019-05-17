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
			}
			if (txtNombre.Text == "")
			{
				error = true;
				mensaje += "El campo \"Nombre\" no puede estar vacio. \n";
			}
			if (txtCorreo.Text == "")
			{
				error = true;
				mensaje += "El campo \"Correo electrónico\" no puede estar vacio. \n";
			}
			if (txtContrasenya.Text == "")
			{
				error = true;
				mensaje += "El campo \"Contraseña\" no puede estar vacio. \n";
			}
			if(mensaje == "")
			{
				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return error;
		}

        private void lblCerrar_Click(object sender, EventArgs e)
		{
			Close();
            caller.Show();
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			var mensaje = "";
			if (ValidarDatos())
			{
				//ValidarDatos automaticamente te muestra un message box por lo que aqui no hay que hacer nada.
			}
			else
			{
				var usu = AccesoDatos.DevolverUsuario(txtUsuario.Text);

				if(usu != null)
				{
					mensaje += "Ese nombre de usuario ya está en uso, por favor utilice otro. \n";
				}
				if(usu.Correo == txtCorreo.Text)
				{
                    mensaje += "Este correo electrónico ya está registrado, por favor use otro.";
				}
				if(mensaje != "")
				{
					MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				var usuario = new Usuario(txtUsuario.Text, txtNombre.Text, txtContrasenya.Text, txtCorreo.Text);

				AccesoDatos.AgregarUsuario(usuario);
				var formInicio = new InicioSesion();
				formInicio.Show();
				Close();
			}
		}

        private void llbRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Close();
            caller.Show();
        }

        private void txtUsuario_Enter(object sender, EventArgs e) {
			txtUsuario.Clear();
        }

        private void txtNombre_Enter(object sender, EventArgs e) {
			txtNombre.Clear();
		}

        private void txtContrasenya_Enter(object sender, EventArgs e) {
			txtContrasenya.Clear();
		}

        private void txtCorreo_Enter(object sender, EventArgs e) {
			txtCorreo.Clear();
		}
    }
}
