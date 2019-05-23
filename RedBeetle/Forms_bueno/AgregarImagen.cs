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
using RedBeetle.Forms_bueno;
using RedBeetle.Clases;
using RedBeetle.Properties;

namespace RedBeetle.Forms_bueno {
    public partial class AgregarImagen : Form {

		Form caller;
        Usuario user;
        byte[] imagen = null;

        public AgregarImagen(Form caller) {
            this.caller = caller;
            user = Aplicacion.User;
            InitializeComponent();
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)| All Files(*.*)|*.*|";

            if (dialog.ShowDialog() == DialogResult.OK) {
                string picPath = dialog.FileName.ToString();
                pbFoto.ImageLocation = picPath;
                imagen = System.IO.File.ReadAllBytes(picPath);
            }
        }

        private void SubirFoto() {  
            AccesoDatos.AgregarImagen(new Imagen(txtDescripcion.Text, imagen, user.Id_Usuario));
            int img = AccesoDatos.DevolverUltimoInsert();
            Categoria top = AccesoDatos.DevolverCategoria("Top");
            Categoria bottom = AccesoDatos.DevolverCategoria("Bottom");
            Categoria accesories = AccesoDatos.DevolverCategoria("Accesories");
            Categoria shoes = AccesoDatos.DevolverCategoria("Shoes");
            Prenda p_top = new Prenda(txtNameTop.Text, txtLinkTop.Text, img, top);
            Prenda p_bottom = new Prenda(txtNameBottom.Text, txtLinkBottom.Text, img, bottom);
            Prenda p_accesories = new Prenda(txtNameAccesories.Text, txtLinkAccesories.Text, img, accesories);
            Prenda p_shoes = new Prenda(txtNameShoes.Text, txtLinkShoes.Text, img, shoes);
            if (txtNameTop.Text != "" && txtLinkTop.Text != "") {
                AccesoDatos.AgregarPrenda(p_top);
            }
            if (txtNameBottom.Text != "" && txtLinkBottom.Text != "") {
                AccesoDatos.AgregarPrenda(p_bottom);
            }
            if (txtNameAccesories.Text != "" && txtLinkAccesories.Text != "") {
                AccesoDatos.AgregarPrenda(p_accesories);
            }
            if (txtNameShoes.Text != "" && txtLinkShoes.Text != "") {
                AccesoDatos.AgregarPrenda(p_shoes);
            }
        }

        private void btnSubirFoto_Click_1(object sender, EventArgs e) {
            using (var pEspera = new PantallaEspera(SubirFoto)) {
                pEspera.ShowDialog(this);
                this.Close();
                caller.Refresh();
                caller.Show();
            }
        }

        private void ptbInicio_Click(object sender, EventArgs e) {
            caller.Show();
            this.Close();
        }

        private void lblCerrar_Click(object sender, EventArgs e) {
            caller.Show();
            this.Close();
        }

		private void lblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.FromArgb(247, 247, 247);
		}

		private void lblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.White;
		}

        private void picPerfil_Click(object sender, EventArgs e) {
            Perfil p1 = new Perfil(this.caller);
            this.Close();
            p1.Show();
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
            picLikes.BackgroundImage = Resources.perfil_gris;
        }

        private void picPerfil_MouseLeave(object sender, EventArgs e) {
            picLikes.BackgroundImage = Resources.perfil_blanco;
        }

        private void picSubir_MouseEnter(object sender, EventArgs e) {
            picSubir.BackgroundImage = Resources.camara_gris;
        }

        private void picSubir_MouseLeave(object sender, EventArgs e) {
            picSubir.BackgroundImage = Resources.camara_blanca;
        }
    }
}
