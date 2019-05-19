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
		private static bool error = false; //atributo que decidira si se hace el login o no, indicando si hay algun error en los metodos Login() y btn_Entrar()

        public InicioSesion()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Metodo privado de la clase para validar si hay campos vacios
		/// </summary>
		/// <returns>Devuelve un boolean indicando si ha habido errores</returns>
		private bool ValidarInicioSesion()
		{
			bool error = false;
			string mensaje = "";

			if (txtNombreUsuario.Text == "")
			{
				error = true;
				mensaje += "El nombre de usuario no puede estar vacío. \n";
			}
			if (txtContrasenya.Text == "")
			{
				error = true;
				mensaje += "La contraseña no puede estar vacía. \n";
			}
			if(mensaje != ""){

				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			
			return error;
		}

		private void lblCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Abre el form Registro
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void llbRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Registrarse formRegistro = new Registrarse(this);
			formRegistro.Show();
			this.Hide();
		}

		/// <summary>
		/// Metodo que validara si las credenciales de inicio de sesion son correctas
		/// </summary>
		public void Login()
		{
			if (!ValidarInicioSesion())
			{ //Si no hay ningun campo vacio

                Usuario usu = AccesoDatos.DevolverUsuario(txtNombreUsuario.Text); //Recojemos toda la informacion de un usuario y la metemos en usu

				if (usu == null) //Si el metodo no ha devuelto nada es que no existe dicho usuario
				{
					error = true; //Seteamos el error a true
					MessageBox.Show("Este usuario no existe en la base de datos.");
				}
				else
				{
					if (usu.Contrasenya != txtContrasenya.Text) //Si el usuario devuelto no tiene la misma pass que la escrita en el txt, seteamos el error a true.
					{
						MessageBox.Show("La contraseña introducida es incorrecta.");
						error = true;
					}
				}
			}
			else
			{
				error = true; //Si hay algun campo vacio, seteamos error a true
			}
		}

        private void btnEntrar_Click(object sender, EventArgs e) {
            Login(); //Llamamos al metodo Login para hacer la validacion
			if (!error) //Si no hay errores pasas al siguiente form
			{
				Home r1 = new Home(this);
				r1.Show();
				Hide();
			}
			else //Si no, si hay algun error, solo seteas el error global instanciado al principio de la clase a false para que cuando vuelvas a intentarlo no tengas ningun error de primeras.
			{
				error = false;
			}
		}
        
        public string ObtenerNombreUsuario() {
            return txtNombreUsuario.Text;
        }

		private void InicioSesion_Load(object sender, EventArgs e)
		{
			ActiveControl = picLogo; //Estetica
		}
	}
}


