namespace RDGweb
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TbxUser = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnInicioSesion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LklRegistro = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxUser
            // 
            this.TbxUser.BackColor = System.Drawing.Color.White;
            this.TbxUser.Location = new System.Drawing.Point(97, 212);
            this.TbxUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxUser.Name = "TbxUser";
            this.TbxUser.Size = new System.Drawing.Size(193, 22);
            this.TbxUser.TabIndex = 1;
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.Color.White;
            this.TbxPassword.Location = new System.Drawing.Point(97, 270);
            this.TbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(193, 22);
            this.TbxPassword.TabIndex = 2;
            this.TbxPassword.TextChanged += new System.EventHandler(this.TbxPassword_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 186);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(97, 188);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(129, 19);
            this.LblUser.TabIndex = 4;
            this.LblUser.Text = "Ingrese su usuario";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(97, 247);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(155, 19);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Ingrese su Contraseña";
            // 
            // BtnInicioSesion
            // 
            this.BtnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicioSesion.Location = new System.Drawing.Point(135, 316);
            this.BtnInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInicioSesion.Name = "BtnInicioSesion";
            this.BtnInicioSesion.Size = new System.Drawing.Size(117, 25);
            this.BtnInicioSesion.TabIndex = 6;
            this.BtnInicioSesion.Text = "Iniciar Sesión";
            this.BtnInicioSesion.UseVisualStyleBackColor = true;
            this.BtnInicioSesion.Click += new System.EventHandler(this.BtnInicioSesion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(49, 248);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            // 
            // LklRegistro
            // 
            this.LklRegistro.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.LklRegistro.AutoSize = true;
            this.LklRegistro.BackColor = System.Drawing.Color.Transparent;
            this.LklRegistro.LinkColor = System.Drawing.Color.White;
            this.LklRegistro.Location = new System.Drawing.Point(145, 443);
            this.LklRegistro.Name = "LklRegistro";
            this.LklRegistro.Size = new System.Drawing.Size(81, 16);
            this.LklRegistro.TabIndex = 10;
            this.LklRegistro.TabStop = true;
            this.LklRegistro.Text = "Registrarme";
            this.LklRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklRegistro_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(117, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "¿No estás registtrado?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(78, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 72);
            this.label3.TabIndex = 13;
            this.label3.Text = "RDGweb";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LklRegistro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnInicioSesion);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxUser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxUser;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnInicioSesion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LklRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

