﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedBeetle.Forms_bueno
{
    public partial class Cambiar_Contraseña : Form
    {
        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
