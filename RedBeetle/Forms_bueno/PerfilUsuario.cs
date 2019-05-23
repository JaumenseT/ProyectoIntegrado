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

namespace RedBeetle.Forms_bueno
{
	public partial class PerfilUsuario : Form
	{
		Form caller;
		string nombreUsuario;

		List<byte[]> imagenesByte = null;
		List<Image> listaImagenes = null;
		int longitudAtras = 0;
		int longitudSiguiente = 0;

		public PerfilUsuario(string nomUsu, Form caller, List<byte[]> imagenByte, List<Image> listaImagenes)
		{
			InitializeComponent();
			this.caller = caller;
			nombreUsuario = nomUsu;

			imagenesByte = imagenByte;
			this.listaImagenes = listaImagenes;
		}

		private void PerfilUsuario_Load(object sender, EventArgs e)
		{
			//Rellenar las imagenes
			var listaBytes = AccesoDatos.DevolverImagenes(nombreUsuario);
			var listaImagenes = Imagen.ConvertirArrayAImagen(listaBytes);

			if (listaImagenes.Count > 0)
			{
				for (int i = 0; i < listaImagenes.Count; i++)
				{
					try
					{
						if(pic1.BackgroundImage == null)
						{
							pic1.BackgroundImage = listaImagenes[i];
						}
						if (pic2.BackgroundImage == null)
						{
							pic2.BackgroundImage = listaImagenes[i+1];
						}
						if (pic3.BackgroundImage == null)
						{
							pic3.BackgroundImage = listaImagenes[i+2];
						}
						if (pic4.BackgroundImage == null)
						{
							pic4.BackgroundImage = listaImagenes[i+3];
						}
						if (pic5.BackgroundImage == null)
						{
							pic5.BackgroundImage = listaImagenes[i+4];
						}
					}
					catch
					{

					}
				}
			}
			//Rellenar los datos
			var usu = AccesoDatos.DevolverUsuario(nombreUsuario);
			lblNombre.Text = usu.Nombre;
			lblNombreUsuario.Text = usu.Nombre_usuario;
			txtDescripcion.Text = usu.Biografia;
			txtDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
			txtDescripcion.BackColor = Color.White;
		}

		private void LblCerrar_Click(object sender, EventArgs e)
		{
			Close();
			caller.Show();
		}

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.Silver;
		}

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.White;
		}

		private void PicInicio_Click(object sender, EventArgs e)
		{
			caller.Show();
			Close();
		}

		private void PicPerfil_Click(object sender, EventArgs e)
		{
			Close();
			Perfil p1 = new Perfil(this);
			p1.Show();
		}

		private void PicSubir_Click(object sender, EventArgs e)
		{
			var a = new AgregarImagen(this);
			a.Show();
			Close();
		}

		private void PicAnterior_Click(object sender, EventArgs e)
		{
			if (listaImagenes.Count > 0)
			{
				if (longitudAtras > 0)
				{
					pic5.BackgroundImage = pic4.BackgroundImage;
					pic4.BackgroundImage = pic3.BackgroundImage;
					pic3.BackgroundImage = pic2.BackgroundImage;
					pic2.BackgroundImage = pic1.BackgroundImage;
					pic1.BackgroundImage = listaImagenes[longitudAtras - 1];
					longitudAtras--;
					longitudSiguiente--;
				}
			}
		}

		private void PicSiguiente_Click(object sender, EventArgs e)
		{
			if (listaImagenes.Count > 0)
			{
				var lastElement = listaImagenes[listaImagenes.Count - 1];
				if (pic5.BackgroundImage != lastElement)
				{
					pic1.BackgroundImage = pic2.BackgroundImage;
					pic2.BackgroundImage = pic3.BackgroundImage;
					pic3.BackgroundImage = pic4.BackgroundImage;
					pic4.BackgroundImage = pic5.BackgroundImage;
					pic5.BackgroundImage = listaImagenes[longitudSiguiente + 5];
					longitudSiguiente++;
					longitudAtras++;
				}
			}
		}
	}
}
