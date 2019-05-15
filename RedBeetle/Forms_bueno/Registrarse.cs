using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBeetle
{
	public partial class Registrarse : Form
	{
		public Registrarse()
		{
			InitializeComponent();
		}

		private void lblCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnRegistrarse_Click(object sender, EventArgs e)
		{
			//Falta codigo esto va al final
			var formInicio = new InicioSesion();
			formInicio.Show();
			Close();
		}
	}
}
