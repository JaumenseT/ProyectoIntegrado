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
using RedBeetle.Properties;

namespace RedBeetle.Forms
{
    public partial class Home : Form
    {
        int offset = 0;
        Form caller;
	    Usuario user;
		List<string> usuarios = new List<string>();
        List<Imagen> listaImagenes = null;
        int longitudAtras = 0;
        int longitudSiguiente = 0;

        public Home(Form caller, List<Imagen> listaImagenes)
        {
            this.caller = caller;
            this.listaImagenes = listaImagenes;
			//longitudAtras = listaImagenes.Count;

            InitializeComponent();
			user = Aplicacion.User;   
        }

		private void Home_Load(object sender, EventArgs e) {
            RefrescarUsuario();

            //Para que conforme vayas buscando te salgan resultados en el textbox
            var nombres = AccesoDatos.DevolverNombresUsuario(); 
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

			//Rellenar picturebox

            if (listaImagenes.Count > 0)
			{
				if (pic1.BackgroundImage == null)
				{
					pic1.BackgroundImage = listaImagenes[0].NewImage;
				}
				if (pic2.BackgroundImage == null)
				{
					pic2.BackgroundImage = listaImagenes[1].NewImage;
				}
            }
		}

        public void RefrescarUsuario() {
            user = Aplicacion.User;
            lblUsuario.Text = user.Nombre_usuario;
            picUsuario.Image = Imagen.ConvertirImagen(user.Foto_Perfil);
        }

		//NO BORRAR ESTO, SE NECESITARA MAS ADELANTE PARA HACER PANTALLA DE CARGA
		private void RellenarSeguidos()
		{
			usuarios = AccesoDatos.DevolverNombresUsuario();
		}
		
		private void PicSubir_Click(object sender, EventArgs e)
		{
			/*using (var pEspera = new PantallaEspera(CrearFormSubirImagen))
			{
				pEspera.ShowDialog(this);
			}*/
			var a = new AgregarImagen(this);
			a.Show();
			Hide();
		}

		private void ptbPerfil_Click(object sender, EventArgs e)
		{
			/*using (var pEspera = new PantallaEspera(CrearFormPerfil))
			{
				pEspera.ShowDialog(this);
			}*/
            Perfil p1 = new Perfil(this);
			p1.Show();
			Hide();
        }

		private void TxtBuscar_Enter(object sender, EventArgs e)
		{
			picLupa.Hide();
		}

        private void TxtBuscar_Leave(object sender, EventArgs e)
		{
            txtBuscar.Hint = "     Buscar usuario...";
			if(txtBuscar.Text == "") picLupa.Show();
        }

		private void PicLikes_Click(object sender, EventArgs e)
		{
			
		}

		private void lblCerrar_Click_1(object sender, EventArgs e)
		{
			this.Close();
            caller.Show();
		}

		private void LblCerrar_MouseEnter(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.Silver;
		}

		private void LblCerrar_MouseLeave(object sender, EventArgs e)
		{
			lblCerrar.ForeColor = Color.White;
		}

        private void lblUsuario_Click_1(object sender, EventArgs e) {
            Perfil p1 = new Perfil(this);
            p1.Show();
            this.Hide();
        }

        private void picUsuario_Click(object sender, EventArgs e) {
            Perfil p1 = new Perfil(this);
            p1.Show();
            this.Hide();
        }

		private void EjecutarBusqueda()
		{
			var listaUsuarios = AccesoDatos.DevolverNombresUsuario();
			var esta = false;

			foreach (string elem in listaUsuarios)
			{
				if (txtBuscar.Text == elem)
				{
					esta = true;
				}
			}

			if (txtBuscar.Text == "")
			{
				//Si intentas buscar con el campo vacio no haces nada
			}
			else if (esta) //Si el nombre de usuario suministrado por el txtbox existe en la base de datos, procedes
			{   
				listaImagenes = AccesoDatos.DevolverImagenes(txtBuscar.Text);

				var perfilUsuario = new PerfilUsuario(txtBuscar.Text, this, listaImagenes);
				perfilUsuario.Show();
			}
		}

		private void BtnBuscar_Click(object sender, EventArgs e)
		{
			EjecutarBusqueda();
			/*using( var pEspera = new PantallaEspera(EjecutarBusqueda))
			{
				pEspera.ShowDialog(this);
			}*/
			if (txtBuscar.Text != "" && txtBuscar.Hint == "") Hide();
		}
		
		private void BtnAtras_Click_1(object sender, EventArgs e)
		{
			if (listaImagenes.Count > 0)
			{
				if (longitudAtras > 0)
				{
					pic2.BackgroundImage = pic1.BackgroundImage;
					pic1.BackgroundImage = listaImagenes[longitudAtras - 1].NewImage;
					longitudAtras--;
					longitudSiguiente--;
                    offset--;
				}
			}
		}

		private void BtnSiguiente_Click(object sender, EventArgs e)
		{
			if (listaImagenes.Count > 0)
			{
				if (longitudSiguiente < listaImagenes.Count - 2)
				{
					pic1.BackgroundImage = pic2.BackgroundImage;
					pic2.BackgroundImage = listaImagenes[longitudSiguiente + 2].NewImage;
					longitudSiguiente++;
					longitudAtras++;
                    offset++;
				}
			}
		}

        // Hovers del form

        private void PicLogo_MouseEnter(object sender, EventArgs e) {
            picLogo.BackgroundImage = Resources.beetle_gris;
        }

        private void PicLogo_MouseLeave(object sender, EventArgs e) {
            picLogo.BackgroundImage = Resources.beetle_blanco;
        }
        private void picLove1_MouseEnter(object sender, EventArgs e) {
            picLove1.BackgroundImage = Resources.corazon_relleno;
        }

        private void picLove1_MouseLeave(object sender, EventArgs e) {
            picLove1.BackgroundImage = Resources.corazon_rojo;
        }

        private void picLove2_MouseEnter(object sender, EventArgs e) {
            picLove2.BackgroundImage = Resources.corazon_relleno;
        }

        private void picLove2_MouseLeave(object sender, EventArgs e) {
            picLove2.BackgroundImage = Resources.corazon_rojo;
        }

        private void picPerfil_MouseEnter(object sender, EventArgs e) {
            picPerfil.BackgroundImage = Resources.perfil_gris;
        }

        private void picPerfil_MouseLeave(object sender, EventArgs e) {
            picPerfil.BackgroundImage = Resources.perfil_blanco;
        }

        private void picSubir_MouseEnter(object sender, EventArgs e) {
            picSubir.BackgroundImage = Resources.camara_gris;
        }

        private void picSubir_MouseLeave(object sender, EventArgs e) {
            picSubir.BackgroundImage = Resources.camara_blanca;
        }

        private void picLikes_MouseEnter(object sender, EventArgs e) {
            picLikes.BackgroundImage = Resources.corazon_gris;
        }

        private void picLikes_MouseLeave(object sender, EventArgs e) {
            picLikes.BackgroundImage = Resources.corazon_blanco;
        }

        // Onclick fotos

        private void AbrirFoto(int index) {
            if (index+offset < listaImagenes.Count) {
                FormImagen fm = new FormImagen(this, listaImagenes[index + offset]);
                fm.Show();
                this.Hide();
            }
        }
        private void pic1_Click(object sender, EventArgs e) {
            AbrirFoto(0);
        }

        private void pic2_Click(object sender, EventArgs e) {
            AbrirFoto(1);
        }
    }
}
