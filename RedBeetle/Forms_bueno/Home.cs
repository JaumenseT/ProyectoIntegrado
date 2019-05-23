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
	    Usuario user;
		List<string> usuarios = new List<string>();
        List<byte[]> imagenesByte = null;
        List<Image> listaImagenes = null;
		int longitudAtras = 0;
		int longitudSiguiente = 0;

        public Home(Form caller, List<byte[]> imagenByte, List<Image> listaImagenes)
        {
            this.caller = caller;

            this.imagenesByte = imagenByte;
            this.listaImagenes = listaImagenes;
			//longitudAtras = listaImagenes.Count;

            InitializeComponent();
			user = Aplicacion.User;   
        }

		private void Home_Load(object sender, EventArgs e) {
			lblUsuario.Text = user.Nombre_usuario;
            picUsuario.Image = Imagen.ConvertirImagen(user.Foto_Perfil);

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
					pic1.BackgroundImage = listaImagenes[0];
				}
				if (pic2.BackgroundImage == null)
				{
					pic2.BackgroundImage = listaImagenes[1];
				}
            }
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

        private void lblUsuario_Click(object sender, EventArgs e)
		{
            Hide();
            Perfil p1 = new Perfil(this);
            p1.Show();
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
            Perfil p1 = new Perfil(this.caller);
            p1.Show();
            this.Hide();
        }

        private void picUsuario_Click(object sender, EventArgs e) {
            Perfil p1 = new Perfil(this.caller);
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
				imagenesByte = AccesoDatos.DevolverImagenes(txtBuscar.Text);
				listaImagenes = Imagen.ConvertirArrayAImagen(imagenesByte);

				var perfilUsuario = new PerfilUsuario(txtBuscar.Text, caller, imagenesByte, listaImagenes);
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
					pic1.BackgroundImage = listaImagenes[longitudAtras - 1];
					longitudAtras--;
					longitudSiguiente--;
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
					pic2.BackgroundImage = listaImagenes[longitudSiguiente + 2];
					longitudSiguiente++;
					longitudAtras++;
				}
			}
		}
	}
}
