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

namespace RedBeetle.Forms_bueno
{
    public partial class Modificar_Usuario : Form
    {
		Home callerHome;
		InicioSesion callerLogin;
        string nombreUsuario; //instanciamos un atributo nombreUsuario para cargar desde inicio sesión y determinar que usuario esta logueado.

        public Modificar_Usuario(string nombreUsuario)
        {
            InitializeComponent();

            this.nombreUsuario = nombreUsuario; //pasamos este atributo por el constructor del form.
        }

        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.BackColor = Color.White;
		}

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.BackColor = Color.FromArgb(247, 247, 247);
		}

		/*private void PicInicio_Click(object sender, EventArgs e)
		{
			var home = new Home(callerLogin);
			home.Show();
			Close();
		}*/

		private void PicLikes_Click(object sender, EventArgs e)
		{

		}

        /// <summary>
        /// Al iniciar este formulario cargamos toda la información en los textbox con la información del usuario en cuestión.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modificar_Usuario_Load(object sender, EventArgs e)
        {
            Usuario usu = AccesoDatos.DevolverUsuario(nombreUsuario);
            txtNombreUsuario.Text = usu.Nombre_usuario;
            txtNombre.Text = usu.Nombre;
            txtContrasenya.Text = usu.Contrasenya;
            txtCorreo.Text = usu.Correo;
            txtPaginaWeb.Text = usu.Pagina_web;
            txtBiografia.Text = usu.Biografia;
            txtContrasenya.PasswordChar = '*';
        }

        /// <summary>
        /// //En caso de que el textbox este seleccionado, mostrará la contraseña, en caso contrario permanecerá oculta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarPass.Checked)
            {
                txtContrasenya.PasswordChar = '\0';
            }
            else {
                txtContrasenya.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Llama a la clase AccesoDatos, más en concreto a su función de modificar el usuario, el usuario se modificará con la información
        /// que se encuentra en los textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usu = AccesoDatos.DevolverUsuario(nombreUsuario);
            AccesoDatos.ModificarUsuario(txtNombreUsuario.Text, txtNombre.Text, txtBiografia.Text, txtPaginaWeb.Text, usu.Id_Usuario);
        }

        /*private void PicPerfil_Click(object sender, EventArgs e)
		{
			var perfil = new Perfil(callerHome);

		}*/

        /*private void PicSubir_Click(object sender, EventArgs e)
		{
			var f = new AgregarImagen(callerHome);
		}*/
    }
}
