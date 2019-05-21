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
		public PerfilUsuario(string nomUsu, Form caller)
		{
			InitializeComponent();
			this.caller = caller;
			nombreUsuario = nomUsu;
		}

		private void PerfilUsuario_Load(object sender, EventArgs e)
		{	//Rellenar las imagenes
			var listaBytes = AccesoDatos.DevolverImagenes(nombreUsuario);
			var listaImagenes = Imagen.ConvertirArrayAImagen(listaBytes);

			if (listaImagenes.Count > 0)
			{
				for (int i = 0; i < listaImagenes.Count; i++)
				{
					try
					{
						pic1.BackgroundImage = listaImagenes[i];
						pic2.BackgroundImage = listaImagenes[i + 1];
						pic3.BackgroundImage = listaImagenes[i + 2];
						pic4.BackgroundImage = listaImagenes[i + 3];
						pic5.BackgroundImage = listaImagenes[i + 4];
					}
					catch
					{

					}
				}
			}
		}

		private void LblCerrar_Click(object sender, EventArgs e)
		{
			caller.Show();
			Close();
		}

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.FromArgb(247, 247, 247);
		}

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.White;
		}
	}
}
