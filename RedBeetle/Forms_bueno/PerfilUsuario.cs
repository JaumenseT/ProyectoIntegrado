﻿using System;
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
			Perfil p1 = new Perfil(nombreUsuario, this);
			p1.Show();
		}

		private void PicSubir_Click(object sender, EventArgs e)
		{
			var a = new AgregarImagen(nombreUsuario, this);
			a.Show();
			Close();
		}
	}
}
