namespace RDGweb
{
    partial class Incidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incidencias));
            this.ComBIDNiños = new System.Windows.Forms.ComboBox();
            this.PicBoxFaceChild = new System.Windows.Forms.PictureBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.TextBoxInf_Incidencias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TexBoxFechaIncidencias = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFaceChild)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComBIDNiños
            // 
            this.ComBIDNiños.FormattingEnabled = true;
            this.ComBIDNiños.Location = new System.Drawing.Point(12, 52);
            this.ComBIDNiños.Name = "ComBIDNiños";
            this.ComBIDNiños.Size = new System.Drawing.Size(121, 24);
            this.ComBIDNiños.TabIndex = 1;
            // 
            // PicBoxFaceChild
            // 
            this.PicBoxFaceChild.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicBoxFaceChild.Location = new System.Drawing.Point(639, 12);
            this.PicBoxFaceChild.Name = "PicBoxFaceChild";
            this.PicBoxFaceChild.Size = new System.Drawing.Size(110, 98);
            this.PicBoxFaceChild.TabIndex = 2;
            this.PicBoxFaceChild.TabStop = false;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(12, 22);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(103, 16);
            this.LblUser.TabIndex = 5;
            this.LblUser.Text = "Nombre de niño";
            // 
            // TextBoxInf_Incidencias
            // 
            this.TextBoxInf_Incidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxInf_Incidencias.Location = new System.Drawing.Point(30, 146);
            this.TextBoxInf_Incidencias.Multiline = true;
            this.TextBoxInf_Incidencias.Name = "TextBoxInf_Incidencias";
            this.TextBoxInf_Incidencias.Size = new System.Drawing.Size(737, 218);
            this.TextBoxInf_Incidencias.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha";
            // 
            // TexBoxFechaIncidencias
            // 
            this.TexBoxFechaIncidencias.Location = new System.Drawing.Point(239, 52);
            this.TexBoxFechaIncidencias.Multiline = true;
            this.TexBoxFechaIncidencias.Name = "TexBoxFechaIncidencias";
            this.TexBoxFechaIncidencias.Size = new System.Drawing.Size(233, 24);
            this.TexBoxFechaIncidencias.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.PicBoxFaceChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 124);
            this.panel2.TabIndex = 10;
            // 
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TexBoxFechaIncidencias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxInf_Incidencias);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.ComBIDNiños);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Incidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidencias";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFaceChild)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComBIDNiños;
        private System.Windows.Forms.PictureBox PicBoxFaceChild;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TextBoxInf_Incidencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TexBoxFechaIncidencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}