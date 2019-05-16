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
        InicioSesion caller;
        public Home(InicioSesion caller)
        {
            this.caller = caller;
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            caller.Show();
        }

        private void Home_Load(object sender, EventArgs e) {
            lblUsuario.Text = caller.ObtenerUsuario();
        }

        private void ptbPerfil_Click(object sender, EventArgs e) {
            this.Hide();
            Forms_bueno.Perfil p1 = new Forms_bueno.Perfil(this);
            p1.Show();
        }

        public string ObtenerUsuario() {
            return lblUsuario.Text;
        }
    }
}
