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
using RedBeetle.Clases;

namespace RedBeetle.Forms_bueno {
    public partial class FormImagen : Form {
        private Form caller;
        private Imagen imagen;
        private Prenda p_top, p_bottom, p_accesories, p_shoes;

        public FormImagen(Form caller, Imagen imagen) {
            this.caller = caller;
            this.imagen = imagen;
            InitializeComponent();
        }

        private void FormImagen_Load(object sender, EventArgs e) {
            picImagen.Image = imagen.NewImage;
            Usuario user = AccesoDatos.DevolverUsuario(imagen.IdUsuario);
            lblUsuario.Text = user.Nombre_usuario;
            picUsuario.Image = Imagen.ConvertirImagen(user.Foto_Perfil);
            txtDescripcion.Text = imagen.Descripcion;
            p_top = AccesoDatos.DevolverPrenda(imagen.Id_Imagen, 1);
            p_bottom = AccesoDatos.DevolverPrenda(imagen.Id_Imagen, 2);
            p_accesories = AccesoDatos.DevolverPrenda(imagen.Id_Imagen, 3);
            p_shoes = AccesoDatos.DevolverPrenda(imagen.Id_Imagen, 4);
            if (p_top != null && p_top.Nombre != null) {
                txtNameTop.Text = p_top.Nombre;
            }
            if (p_bottom != null && p_bottom.Nombre != null) {
                txtNameBottom.Text = p_bottom.Nombre;
            }
            if (p_accesories != null && p_accesories.Nombre != null) {
                txtNameAccesories.Text = p_accesories.Nombre;
            }
            if (p_shoes != null && p_shoes.Nombre != null) {
                txtNameShoes.Text = p_shoes.Nombre;
            }             
        }


        // Hovers del form

        private void picInicio_MouseEnter(object sender, EventArgs e) {
            picInicio.BackgroundImage = Resources.beetle_gris;
        }

        private void picInicio_MouseLeave(object sender, EventArgs e) {
            picInicio.BackgroundImage = Resources.beetle_blanco;
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

        private void lblCerrar_Click(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }

        private void picEnlace1_Click(object sender, EventArgs e) {
            if (p_top != null && p_top.Link != null && p_top.Link != "") {
                System.Diagnostics.Process.Start(p_top.Link);
            }               
        }

        private void picEnlace2_Click(object sender, EventArgs e) {
            if (p_bottom != null && p_bottom.Link != null && p_bottom.Link != "") {
                System.Diagnostics.Process.Start(p_bottom.Link);
            }
        }

        private void picEnlace3_Click(object sender, EventArgs e) {
            if (p_accesories != null && p_accesories.Link != null && p_accesories.Link != "") {
                System.Diagnostics.Process.Start(p_accesories.Link);
            }
        }

        private void picEnlace4_Click(object sender, EventArgs e) {
            if (p_shoes != null && p_shoes.Link != null && p_shoes.Link != "") {
                System.Diagnostics.Process.Start(p_shoes.Link);
            }
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
