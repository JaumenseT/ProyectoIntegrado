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
        ConexionBD conexionBD;
        InicioSesion caller;
        public Home(InicioSesion caller)
        {
            this.caller = caller;
            InitializeComponent();
        }


        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            caller.Show();
        }

        private void Home_Load(object sender, EventArgs e) {
            lblUsuario.Text = AccesoDatos.DevolverUsuario(conexionBD.Conexion, caller.).NombreUsuario;
        }

        private void ptbPerfil_Click(object sender, EventArgs e) {
            this.Hide();
            Perfil p1 = new Perfil(this);
            p1.Show();
        }

        private void ptbCamara_Click(object sender, EventArgs e) {
            AgregarImagen agregar = new AgregarImagen(this);
            this.Hide();
            agregar.Show();
        }
    }
}
