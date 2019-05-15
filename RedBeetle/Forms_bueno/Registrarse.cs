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

namespace RedBeetle
{
	public partial class Registrarse : Form
	{
		public Registrarse()
		{
			InitializeComponent();
		}

        private void Registrarse_Load(object sender, EventArgs e) {
            txtUsuario.Text = "Nombre de Usuario";
            txtNombre.Text = "Nombre";
            txtContrasenya.Text = "Contraseña";
            txtCorreo.Text = "Correo";
        }

        private void lblCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
            //Falta codigo esto va al final
            Usuario usu = new Usuario(txtUsuario.Text, txtNombre.Text, txtContrasenya.Text, txtCorreo.Text);
            AccesoDatos.AgregarEmpleado(usu);
			var formInicio = new InicioSesion();
			formInicio.Show();
			this.Close();
		}

        
    }
}
