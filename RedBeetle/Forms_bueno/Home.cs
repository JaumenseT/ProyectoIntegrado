using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedBeetle.Forms_bueno;
using RedBeetle.Clases;

namespace RedBeetle.Forms
{
    public partial class Home : Form
    {
        Form caller;
		string nombreUsuario;
		List<string> usuarios = new List<string>();

        public Home(string nomUsu, Form caller)
        {
            this.caller = caller;
            InitializeComponent();
			nombreUsuario = nomUsu;
        }

		private void Home_Load(object sender, EventArgs e) {
            var usu = AccesoDatos.DevolverUsuario(nombreUsuario);
			lblUsuario.Text = usu.Nombre_usuario;

			var nombres = AccesoDatos.DevolverNombresUsuario(); //Para que conforme vayas buscando te salgan resultados en el textbox
			var lista = new AutoCompleteStringCollection();

			foreach(string elem in nombres)
			{
				lista.Add(elem);
			}
			txtBuscar.AutoCompleteCustomSource = lista;

			//Formato para el datagridview
			dgvListaSeguidos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 219, 219);
			dgvListaSeguidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			dgvListaSeguidos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
			dgvListaSeguidos.DefaultCellStyle.SelectionForeColor = Color.White;

			dgvListaSeguidos.EnableHeadersVisualStyles = false;
			dgvListaSeguidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

			RellenarSeguidos(); //Rellenar el datagrid
			foreach(string elem in usuarios)
			{
				dgvListaSeguidos.Rows.Add(elem);
			}
			dgvListaSeguidos.ClearSelection();
		}
		//NO BORRAR ESTO, SE NECESITARA MAS ADELANTE PARA HACER PANTALLA DE CARGA
		private void RellenarSeguidos()
		{
			usuarios = AccesoDatos.DevolverNombresUsuario();
		}

        private void ptbPerfil_Click(object sender, EventArgs e) {
            this.Hide();
            Perfil p1 = new Perfil(nombreUsuario, this);
            p1.Show();
        }

        private void ptbCamara_Click(object sender, EventArgs e) {
            AgregarImagen agregar = new AgregarImagen(nombreUsuario,this);
            this.Hide();
            agregar.Show();
        }

        public string ObtenerNombreUsuario() {
            return lblUsuario.Text;
        }

        private void ptbLike_Click(object sender, EventArgs e) {

        }

        private void lblUsuario_Click(object sender, EventArgs e) {
            this.Hide();
            Perfil p1 = new Perfil(nombreUsuario, this);
            p1.Show();
        }

		private void TxtBuscar_Enter(object sender, EventArgs e)
		{
			picLupa.Hide();
		}

        private void TxtBuscar_Leave(object sender, EventArgs e) {
            txtBuscar.Hint = "     Buscar usuario...";
            picLupa.Show();
        }

		//Inacabado
		private void PicLogo_MouseEnter(object sender, EventArgs e)
		{
			//picLogo.BackgroundImage = Image.FromFile("Logo_nombre_gris.png");
		}

		private void PicLogo_MouseLeave(object sender, EventArgs e)
		{
			//picLogo.BackgroundImage = Image.FromFile("Logo_nombre_blanco.png");
		}

		private void PicLikes_Click(object sender, EventArgs e)
		{
			
		}

		private void lblCerrar_Click_1(object sender, EventArgs e)
		{
			var login = new InicioSesion();
			login.Show();
			Close();
		}

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.BackColor = Color.FromArgb(247, 247, 247);
		}

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.BackColor = Color.White;
		}

		/*private void PicPerfil_Click(object sender, EventArgs e)
		{
			var p = new Perfil(nombreUsuario);
			p.Show();
			Close();
		}*/

		private void PicSubir_Click(object sender, EventArgs e)
		{
			var a = new AgregarImagen(nombreUsuario, caller);
			a.Show();
			Close();
		}
	}
}
