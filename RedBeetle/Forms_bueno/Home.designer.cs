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
            this.lblCerrar = new System.Windows.Forms.Label();
            this.ptbLupa = new System.Windows.Forms.PictureBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.ptbCamara = new System.Windows.Forms.PictureBox();
            this.ptbLike = new System.Windows.Forms.PictureBox();
            this.ptbPerfil = new System.Windows.Forms.PictureBox();
            this.ptbInicio = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.LinkLabel();
            this.dgvListaSeguidos = new System.Windows.Forms.DataGridView();
            this.Personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 137);
            this.panel1.TabIndex = 0;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblCerrar.ForeColor = System.Drawing.Color.Black;
            this.lblCerrar.Location = new System.Drawing.Point(1293, 0);
            this.lblCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(51, 61);
            this.lblCerrar.TabIndex = 11;
            this.lblCerrar.Text = "x";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // ptbLupa
            // 
            this.ptbLupa.BackColor = System.Drawing.Color.White;
            this.ptbLupa.Image = ((System.Drawing.Image)(resources.GetObject("ptbLupa.Image")));
            this.ptbLupa.Location = new System.Drawing.Point(527, 45);
            this.ptbLupa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbLupa.Name = "ptbLupa";
            this.ptbLupa.Size = new System.Drawing.Size(33, 34);
            this.ptbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLupa.TabIndex = 5;
            this.ptbLupa.TabStop = false;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(510, 38);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscador.Multiline = true;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(415, 46);
            this.txtBuscador.TabIndex = 4;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbCamara
            // 
            this.ptbCamara.BackColor = System.Drawing.Color.Red;
            this.ptbCamara.Image = ((System.Drawing.Image)(resources.GetObject("ptbCamara.Image")));
            this.ptbCamara.Location = new System.Drawing.Point(1194, 35);
            this.ptbCamara.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbCamara.Name = "ptbCamara";
            this.ptbCamara.Size = new System.Drawing.Size(73, 56);
            this.ptbCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCamara.TabIndex = 3;
            this.ptbCamara.TabStop = false;
            // 
            // ptbLike
            // 
            this.ptbLike.BackColor = System.Drawing.Color.Red;
            this.ptbLike.Image = ((System.Drawing.Image)(resources.GetObject("ptbLike.Image")));
            this.ptbLike.Location = new System.Drawing.Point(984, 35);
            this.ptbLike.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbLike.Name = "ptbLike";
            this.ptbLike.Size = new System.Drawing.Size(79, 54);
            this.ptbLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLike.TabIndex = 2;
            this.ptbLike.TabStop = false;
            // 
            // ptbPerfil
            // 
            this.ptbPerfil.BackColor = System.Drawing.Color.Red;
            this.ptbPerfil.Image = ((System.Drawing.Image)(resources.GetObject("ptbPerfil.Image")));
            this.ptbPerfil.Location = new System.Drawing.Point(1092, 35);
            this.ptbPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbPerfil.Name = "ptbPerfil";
            this.ptbPerfil.Size = new System.Drawing.Size(79, 56);
            this.ptbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPerfil.TabIndex = 1;
            this.ptbPerfil.TabStop = false;
            this.ptbPerfil.Click += new System.EventHandler(this.ptbPerfil_Click);
            // 
            // ptbInicio
            // 
            this.ptbInicio.Image = ((System.Drawing.Image)(resources.GetObject("ptbInicio.Image")));
            this.ptbInicio.Location = new System.Drawing.Point(16, 4);
            this.ptbInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbInicio.Name = "ptbInicio";
            this.ptbInicio.Size = new System.Drawing.Size(395, 113);
            this.ptbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbInicio.TabIndex = 0;
            this.ptbInicio.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.LinkColor = System.Drawing.Color.Red;
            this.lblUsuario.Location = new System.Drawing.Point(1052, 224);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(128, 27);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.TabStop = true;
            this.lblUsuario.Text = "Tu Usuario";
            // 
            // dgvListaSeguidos
            // 
            this.dgvListaSeguidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSeguidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personas});
            this.dgvListaSeguidos.Location = new System.Drawing.Point(1051, 255);
            this.dgvListaSeguidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaSeguidos.Name = "dgvListaSeguidos";
            this.dgvListaSeguidos.ReadOnly = true;
            this.dgvListaSeguidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvListaSeguidos.Size = new System.Drawing.Size(221, 421);
            this.dgvListaSeguidos.TabIndex = 2;
            // 
            // Personas
            // 
            this.Personas.HeaderText = "Gente a la que sigues";
            this.Personas.Name = "Personas";
            this.Personas.ReadOnly = true;
            // 
            // picLogoBeetle
            // 
            this.picLogoBeetle.BackColor = System.Drawing.Color.Transparent;
            this.picLogoBeetle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogoBeetle.BackgroundImage")));
            this.picLogoBeetle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogoBeetle.Location = new System.Drawing.Point(-3, 645);
            this.picLogoBeetle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogoBeetle.Name = "picLogoBeetle";
            this.picLogoBeetle.Size = new System.Drawing.Size(55, 46);
            this.picLogoBeetle.TabIndex = 5;
            this.picLogoBeetle.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1318, 153);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 523);
            this.vScrollBar1.TabIndex = 6;
            // 
            // ptbFavorito1
            // 
            this.ptbFavorito1.BackColor = System.Drawing.Color.Red;
            this.ptbFavorito1.Location = new System.Drawing.Point(144, 255);
            this.ptbFavorito1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbFavorito1.Name = "ptbFavorito1";
            this.ptbFavorito1.Size = new System.Drawing.Size(345, 329);
            this.ptbFavorito1.TabIndex = 7;
            this.ptbFavorito1.TabStop = false;
            // 
            // ptbFavorito2
            // 
            this.ptbFavorito2.BackColor = System.Drawing.Color.Red;
            this.ptbFavorito2.Location = new System.Drawing.Point(577, 255);
            this.ptbFavorito2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbFavorito2.Name = "ptbFavorito2";
            this.ptbFavorito2.Size = new System.Drawing.Size(345, 329);
            this.ptbFavorito2.TabIndex = 8;
            this.ptbFavorito2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1344, 690);
            this.Controls.Add(this.ptbFavorito2);
            this.Controls.Add(this.ptbFavorito1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.picLogoBeetle);
            this.Controls.Add(this.dgvListaSeguidos);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
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
        private System.Windows.Forms.LinkLabel lblUsuario;
        private System.Windows.Forms.DataGridView dgvListaSeguidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personas;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.PictureBox picLogoBeetle;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox ptbFavorito1;
        private System.Windows.Forms.PictureBox ptbFavorito2;
    }
}