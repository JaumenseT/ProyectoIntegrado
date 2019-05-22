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

namespace RedBeetle.Forms_bueno {
    public partial class AgregarImagen : Form {

		Form caller;
		string nombreUsuario;
        byte[] imagen = null;

        public AgregarImagen(string nomUsu, Form caller) {
            this.caller = caller;
            nombreUsuario = nomUsu;
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
            Usuario usu = AccesoDatos.DevolverUsuario(nombreUsuario);
            AccesoDatos.AgregarImagen(new Imagen(txtDescripcion.Text, imagen, usu.Id_Usuario));
            int img = AccesoDatos.DevolverUltimoInsert();
            Categoria top = AccesoDatos.DevolverCategoria("Top");
            Categoria bottom = AccesoDatos.DevolverCategoria("Bottom");
            Categoria accesories = AccesoDatos.DevolverCategoria("Accesories");
            Categoria shoes = AccesoDatos.DevolverCategoria("Shoes");
            Prenda p_top = new Prenda(txtNameTop.Text, txtLinkTop.Text, img, top);
            Prenda p_bottom = new Prenda(txtNameBottom.Text, txtLinkBottom.Text, img, bottom);
            Prenda p_accesories = new Prenda(txtNameAccesories.Text, txtLinkAccesories.Text, img, accesories);
            Prenda p_shoes = new Prenda(txtNameShoes.Text, txtLinkShoes.Text, img, shoes);
            AccesoDatos.AgregarPrenda(p_top);
            AccesoDatos.AgregarPrenda(p_bottom);
            AccesoDatos.AgregarPrenda(p_accesories);
            AccesoDatos.AgregarPrenda(p_shoes);
        }

        private void btnSubirFoto_Click_1(object sender, EventArgs e) {
            using (var pEspera = new PantallaEspera(SubirFoto)) {
                pEspera.ShowDialog(this);
                this.Close();
                caller.Show();
            }
        }

        private void ptbInicio_Click(object sender, EventArgs e) {
            this.Close();
            caller.Close();
        }

        private void lblCerrar_Click(object sender, EventArgs e) {
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

        private void AgregarImagen_FormClosed(object sender, FormClosedEventArgs e) {
            caller.Show();
        }
    }
}
