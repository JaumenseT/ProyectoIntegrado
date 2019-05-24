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
using System.Text.RegularExpressions; //Para poder usar Regex

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
		public void CheckEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				btnRegistrarse.PerformClick();
			}
		}

		/// <summary>
		/// Metodo que comprobara si el email introducido es valido
		/// </summary>
		/// <param name="email"></param>
		/// <returns>Devuelve true si es valido o false</returns>
		public bool EmailValido(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Comprueba que no haya ningun campo vacio y que no hayan caracteres especiales
		/// </summary>
		/// <returns>Devuelve true si hay error o false</returns>
		private bool ValidarDatos(/*string nomUsu, string nom, string cor, string pass*/)
		{
			var error = false;
			var mensaje = "";

			if (txtUsuario.Text/*nomUsu*/ == "")
			{
				error = true;
				mensaje = "El campo \"Nombre de usuario\" no puede estar vacio. \n";
			}
			if (txtNombre.Text/*nom*/ == "")
			{
				error = true;
				mensaje += "El campo \"Nombre\" no puede estar vacio. \n";
			}
			if (txtCorreo.Text/*cor*/ == "")
			{
				error = true;
				mensaje += "El campo \"Correo electrónico\" no puede estar vacio. \n";
			}
			if (txtContrasenya.Text/*pass*/ == "")
			{
				error = true;
				mensaje += "El campo \"Contraseña\" no puede estar vacio. \n";
			}
			if(txtContrasenya.TextLength/*pass.Length*/ < 6)
			{
				error = true;
				mensaje += "La contraseña debe tener al menos 6 caracteres. \n";
			}
			if(txtContrasenya.TextLength/*pass.Length*/ > 18)
			{
				mensaje += "La contraseña no puede superar los 18 caracteres. \n";
			}

			var regex = new Regex("^[a-zA-Z0-9_]*$");//A esto se le llama Regular Expresion(RegEx) y sirve para evitar caracteres especiales.
			if (!regex.IsMatch(txtUsuario.Text) || !regex.IsMatch(txtNombre.Text) || !regex.IsMatch(txtContrasenya.Text))//IsMatch determina si coinciden los caracteres del string con los seteados en el var
			{
				error = true;
				mensaje += "No se pueden usar caracteres especiales. \n";
			}
			if (!EmailValido(txtCorreo.Text))
			{
				error = true;
				mensaje += "El email no tiene el formato correcto. \n";
			}
			if(mensaje != "") //Si el mensjae no esta vacio te salta el MessageBox
			{
				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return error;
		}

		private void lblCerrar_Click(object sender, EventArgs e)
		{
            this.Close();
			caller.Show();
		}

		private void EjecutarRegistro()
		{
			var mensaje = "";
			if (ValidarDatos(/*txtUsuario.Text, txtNombre.Text, txtContrasenya.Text, txtCorreo.Text*/)) //Este if esta vacio para que se llame al metodo ValidarDatos y si el error es true te muestre el MessageBox
			{
				//ValidarDatos automaticamente te muestra un message box por lo que aqui no hay que hacer nada.
			}
			else
			{
				var nomUsu = AccesoDatos.DevolverUsuario(txtUsuario.Text); ///Llamamos al metodo que devuelve un usuario
				var correo = AccesoDatos.ExisteCorreo(txtCorreo.Text);

				if (nomUsu != null) //Si devuelve alguno es que ya existe un usuario con ese nombre de usuario
				{
					mensaje += "Ese nombre de usuario ya está en uso, por favor utilice otro. \n";
				}
				if (correo) //Si el correo escrito ya existe se agrega este mensaje
				{
					mensaje += "Este correo electrónico ya está registrado, por favor use otro.";
				}
				if (mensaje != "") //Si el mensaje no esta vacio salta el MessageBox
				{
					MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else //Si el mensaje esta vacio entonces no hay ningun error por lo que procedemos con el registro
				{
					var usuario = new Usuario(txtUsuario.Text, txtNombre.Text, txtContrasenya.Text, txtCorreo.Text); //Por ahora solo le pasamos los datos necesarios, y en modificar perfil
																													 //haremos un update con la biografia y la pagina 
					AccesoDatos.AgregarUsuario(usuario);
					var formInicio = new InicioSesion();
					formInicio.Show();
					cerrar = true;
					//Close();
				}
			}
		}

		bool cerrar = false;
		/// <summary>
		/// Registra un nuevo usuario en la base de datos
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			/*using (var pEspera = new PantallaEspera(EjecutarRegistro))
			{
				pEspera.ShowDialog(this);
			}
			if (cerrar == true) Close();
			*/
			var mensaje = "";
			if (ValidarDatos()) //Este if esta vacio para que se llame al metodo ValidarDatos y si el error es true te muestre el MessageBox
			{
				//ValidarDatos automaticamente te muestra un message box por lo que aqui no hay que hacer nada.
			}
			else
			{
				var nomUsu = AccesoDatos.DevolverUsuario(txtUsuario.Text); ///Llamamos al metodo que devuelve un usuario
				var correo = AccesoDatos.ExisteCorreo(txtCorreo.Text);

				if (nomUsu != null) //Si devuelve alguno es que ya existe un usuario con ese nombre de usuario
				{
					mensaje += "Ese nombre de usuario ya está en uso, por favor utilice otro. \n";
				}
				if (correo) //Si el correo escrito ya existe se agrega este mensaje
				{
					mensaje += "Este correo electrónico ya está registrado, por favor use otro.";
				}
				if (mensaje != "") //Si el mensaje no esta vacio salta el MessageBox
				{
					MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else //Si el mensaje esta vacio entonces no hay ningun error por lo que procedemos con el registro
				{
					var usuario = new Usuario(txtUsuario.Text, txtNombre.Text, txtContrasenya.Text, txtCorreo.Text); //Por ahora solo le pasamos los datos necesarios, y en modificar perfil
																													 //haremos un update con la biografia y la pagina 
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

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.FromArgb(216, 21, 25);
		}

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.FromArgb(251, 26, 30);
		}
	}
}
