using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBeetle.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
