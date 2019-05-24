using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedBeetle.Forms;
using RedBeetle.Clases;
using RedBeetle.Forms_bueno;
using RedBeetle.Properties;

namespace RedBeetle.Forms_bueno
{
    public partial class Perfil : Form
    {
        Form caller;
		Usuario user;
        public Perfil(Form caller)
        {
            this.caller = caller;
            user = Aplicacion.User;
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e) {
            RefrescarDatos();
            var listaImagenes = AccesoDatos.DevolverImagenes(user.Nombre_usuario);

            if (listaImagenes.Count > 0)
			{
				for (int i = 0; i < listaImagenes.Count; i++)
				{
					try
					{
						if (pic1.BackgroundImage == null)
						{
							pic1.BackgroundImage = listaImagenes[i].NewImage;
						}
						if (pic2.BackgroundImage == null)
						{
							pic2.BackgroundImage = listaImagenes[i + 1].NewImage;
						}
						if (pic3.BackgroundImage == null)
						{
							pic3.BackgroundImage = listaImagenes[i + 2].NewImage;
						}
						if (pic4.BackgroundImage == null)
						{
							pic4.BackgroundImage = listaImagenes[i + 3].NewImage;
						}
						if (pic5.BackgroundImage == null)
						{
							pic5.BackgroundImage = listaImagenes[i + 4].NewImage;
						}
					}
					catch
					{

					}
				}
			}
            
		}
        public void RefrescarDatos() {
            //Rellenar los datos
            user = Aplicacion.User;
            lblNombreUsuario.Text = user.Nombre_usuario;
            txtDescripcion.Text = user.Biografia;
            txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txtDescripcion.BackColor = Color.White;
            lblNombreUsuario.Text = user.Nombre_usuario;
            picUsuario.Image = Imagen.ConvertirImagen(user.Foto_Perfil);
            ((Home)caller).RefrescarUsuario();
        }

        private void lblCerrar_Click_1(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }

        private void picInicio_Click(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
			var m = new Modificar_Usuario(this);
			m.Show();
			this.Hide();
		}

		private void lblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.Silver;
		}

		private void lblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.White;
		}

        private void picSubir_Click(object sender, EventArgs e)
		{
			var a = new AgregarImagen(this.caller);
			a.Show();
			Hide();
		}

        // Hovers del form

        private void picAnterior_MouseEnter(object sender, EventArgs e) {
            picAnterior.BackgroundImage = Resources.anterior_oscura;
        }

        private void picAnterior_MouseLeave(object sender, EventArgs e) {
            picAnterior.BackgroundImage = Resources.anterior_roja;
        }

        private void picSiguiente_MouseEnter(object sender, EventArgs e) {
            picSiguiente.BackgroundImage = Resources.siguiente_oscura;
        }

        private void picSiguiente_MouseLeave(object sender, EventArgs e) {
            picSiguiente.BackgroundImage = Resources.siguiente_roja;
        }

        private void picInicio_MouseEnter(object sender, EventArgs e) {
            picInicio.BackgroundImage = Resources.beetle_gris;
        }

        private void picInicio_MouseLeave(object sender, EventArgs e) {
            picInicio.BackgroundImage = Resources.beetle_blanco;
        }

        private void picLikes_MouseEnter(object sender, EventArgs e) {
            picLikes.BackgroundImage = Resources.corazon_gris;
        }

        private void picLikes_MouseLeave(object sender, EventArgs e) {
            picLikes.BackgroundImage = Resources.corazon_blanco;
        }

        private void picPerfil_MouseEnter(object sender, EventArgs e) {
            picPerfil.BackgroundImage = Resources.perfil_gris;
        }

        private void picPerfil_MouseLeave(object sender, EventArgs e) {
            picPerfil.BackgroundImage = Resources.perfil_blanco;
        }

        private void picSubir_MouseEnter(object sender, EventArgs e) {
            picSubir.BackgroundImage = Resources.camara_gris;
        }

        private void picSubir_MouseLeave(object sender, EventArgs e) {
            picSubir.BackgroundImage = Resources.camara_blanca;
        }

        private void picFavoritos_MouseEnter(object sender, EventArgs e) {
            picFavoritos.BackgroundImage = Resources.corazon_oscuro;
        }

        private void picFavoritos_MouseLeave(object sender, EventArgs e) {
            picFavoritos.BackgroundImage = Resources.corazon_rojo;
        }

        private void picFotos_MouseEnter(object sender, EventArgs e) {
            picFotos.BackgroundImage = Resources.fotos_oscura;
        }

        private void picFotos_MouseLeave(object sender, EventArgs e) {
            picFotos.BackgroundImage = Resources.fotos_roja;
        }
    }
}
