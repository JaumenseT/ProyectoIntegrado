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
using RedBeetle.Forms;

namespace RedBeetle.Forms_bueno
{
    public partial class Modificar_Usuario : Form
    {
		Home callerHome;
		InicioSesion callerLogin;
        public Modificar_Usuario()
        {
            InitializeComponent();
        }
        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.BackColor = Color.White;
		}

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.BackColor = Color.FromArgb(247, 247, 247);
		}

		/*private void PicInicio_Click(object sender, EventArgs e)
		{
			var home = new Home(callerLogin);
			home.Show();
			Close();
		}*/

		private void PicLikes_Click(object sender, EventArgs e)
		{

		}

		/*private void PicPerfil_Click(object sender, EventArgs e)
		{
			var perfil = new Perfil(callerHome);

		}*/

		/*private void PicSubir_Click(object sender, EventArgs e)
		{
			var f = new AgregarImagen(callerHome);
		}*/
	}
}
