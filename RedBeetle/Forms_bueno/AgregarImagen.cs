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
        Home h1;
        Perfil p1;
        public AgregarImagen(Home caller) {
            h1 = caller;
            InitializeComponent();
        }
    
        public AgregarImagen(Perfil caller) {
            p1 = caller;
            InitializeComponent();
        }

        /*private void btnSubirFoto_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)| All Files(*.*)|*.*|";

            if (dialog.ShowDialog() == DialogResult.OK) {
                string picPath = dialog.FileName.ToString();
                pbFoto.ImageLocation = picPath;
            }
            Imagen newImage = new Imagen(txtDescripcion.Text, )
        }*/
    }
}
