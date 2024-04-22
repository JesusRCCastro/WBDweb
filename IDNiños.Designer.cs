namespace RDGweb
{
    partial class IDNiños
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
            this.LblUser = new System.Windows.Forms.Label();
            this.ComBoxIDCliente = new System.Windows.Forms.ComboBox();
            this.TextBoxNombreNiño = new System.Windows.Forms.TextBox();
            this.TextBoxFechaNac = new System.Windows.Forms.TextBox();
            this.TextBoxEdad = new System.Windows.Forms.TextBox();
            this.TextBoxGenero = new System.Windows.Forms.TextBox();
            this.PicBoxFaceChild = new System.Windows.Forms.PictureBox();
            this.TextBoxNumContacto = new System.Windows.Forms.TextBox();
            this.TextBoxCliente_idCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBackMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFaceChild)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(42, 53);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(89, 16);
            this.LblUser.TabIndex = 6;
            this.LblUser.Text = "ID del Cliente ";
            // 
            // ComBoxIDCliente
            // 
            this.ComBoxIDCliente.FormattingEnabled = true;
            this.ComBoxIDCliente.Location = new System.Drawing.Point(150, 48);
            this.ComBoxIDCliente.Name = "ComBoxIDCliente";
            this.ComBoxIDCliente.Size = new System.Drawing.Size(124, 24);
            this.ComBoxIDCliente.TabIndex = 7;
            // 
            // TextBoxNombreNiño
            // 
            this.TextBoxNombreNiño.Location = new System.Drawing.Point(41, 84);
            this.TextBoxNombreNiño.Multiline = true;
            this.TextBoxNombreNiño.Name = "TextBoxNombreNiño";
            this.TextBoxNombreNiño.Size = new System.Drawing.Size(233, 24);
            this.TextBoxNombreNiño.TabIndex = 9;
            // 
            // TextBoxFechaNac
            // 
            this.TextBoxFechaNac.Location = new System.Drawing.Point(41, 127);
            this.TextBoxFechaNac.Multiline = true;
            this.TextBoxFechaNac.Name = "TextBoxFechaNac";
            this.TextBoxFechaNac.Size = new System.Drawing.Size(233, 24);
            this.TextBoxFechaNac.TabIndex = 10;
            // 
            // TextBoxEdad
            // 
            this.TextBoxEdad.Location = new System.Drawing.Point(268, 93);
            this.TextBoxEdad.Multiline = true;
            this.TextBoxEdad.Name = "TextBoxEdad";
            this.TextBoxEdad.Size = new System.Drawing.Size(131, 24);
            this.TextBoxEdad.TabIndex = 11;
            // 
            // TextBoxGenero
            // 
            this.TextBoxGenero.Location = new System.Drawing.Point(268, 50);
            this.TextBoxGenero.Multiline = true;
            this.TextBoxGenero.Name = "TextBoxGenero";
            this.TextBoxGenero.Size = new System.Drawing.Size(131, 24);
            this.TextBoxGenero.TabIndex = 12;
            // 
            // PicBoxFaceChild
            // 
            this.PicBoxFaceChild.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicBoxFaceChild.Location = new System.Drawing.Point(431, 28);
            this.PicBoxFaceChild.Name = "PicBoxFaceChild";
            this.PicBoxFaceChild.Size = new System.Drawing.Size(110, 105);
            this.PicBoxFaceChild.TabIndex = 13;
            this.PicBoxFaceChild.TabStop = false;
            // 
            // TextBoxNumContacto
            // 
            this.TextBoxNumContacto.Location = new System.Drawing.Point(41, 168);
            this.TextBoxNumContacto.Multiline = true;
            this.TextBoxNumContacto.Name = "TextBoxNumContacto";
            this.TextBoxNumContacto.Size = new System.Drawing.Size(233, 24);
            this.TextBoxNumContacto.TabIndex = 14;
            // 
            // TextBoxCliente_idCliente
            // 
            this.TextBoxCliente_idCliente.Location = new System.Drawing.Point(294, 168);
            this.TextBoxCliente_idCliente.Multiline = true;
            this.TextBoxCliente_idCliente.Name = "TextBoxCliente_idCliente";
            this.TextBoxCliente_idCliente.Size = new System.Drawing.Size(131, 24);
            this.TextBoxCliente_idCliente.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.PicBoxFaceChild);
            this.panel1.Controls.Add(this.TextBoxGenero);
            this.panel1.Controls.Add(this.TextBoxEdad);
            this.panel1.Location = new System.Drawing.Point(26, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 166);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(26, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dar de baja ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBackMenu
            // 
            this.BtnBackMenu.Location = new System.Drawing.Point(449, 208);
            this.BtnBackMenu.Name = "BtnBackMenu";
            this.BtnBackMenu.Size = new System.Drawing.Size(137, 27);
            this.BtnBackMenu.TabIndex = 18;
            this.BtnBackMenu.Text = "Regresar a menu";
            this.BtnBackMenu.UseVisualStyleBackColor = true;
            this.BtnBackMenu.Click += new System.EventHandler(this.BtnBackMenu_Click_1);
            // 
            // IDNiños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 247);
            this.Controls.Add(this.BtnBackMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxCliente_idCliente);
            this.Controls.Add(this.TextBoxNumContacto);
            this.Controls.Add(this.TextBoxFechaNac);
            this.Controls.Add(this.TextBoxNombreNiño);
            this.Controls.Add(this.ComBoxIDCliente);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.panel1);
            this.Name = "IDNiños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDNiños";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFaceChild)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.ComboBox ComBoxIDCliente;
        private System.Windows.Forms.TextBox TextBoxNombreNiño;
        private System.Windows.Forms.TextBox TextBoxFechaNac;
        private System.Windows.Forms.TextBox TextBoxEdad;
        private System.Windows.Forms.TextBox TextBoxGenero;
        private System.Windows.Forms.PictureBox PicBoxFaceChild;
        private System.Windows.Forms.TextBox TextBoxNumContacto;
        private System.Windows.Forms.TextBox TextBoxCliente_idCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnBackMenu;
    }
}