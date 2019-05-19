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
			ActiveControl = picLogo; //estetica
        }

		/// <summary>
		/// Metodo privado de clase que al apretar cualquier boton comprobara si es el enter para asi darle directamente al boton entrar. Comodidad
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CheckEnter(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13)
			{
				btnRegistrarse.PerformClick();
			}
		}

		/// <summary>
		/// Comprueba que no haya ningun campo vacio
		/// </summary>
		/// <returns></returns>
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
			if(mensaje != "") //Si el mensjae no esta vacio te salta el MessageBox
			{
				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return error;
		}

        private void lblCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Registra un nuevo usuario en la base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			var mensaje = "";
			if (ValidarDatos()) //Este if esta vacio para que se llame al metodo ValidarDatos y si el error es true te muestre el MessageBox
			{
				//ValidarDatos automaticamente te muestra un message box por lo que aqui no hay que hacer nada.
			}
			else
			{
				var nomUsu = AccesoDatos.DevolverUsuario(txtUsuario.Text); ///Llamamos al metodo que devuelve un usuario
				var correo = AccesoDatos.ExisteCorreo(txtCorreo.Text);

				if(nomUsu != null) //Si devuelve alguno es que ya existe un usuario con ese nombre de usuario
				{
					mensaje += "Ese nombre de usuario ya está en uso, por favor utilice otro. \n";
				}
				if(correo) //Si el correo escrito ya existe se agrega este mensaje
				{
                    mensaje += "Este correo electrónico ya está registrado, por favor use otro.";
				}
				if(mensaje != "") //Si el mensaje no esta vacio salta el MessageBox
				{
					MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else //Si el mensaje esta vacio entonces no hay ningun error por lo que procedemos con el registro
				{
					var usuario = new Usuario(txtUsuario.Text, txtNombre.Text, txtContrasenya.Text, txtCorreo.Text); //Por ahora solo le pasamos los datos necesarios, y en modificar perfil
					//haremos un update con la biografia y la pagina web

					AccesoDatos.AgregarUsuario(usuario);
					var formInicio = new InicioSesion();
					formInicio.Show();

					Close();
				}
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
