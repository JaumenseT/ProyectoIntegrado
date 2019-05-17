namespace RedBeetle {
    partial class InicioSesion {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picLogoBeetle = new System.Windows.Forms.PictureBox();
            this.lblNoTienesCuenta = new System.Windows.Forms.Label();
            this.lblContraseñaOlvidada = new System.Windows.Forms.LinkLabel();
            this.llbRegistro = new System.Windows.Forms.LinkLabel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblCerrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBeetle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(556, 404);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(288, 34);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenya.Location = new System.Drawing.Point(556, 481);
            this.txtContrasenya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(288, 34);
            this.txtContrasenya.TabIndex = 2;
            this.txtContrasenya.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(556, 559);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(289, 48);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // picLogoBeetle
            // 
            this.picLogoBeetle.BackColor = System.Drawing.Color.Transparent;
            this.picLogoBeetle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogoBeetle.BackgroundImage")));
            this.picLogoBeetle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogoBeetle.Location = new System.Drawing.Point(16, 678);
            this.picLogoBeetle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogoBeetle.Name = "picLogoBeetle";
            this.picLogoBeetle.Size = new System.Drawing.Size(55, 46);
            this.picLogoBeetle.TabIndex = 4;
            this.picLogoBeetle.TabStop = false;
            // 
            // lblNoTienesCuenta
            // 
            this.lblNoTienesCuenta.AutoSize = true;
            this.lblNoTienesCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTienesCuenta.Location = new System.Drawing.Point(1044, 705);
            this.lblNoTienesCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoTienesCuenta.Name = "lblNoTienesCuenta";
            this.lblNoTienesCuenta.Size = new System.Drawing.Size(209, 24);
            this.lblNoTienesCuenta.TabIndex = 5;
            this.lblNoTienesCuenta.Text = "¿No tienes una cuenta?";
            // 
            // lblContraseñaOlvidada
            // 
            this.lblContraseñaOlvidada.AutoSize = true;
            this.lblContraseñaOlvidada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaOlvidada.LinkColor = System.Drawing.Color.Maroon;
            this.lblContraseñaOlvidada.Location = new System.Drawing.Point(552, 521);
            this.lblContraseñaOlvidada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaOlvidada.Name = "lblContraseñaOlvidada";
            this.lblContraseñaOlvidada.Size = new System.Drawing.Size(204, 18);
            this.lblContraseñaOlvidada.TabIndex = 6;
            this.lblContraseñaOlvidada.TabStop = true;
            this.lblContraseñaOlvidada.Text = "¿Has olvidado tu contraseña?";
            // 
            // llbRegistro
            // 
            this.llbRegistro.AutoSize = true;
            this.llbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRegistro.LinkColor = System.Drawing.Color.Maroon;
            this.llbRegistro.Location = new System.Drawing.Point(1261, 705);
            this.llbRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbRegistro.Name = "llbRegistro";
            this.llbRegistro.Size = new System.Drawing.Size(93, 24);
            this.llbRegistro.TabIndex = 7;
            this.llbRegistro.TabStop = true;
            this.llbRegistro.Text = "Registrate";
            this.llbRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRegistro_LinkClicked);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Location = new System.Drawing.Point(556, 81);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(289, 266);
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(552, 443);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 18);
            this.linkLabel1.TabIndex = 9;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.lblCerrar.Location = new System.Drawing.Point(1312, -6);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(51, 61);
            this.lblCerrar.TabIndex = 10;
            this.lblCerrar.Text = "x";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 738);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.llbRegistro);
            this.Controls.Add(this.lblContraseñaOlvidada);
            this.Controls.Add(this.lblNoTienesCuenta);
            this.Controls.Add(this.picLogoBeetle);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtContrasenya);
            this.Controls.Add(this.txtNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBeetle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox picLogoBeetle;
        private System.Windows.Forms.Label lblNoTienesCuenta;
        private System.Windows.Forms.LinkLabel lblContraseñaOlvidada;
        private System.Windows.Forms.LinkLabel llbRegistro;
		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label lblCerrar;
	}
}

