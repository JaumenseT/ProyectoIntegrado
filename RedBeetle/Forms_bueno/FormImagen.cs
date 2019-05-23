using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedBeetle.Properties;

namespace RedBeetle.Forms_bueno {
    public partial class FormImagen : Form {
        public FormImagen() {
            InitializeComponent();
        }
        // Hovers del form

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

        private void picEnlace1_MouseEnter(object sender, EventArgs e) {
            picEnlace1.BackgroundImage = Resources.link_oscuro;
        }

        private void picEnlace1_MouseLeave(object sender, EventArgs e) {
            picEnlace1.BackgroundImage = Resources.link_rojo;
        }

        private void picEnlace2_MouseEnter(object sender, EventArgs e) {
            picEnlace2.BackgroundImage = Resources.link_oscuro;
        }

        private void picEnlace2_MouseLeave(object sender, EventArgs e) {
            picEnlace2.BackgroundImage = Resources.link_rojo;
        }

        private void picEnlace3_MouseEnter(object sender, EventArgs e) {
            picEnlace3.BackgroundImage = Resources.link_oscuro;
        }

        private void picEnlace3_MouseLeave(object sender, EventArgs e) {
            picEnlace3.BackgroundImage = Resources.link_rojo;
        }

        private void picEnlace4_MouseEnter(object sender, EventArgs e) {
            picEnlace4.BackgroundImage = Resources.link_oscuro;
        }

        private void picEnlace4_MouseLeave(object sender, EventArgs e) {
            picEnlace4.BackgroundImage = Resources.link_rojo;
        }
    }
}
