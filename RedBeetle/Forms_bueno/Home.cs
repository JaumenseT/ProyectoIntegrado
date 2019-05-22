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
		//List<byte[]> imagenesByte = AccesoDatos.DevolverImagenes(user.Nombre_usuario);
		//List<Image> listaImagenes = Imagen.ConvertirArrayAImagen(imagenesByte);

		public Home(Form caller)
        {
            this.caller = caller;
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
			var imagenesByte = AccesoDatos.DevolverImagenes(user.Nombre_usuario);
			var listaImagenes = Imagen.ConvertirArrayAImagen(imagenesByte);
            
            if (listaImagenes.Count > 0) {
                for (int i = 0; i < listaImagenes.Count; i++) {
                    try
                    {
						if(pic1.BackgroundImage == null)
						{
							pic1.BackgroundImage = listaImagenes[i];
						}
						if (pic2.BackgroundImage == null)
						{
							pic2.BackgroundImage = listaImagenes[i+1];
						}
                    }
                    catch {

                    }
                }
            }

		}

		//NO BORRAR ESTO, SE NECESITARA MAS ADELANTE PARA HACER PANTALLA DE CARGA
		private void RellenarSeguidos()
		{
			usuarios = AccesoDatos.DevolverNombresUsuario();
		}

		private void CrearFormPerfil()
		{
			Perfil p1 = new Perfil(this);
			p1.Show();
		}
		///Funcion para la pantalla de carga
		private void CrearFormSubirImagen()
		{
			var a = new AgregarImagen(this);
			a.Show();
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
			{   //Si es el enter hace la busqueda
				var perfilUsuario = new PerfilUsuario(txtBuscar.Text, caller);
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

        /*private void btnSiguiente_Click(object sender, EventArgs e) 
		{
			if (listaImagenes.Count > 0)
			{
				var longitud = listaImagenes.Count;

				if (longitud > 0)
				{
					pic2.BackgroundImage = pic1.BackGroundImage;
					pic1.BackGroundImage = longitud - 2;
					longitud--;
				}
			}
		}*/

        /*private void btnAtras_Click(object sender, EventArgs e) 
		{ 
			if (l.Count > 0)
			{
				var longitud = imagenes.Count;

				if (longitud > 0)
				{
					pic2.BackgroundImage = pic1.BackgroundImage;
					pic1.BackgroundImage = imagenes[longitud - 2];
					longitud--;
				}
			}
		}*/
    }
}
