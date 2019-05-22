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
        byte[] imagen = null;
        Form caller;
        Usuario user; //instanciamos un atributo nombreUsuario para cargar desde inicio sesión y determinar que usuario esta logueado.

        public Modificar_Usuario(Form caller)
        {
            this.caller = caller;
            InitializeComponent();
            user = Aplicacion.User;
        }

		/// <summary>
		/// Al iniciar este formulario cargamos toda la información en los textbox con la información del usuario en cuestión.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Modificar_Usuario_Load(object sender, EventArgs e)
		{
			//Para que conforme vayas buscando te salgan resultados en el textbox
			var nombres = AccesoDatos.DevolverNombresUsuario();
			var lista = new AutoCompleteStringCollection();

			foreach (string elem in nombres)
			{
				lista.Add(elem);
			}
			txtBuscar.AutoCompleteCustomSource = lista;

			txtNombreUsuario.Text = user.Nombre_usuario;
			txtNombre.Text = user.Nombre;
			txtContrasenya.Text = user.Contrasenya;
			txtCorreo.Text = user.Correo;
			txtPaginaWeb.Text = user.Pagina_web;
			txtBiografia.Text = user.Biografia;
			txtContrasenya.PasswordChar = '*';
		}

		private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            caller.Show();
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
            else
			{
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
            AccesoDatos.ModificarUsuario(txtNombreUsuario.Text, txtNombre.Text, txtBiografia.Text, txtPaginaWeb.Text, user.Id_Usuario, imagen);
            this.Close();
            caller.Show();
        }

        private void picInicio_Click(object sender, EventArgs e)
        {
			caller.Show();
			Close();
		}

		private void PicPerfil_Click(object sender, EventArgs e)
		{

		}

		private void PicSubir_Click(object sender, EventArgs e)
		{

		}

        private void btnCambiarFoto_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)| All Files(*.*)|*.*|";

            if (dialog.ShowDialog() == DialogResult.OK) {
                string picPath = dialog.FileName.ToString();
                pbFoto.ImageLocation = picPath;
                imagen = System.IO.File.ReadAllBytes(picPath);
            }
        }
    }
}
