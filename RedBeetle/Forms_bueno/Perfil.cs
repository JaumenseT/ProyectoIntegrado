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
        Home caller;
        public Perfil(Home caller)
        {
            this.caller = caller;
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            caller.Show();
        }

        private void Usuario_Load(object sender, EventArgs e) {
            txtNombre.Text = AccesoDatos.DevolverUsuario(caller.ObtenerNombreUsuario()).NombreUsuario;
        }
    }
}
