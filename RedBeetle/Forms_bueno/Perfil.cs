﻿using System;
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
        Form caller;
		string nombreUsuario;
        public Perfil(string nomUsu, Form caller)
        {
            this.caller = caller;
            nombreUsuario = nomUsu;
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Usuario_Load(object sender, EventArgs e) {
            txtNombre.Text = AccesoDatos.DevolverUsuario(nombreUsuario).Nombre_usuario;
        }

        private void lblCerrar_Click_1(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }

        private void picInicio_Click(object sender, EventArgs e) {
            this.Close();
            caller.Show();
        }
    }
}
