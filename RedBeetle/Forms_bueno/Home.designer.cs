namespace RedBeetle.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbLupa = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.ptbCamara = new System.Windows.Forms.PictureBox();
            this.ptbLike = new System.Windows.Forms.PictureBox();
            this.ptbPerfil = new System.Windows.Forms.PictureBox();
            this.ptbInicio = new System.Windows.Forms.PictureBox();
            this.llbUsuario = new System.Windows.Forms.LinkLabel();
            this.dgvListaSeguidos = new System.Windows.Forms.DataGridView();
            this.Personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.picLogoBeetle = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.ptbFavorito1 = new System.Windows.Forms.PictureBox();
            this.ptbFavorito2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSeguidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBeetle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorito1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorito2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblCerrar);
            this.panel1.Controls.Add(this.ptbLupa);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Controls.Add(this.ptbCamara);
            this.panel1.Controls.Add(this.ptbLike);
            this.panel1.Controls.Add(this.ptbPerfil);
            this.panel1.Controls.Add(this.ptbInicio);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 133);
            this.panel1.TabIndex = 0;
            // 
            // ptbLupa
            // 
            this.ptbLupa.BackColor = System.Drawing.Color.White;
            this.ptbLupa.Image = ((System.Drawing.Image)(resources.GetObject("ptbLupa.Image")));
            this.ptbLupa.Location = new System.Drawing.Point(362, 69);
            this.ptbLupa.Name = "ptbLupa";
            this.ptbLupa.Size = new System.Drawing.Size(51, 45);
            this.ptbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLupa.TabIndex = 5;
            this.ptbLupa.TabStop = false;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(362, 69);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(269, 45);
            this.txtBuscador.TabIndex = 4;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbCamara
            // 
            this.ptbCamara.BackColor = System.Drawing.Color.Red;
            this.ptbCamara.Image = ((System.Drawing.Image)(resources.GetObject("ptbCamara.Image")));
            this.ptbCamara.Location = new System.Drawing.Point(866, 28);
            this.ptbCamara.Name = "ptbCamara";
            this.ptbCamara.Size = new System.Drawing.Size(81, 63);
            this.ptbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCamara.TabIndex = 3;
            this.ptbCamara.TabStop = false;
            // 
            // ptbLike
            // 
            this.ptbLike.BackColor = System.Drawing.Color.Red;
            this.ptbLike.Image = ((System.Drawing.Image)(resources.GetObject("ptbLike.Image")));
            this.ptbLike.Location = new System.Drawing.Point(666, 28);
            this.ptbLike.Name = "ptbLike";
            this.ptbLike.Size = new System.Drawing.Size(83, 63);
            this.ptbLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLike.TabIndex = 2;
            this.ptbLike.TabStop = false;
            // 
            // ptbPerfil
            // 
            this.ptbPerfil.BackColor = System.Drawing.Color.Red;
            this.ptbPerfil.Image = ((System.Drawing.Image)(resources.GetObject("ptbPerfil.Image")));
            this.ptbPerfil.Location = new System.Drawing.Point(771, 28);
            this.ptbPerfil.Name = "ptbPerfil";
            this.ptbPerfil.Size = new System.Drawing.Size(79, 63);
            this.ptbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPerfil.TabIndex = 1;
            this.ptbPerfil.TabStop = false;
            // 
            // ptbInicio
            // 
            this.ptbInicio.Image = ((System.Drawing.Image)(resources.GetObject("ptbInicio.Image")));
            this.ptbInicio.Location = new System.Drawing.Point(25, 12);
            this.ptbInicio.Name = "ptbInicio";
            this.ptbInicio.Size = new System.Drawing.Size(296, 92);
            this.ptbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbInicio.TabIndex = 0;
            this.ptbInicio.TabStop = false;
            // 
            // llbUsuario
            // 
            this.llbUsuario.AutoSize = true;
            this.llbUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbUsuario.LinkColor = System.Drawing.Color.Red;
            this.llbUsuario.Location = new System.Drawing.Point(827, 174);
            this.llbUsuario.Name = "llbUsuario";
            this.llbUsuario.Size = new System.Drawing.Size(100, 22);
            this.llbUsuario.TabIndex = 1;
            this.llbUsuario.TabStop = true;
            this.llbUsuario.Text = "Tu Usuario";
            // 
            // dgvListaSeguidos
            // 
            this.dgvListaSeguidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSeguidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personas});
            this.dgvListaSeguidos.Location = new System.Drawing.Point(788, 207);
            this.dgvListaSeguidos.Name = "dgvListaSeguidos";
            this.dgvListaSeguidos.ReadOnly = true;
            this.dgvListaSeguidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListaSeguidos.Size = new System.Drawing.Size(166, 342);
            this.dgvListaSeguidos.TabIndex = 2;
            // 
            // Personas
            // 
            this.Personas.HeaderText = "Gente a la que sigues";
            this.Personas.Name = "Personas";
            this.Personas.ReadOnly = true;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblCerrar.ForeColor = System.Drawing.Color.Black;
            this.lblCerrar.Location = new System.Drawing.Point(970, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(41, 49);
            this.lblCerrar.TabIndex = 11;
            this.lblCerrar.Text = "x";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // picLogoBeetle
            // 
            this.picLogoBeetle.BackColor = System.Drawing.Color.Transparent;
            this.picLogoBeetle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogoBeetle.BackgroundImage")));
            this.picLogoBeetle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogoBeetle.Location = new System.Drawing.Point(-2, 524);
            this.picLogoBeetle.Name = "picLogoBeetle";
            this.picLogoBeetle.Size = new System.Drawing.Size(41, 37);
            this.picLogoBeetle.TabIndex = 5;
            this.picLogoBeetle.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(992, 136);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 425);
            this.vScrollBar1.TabIndex = 6;
            // 
            // ptbFavorito1
            // 
            this.ptbFavorito1.BackColor = System.Drawing.Color.Red;
            this.ptbFavorito1.Location = new System.Drawing.Point(108, 207);
            this.ptbFavorito1.Name = "ptbFavorito1";
            this.ptbFavorito1.Size = new System.Drawing.Size(259, 267);
            this.ptbFavorito1.TabIndex = 7;
            this.ptbFavorito1.TabStop = false;
            // 
            // ptbFavorito2
            // 
            this.ptbFavorito2.BackColor = System.Drawing.Color.Red;
            this.ptbFavorito2.Location = new System.Drawing.Point(433, 207);
            this.ptbFavorito2.Name = "ptbFavorito2";
            this.ptbFavorito2.Size = new System.Drawing.Size(259, 267);
            this.ptbFavorito2.TabIndex = 8;
            this.ptbFavorito2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.ptbFavorito2);
            this.Controls.Add(this.ptbFavorito1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.picLogoBeetle);
            this.Controls.Add(this.dgvListaSeguidos);
            this.Controls.Add(this.llbUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSeguidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBeetle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorito1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFavorito2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbCamara;
        private System.Windows.Forms.PictureBox ptbLike;
        private System.Windows.Forms.PictureBox ptbPerfil;
        private System.Windows.Forms.PictureBox ptbInicio;
        private System.Windows.Forms.PictureBox ptbLupa;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.LinkLabel llbUsuario;
        private System.Windows.Forms.DataGridView dgvListaSeguidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personas;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.PictureBox picLogoBeetle;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox ptbFavorito1;
        private System.Windows.Forms.PictureBox ptbFavorito2;
    }
}