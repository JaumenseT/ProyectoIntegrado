using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input; //Necesario para los eventos de key input
using RedBeetle.Clases;
using RedBeetle.Forms;
using System.Text.RegularExpressions; //Para poder usar Regex
using RedBeetle.Forms_bueno;

namespace RedBeetle
{
    public partial class InicioSesion : Form
    {
		private static bool error = false; //atributo que decidira si se hace el login o no, indicando si hay algun error en los metodos Login() y btn_Entrar()
        List<byte[]> imagenesByte = null;
        List<Image> listaImagenes = null;

        public InicioSesion()
        {
            InitializeComponent();
        }

		private void InicioSesion_Load(object sender, EventArgs e)
		{
			ActiveControl = picLogo; //Estetica
			txtContrasenya.PasswordChar = '*';
		}

		/// <summary>
		/// Metodo privado de clase que al apretar cualquier boton comprobara si es el enter para asi darle directamente al boton entrar. Comodidad
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		///
		private void CheckEnter(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13) //Si el numero de tecla corresponde al 13, que es el enter, el btnEntrar se apretara automaticamente.
			{
				btnEntrar.PerformClick();
			}
		}

		/// <summary>
		/// Metodo privado de la clase para validar si hay campos vacios y para comprobar que no se sobrepasen longitud de caracteres o haya caracteres especiales
		/// </summary>
		/// <returns>Devuelve un boolean indicando si ha habido errores</returns>
		private bool ValidarInicioSesion(string nomUsu, string pass)
		{
			bool correcto = true;
			string mensaje = "";

			if (nomUsu == "")
			{
				correcto = false;
				mensaje += "El nombre de usuario no puede estar vacío. \n";
			}
			if (nomUsu == "")
			{
				correcto = false;
				mensaje += "La contraseña no puede estar vacía. \n";
			}
			if(nomUsu.Length > 25)
			{
				correcto = false;
				mensaje += "El nombre de usuario no puede tener mas de 25 caracteres.";
			}
			var regex = new Regex("^[a-zA-Z0-9_]*$"); //A esto se le llama Regular Expresion(RegEx) y sirve para evitar caracteres especiales.
			if (!regex.IsMatch(nomUsu) || !regex.IsMatch(pass)) //IsMatch determina si coinciden los caracteres del string con los seteados en el var
			{
				correcto = false;
				mensaje += "No se pueden usar caracteres especiales.";
			}
			if(mensaje != ""){

				MessageBox.Show(mensaje, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			return correcto;
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
			if (ValidarInicioSesion(txtNombreUsuario.Text, txtContrasenya.Text))
			{ //Si no hay ningun campo vacio

				Aplicacion.User = AccesoDatos.DevolverUsuario(txtNombreUsuario.Text); //Recojemos toda la informacion de un usuario y la metemos en usu

				if (Aplicacion.User == null) //Si el metodo no ha devuelto nada es que no existe dicho usuario
				{
					error = true; //Seteamos el error a true
					MessageBox.Show("Este usuario no existe en la base de datos.");
				}
				else
				{
					if (Aplicacion.User.Contrasenya != txtContrasenya.Text) //Si el usuario devuelto no tiene la misma pass que la escrita en el txt, seteamos el error a true.
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
            if (!error) {
                imagenesByte = AccesoDatos.DevolverImagenes(Aplicacion.User.Nombre_usuario);
                listaImagenes = Imagen.ConvertirArrayAImagen(imagenesByte);
            }
           
        }

		private bool FormAbierto()
		{
			bool a = false;

			//Compruebas si el form esta abierto.
			Form fc = Application.OpenForms["Home"];
			if (fc == null) a = false;
			else a = true;

			return a;
		}

        private void btnEntrar_Click(object sender, EventArgs e) {
			/*var pantallaEspera = new PantallaEspera2();
			pantallaEspera.Show();*/

			//Login();
			using (var pEspera = new PantallaEspera(Login))
			{
				pEspera.ShowDialog(this);
			}
			
			if (!error) //Si no hay errores pasas al siguiente form
			{
                Home r1 = new Home(this, imagenesByte, listaImagenes);
                r1.Show();
				Hide();
				//if (FormAbierto()) pantallaEspera.Dispose();
			}
			else //Si no, si hay algun error, solo seteas el error global instanciado al principio de la clase a false para que cuando vuelvas a intentarlo no tengas ningun error de primeras.
			{
				error = false;
			}
		}
        
        public string ObtenerNombreUsuario() {
			var nomUsu = txtContrasenya.Text;
			return nomUsu;
        }

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.FromArgb(216, 21, 25);
		}

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.FromArgb(251, 26, 30);
		}

		private void ChkMostrarPass_CheckedChanged(object sender, EventArgs e)
		{
			if (chkMostrarPass.Checked)
			{
				txtContrasenya.PasswordChar = '\0';
			}
			else
			{
				txtContrasenya.PasswordChar = '*';
			}
		}
	}
}


