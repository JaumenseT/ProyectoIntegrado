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
using RedBeetle.Clases;
using RedBeetle.Forms_bueno;

namespace RedBeetle.Forms_bueno
{
    public partial class Perfil : Form
    {
        Form caller;
		string nombreUsuario;
        public Perfil(string nomUsu, Form caller)
        {
            this.caller = caller;
            nombreUsuario = nomUsu;
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Usuario_Load(object sender, EventArgs e) {
            lblNombre.Text = AccesoDatos.DevolverUsuario(nombreUsuario).Nombre_usuario;
        }

        private void lblCerrar_Click_1(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }

        private void picInicio_Click(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }

		private void btnModificar_Click(object sender, EventArgs e)
		{
			var m = new Modificar_Usuario(nombreUsuario, this);
			m.Show();
			this.Hide();
		}

		private void lblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.FromArgb(247, 247, 247);
		}

		private void lblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.White;
		}

        private void ptbCamara2_Click(object sender, EventArgs e) {
            var a = new AgregarImagen(nombreUsuario, this);
            a.Show();
            this.Hide();
        }

        private void picSubir_Click(object sender, EventArgs e) {
            var a = new AgregarImagen(nombreUsuario, this);
            a.Show();
            this.Hide();
        }

		private void ptbAjustes_Click(object sender, EventArgs e)
		{

		}

		private void ptbFavoritos_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{

		}
	}
}
