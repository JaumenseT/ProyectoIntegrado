namespace RedBeetle
{
	partial class Registrarse
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrarse));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.llbRegistro = new System.Windows.Forms.LinkLabel();
            this.lblYaTienesCuenta = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.picLogoBeetle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBeetle)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Location = new System.Drawing.Point(556, 81);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(289, 266);
            this.picLogo.TabIndex = 9;
            this.picLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(556, 380);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(288, 34);
            this.txtUsuario.TabIndex = 10;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(556, 423);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 34);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenya.Location = new System.Drawing.Point(556, 466);
            this.txtContrasenya.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(288, 34);
            this.txtContrasenya.TabIndex = 12;
            this.txtContrasenya.UseSystemPasswordChar = true;
            this.txtContrasenya.Enter += new System.EventHandler(this.txtContrasenya_Enter);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(556, 510);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(288, 34);
            this.txtCorreo.TabIndex = 13;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(556, 564);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(289, 48);
            this.btnRegistrarse.TabIndex = 15;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // llbRegistro
            // 
            this.llbRegistro.AutoSize = true;
            this.llbRegistro.BackColor = System.Drawing.Color.Transparent;
            this.llbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbRegistro.LinkColor = System.Drawing.Color.Maroon;
            this.llbRegistro.Location = new System.Drawing.Point(1243, 705);
            this.llbRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbRegistro.Name = "llbRegistro";
            this.llbRegistro.Size = new System.Drawing.Size(113, 24);
            this.llbRegistro.TabIndex = 17;
            this.llbRegistro.TabStop = true;
            this.llbRegistro.Text = "Inicia sesión";
            this.llbRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRegistro_LinkClicked);
            // 
            // lblYaTienesCuenta
            // 
            this.lblYaTienesCuenta.AutoSize = true;
            this.lblYaTienesCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblYaTienesCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaTienesCuenta.Location = new System.Drawing.Point(1029, 705);
            this.lblYaTienesCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYaTienesCuenta.Name = "lblYaTienesCuenta";
            this.lblYaTienesCuenta.Size = new System.Drawing.Size(206, 24);
            this.lblYaTienesCuenta.TabIndex = 16;
            this.lblYaTienesCuenta.Text = "¿Ya tienes una cuenta?";
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.lblCerrar.Location = new System.Drawing.Point(1312, -6);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(51, 61);
            this.lblCerrar.TabIndex = 18;
            this.lblCerrar.Text = "x";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // picLogoBeetle
            // 
            this.picLogoBeetle.BackColor = System.Drawing.Color.Transparent;
            this.picLogoBeetle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogoBeetle.BackgroundImage")));
            this.picLogoBeetle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogoBeetle.Location = new System.Drawing.Point(16, 678);
            this.picLogoBeetle.Margin = new System.Windows.Forms.Padding(4);
            this.picLogoBeetle.Name = "picLogoBeetle";
            this.picLogoBeetle.Size = new System.Drawing.Size(55, 46);
            this.picLogoBeetle.TabIndex = 19;
            this.picLogoBeetle.TabStop = false;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1365, 738);
            this.Controls.Add(this.picLogoBeetle);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.llbRegistro);
            this.Controls.Add(this.lblYaTienesCuenta);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContrasenya);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Registrarse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBeetle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtContrasenya;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Button btnRegistrarse;
		private System.Windows.Forms.LinkLabel llbRegistro;
		private System.Windows.Forms.Label lblYaTienesCuenta;
		private System.Windows.Forms.Label lblCerrar;
		private System.Windows.Forms.PictureBox picLogoBeetle;
	}
}