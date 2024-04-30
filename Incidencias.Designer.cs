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
            this.TextBoxInf_Incidencias = new System.Windows.Forms.TextBox();
            this.TexBoxFechaIncidencias = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicBoxFaceChild = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarIncidencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFaceChild)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComBIDNiños
            // 
            this.ComBIDNiños.FormattingEnabled = true;
            this.ComBIDNiños.Location = new System.Drawing.Point(25, 52);
            this.ComBIDNiños.Name = "ComBIDNiños";
            this.ComBIDNiños.Size = new System.Drawing.Size(166, 24);
            this.ComBIDNiños.TabIndex = 1;
            this.ComBIDNiños.Text = "selecciona el nombre";
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
            // TexBoxFechaIncidencias
            // 
            this.TexBoxFechaIncidencias.Location = new System.Drawing.Point(252, 52);
            this.TexBoxFechaIncidencias.Multiline = true;
            this.TexBoxFechaIncidencias.Name = "TexBoxFechaIncidencias";
            this.TexBoxFechaIncidencias.Size = new System.Drawing.Size(233, 24);
            this.TexBoxFechaIncidencias.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 9;
            // 
            // PicBoxFaceChild
            // 
            this.PicBoxFaceChild.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicBoxFaceChild.Location = new System.Drawing.Point(678, 3);
            this.PicBoxFaceChild.Name = "PicBoxFaceChild";
            this.PicBoxFaceChild.Size = new System.Drawing.Size(110, 98);
            this.PicBoxFaceChild.TabIndex = 2;
            this.PicBoxFaceChild.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de niño";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.TexBoxFechaIncidencias);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PicBoxFaceChild);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 124);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de la incidencia";
            // 
            // btnAgregarIncidencia
            // 
            this.btnAgregarIncidencia.BackColor = System.Drawing.SystemColors.Info;
            this.btnAgregarIncidencia.Location = new System.Drawing.Point(677, 375);
            this.btnAgregarIncidencia.Name = "btnAgregarIncidencia";
            this.btnAgregarIncidencia.Size = new System.Drawing.Size(90, 50);
            this.btnAgregarIncidencia.TabIndex = 9;
            this.btnAgregarIncidencia.Text = "Agregar incidencia";
            this.btnAgregarIncidencia.UseVisualStyleBackColor = false;
            this.btnAgregarIncidencia.Click += new System.EventHandler(this.btnAgregarIncidencia_Click);
            // 
            // Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarIncidencia);
            this.Controls.Add(this.TextBoxInf_Incidencias);
            this.Controls.Add(this.ComBIDNiños);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Incidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incidencias";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFaceChild)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComBIDNiños;
        private System.Windows.Forms.TextBox TextBoxInf_Incidencias;
        private System.Windows.Forms.TextBox TexBoxFechaIncidencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBoxFaceChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarIncidencia;
    }
}