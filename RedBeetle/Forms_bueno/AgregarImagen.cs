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

        private void btnSubirFoto_Click_1(object sender, EventArgs e) {
            Usuario usu = AccesoDatos.DevolverUsuario(nombreUsuario);
            AccesoDatos.AgregarImagen(new Imagen(txtDescripcion.Text, imagen, usu.Id_Usuario));
        }

        private void ptbInicio_Click(object sender, EventArgs e) {
            caller.Show();
            this.Close();
        }

        private void lblCerrar_Click(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }
    }
}
