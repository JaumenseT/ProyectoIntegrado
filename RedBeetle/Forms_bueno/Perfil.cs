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
            lblNombreUsuario.Text = user.Nombre_usuario;
            picUsuario.Image = Imagen.ConvertirImagen(user.Foto_Perfil);

			//Rellenar picturebox
			var imagenesByte = AccesoDatos.DevolverImagenes(user.Nombre_usuario);
			var listaImagenes = Imagen.ConvertirArrayAImagen(imagenesByte);

			if (listaImagenes.Count > 0)
			{
				for (int i = 0; i < listaImagenes.Count; i++)
				{
					try
					{
						if (pic1.BackgroundImage == null)
						{
							pic1.BackgroundImage = listaImagenes[i];
						}
						if (pic2.BackgroundImage == null)
						{
							pic2.BackgroundImage = listaImagenes[i + 1];
						}
						if (pic3.BackgroundImage == null)
						{
							pic3.BackgroundImage = listaImagenes[i + 2];
						}
						if (pic4.BackgroundImage == null)
						{
							pic4.BackgroundImage = listaImagenes[i + 3];
						}
						if (pic5.BackgroundImage == null)
						{
							pic5.BackgroundImage = listaImagenes[i + 4];
						}
					}
					catch
					{

					}
				}
			}
            //Rellenar los datos
            lblNombreUsuario.Text = user.Nombre_usuario;
			txtDescripcion.Text = user.Biografia;
			txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
			txtDescripcion.BackColor = Color.White;
		}

        private void lblCerrar_Click_1(object sender, EventArgs e) {
            Close();
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

        private void ptbCamara2_Click(object sender, EventArgs e) {
            var a = new AgregarImagen(this.caller);
            a.Show();
            this.Hide();
        }

		private void IrAgregar()
		{
			var a = new AgregarImagen(this);
			a.Show();
		}

        private void picSubir_Click(object sender, EventArgs e)
		{
			var a = new AgregarImagen(this.caller);
			a.Show();
			Hide();
		}

		private void PicPerfil_Click(object sender, EventArgs e)
		{

		}
	}
}
