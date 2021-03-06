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
using RedBeetle.Properties;

namespace RedBeetle.Forms_bueno
{
	public partial class PerfilUsuario : Form
	{
        int offset = 0;
		Form caller;
		string nombreUsuario;
        Usuario usu;
		List<Imagen> listaImagenes = null;
		int longitudAtras = 0;
		int longitudSiguiente = 0;

		public PerfilUsuario(string nomUsu, Form caller, List<Imagen> listaImagenes)
		{
			InitializeComponent();
			this.caller = caller;
			nombreUsuario = nomUsu;
            this.listaImagenes = listaImagenes;
            usu = AccesoDatos.DevolverUsuario(nombreUsuario);
        }

		private void PerfilUsuario_Load(object sender, EventArgs e)
		{
			//Rellenar las imagenes
			var listaImagenes = AccesoDatos.DevolverImagenes(nombreUsuario);

            if (listaImagenes.Count > 0)
			{
				for (int i = 0; i < listaImagenes.Count; i++)
				{
					try
					{
						if(pic1.BackgroundImage == null)
						{
							pic1.BackgroundImage = listaImagenes[i].NewImage;
						}
						if (pic2.BackgroundImage == null)
						{
							pic2.BackgroundImage = listaImagenes[i+1].NewImage;
						}
						if (pic3.BackgroundImage == null)
						{
							pic3.BackgroundImage = listaImagenes[i+2].NewImage;
						}
						if (pic4.BackgroundImage == null)
						{
							pic4.BackgroundImage = listaImagenes[i+3].NewImage;
						}
						if (pic5.BackgroundImage == null)
						{
							pic5.BackgroundImage = listaImagenes[i+4].NewImage;
						}
					}
					catch
					{

					}
				}
			}
            //Rellenar los datos
            picUsuario.Image = Imagen.ConvertirImagen(usu.Foto_Perfil);
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
			Perfil p1 = new Perfil(this.caller);
			p1.Show();
		}

		private void PicSubir_Click(object sender, EventArgs e)
		{
			var a = new AgregarImagen(this.caller);
			a.Show();
			Close();
		}

		private void PicAnterior_Click(object sender, EventArgs e)
		{
			if (listaImagenes.Count > 0)
			{
				if (offset > 0)
				{
					pic5.BackgroundImage = pic4.BackgroundImage;
					pic4.BackgroundImage = pic3.BackgroundImage;
					pic3.BackgroundImage = pic2.BackgroundImage;
					pic2.BackgroundImage = pic1.BackgroundImage;
					pic1.BackgroundImage = listaImagenes[longitudAtras - 1].NewImage;
					longitudAtras--;
					longitudSiguiente--;
                    offset--;
				}
			}
		}

		private void PicSiguiente_Click(object sender, EventArgs e)
		{
			if (listaImagenes.Count > 5)
			{
				var lastElement = listaImagenes[listaImagenes.Count - 1];
				if (pic5.BackgroundImage != lastElement.NewImage)
				{
					pic1.BackgroundImage = pic2.BackgroundImage;
					pic2.BackgroundImage = pic3.BackgroundImage;
					pic3.BackgroundImage = pic4.BackgroundImage;
					pic4.BackgroundImage = pic5.BackgroundImage;
					pic5.BackgroundImage = listaImagenes[longitudSiguiente + 5].NewImage;
					longitudSiguiente++;
					longitudAtras++;
                    offset++;
				}
			}
		}

        private void AbrirFoto(int index) {
            if (index + offset < listaImagenes.Count) {
                FormImagen fm = new FormImagen(this, listaImagenes[index + offset]);
                fm.Show();
                this.Hide();
            }
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

        private void picFotos_MouseEnter(object sender, EventArgs e) {
            picFotos.BackgroundImage = Resources.fotos_oscura;
        }

        private void picFotos_MouseLeave(object sender, EventArgs e) {
            picFotos.BackgroundImage = Resources.fotos_roja;
        }

        private void pic1_Click(object sender, EventArgs e) {
            AbrirFoto(0);
        }

        private void pic2_Click(object sender, EventArgs e) {
            AbrirFoto(1);
        }

        private void pic3_Click(object sender, EventArgs e) {
            AbrirFoto(2);
        }

        private void pic4_Click(object sender, EventArgs e) {
            AbrirFoto(3);
        }

        private void pic5_Click(object sender, EventArgs e) {
            AbrirFoto(4);
        }
    }
}
