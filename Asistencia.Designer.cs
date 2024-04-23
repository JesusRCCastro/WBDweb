namespace RDGweb
{
    partial class Asistencia
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
            this.TbxIdNiño = new System.Windows.Forms.TextBox();
            this.BtnTomarAsistencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxIdNiño
            // 
            this.TbxIdNiño.Location = new System.Drawing.Point(165, 105);
            this.TbxIdNiño.Multiline = true;
            this.TbxIdNiño.Name = "TbxIdNiño";
            this.TbxIdNiño.Size = new System.Drawing.Size(135, 27);
            this.TbxIdNiño.TabIndex = 0;
            // 
            // BtnTomarAsistencia
            // 
            this.BtnTomarAsistencia.Location = new System.Drawing.Point(153, 187);
            this.BtnTomarAsistencia.Name = "BtnTomarAsistencia";
            this.BtnTomarAsistencia.Size = new System.Drawing.Size(160, 38);
            this.BtnTomarAsistencia.TabIndex = 1;
            this.BtnTomarAsistencia.Text = "Tomar Asistencia";
            this.BtnTomarAsistencia.UseVisualStyleBackColor = true;
            this.BtnTomarAsistencia.Click += new System.EventHandler(this.BtnTomarAsistencia_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTomarAsistencia);
            this.Controls.Add(this.TbxIdNiño);
            this.Name = "Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxIdNiño;
        private System.Windows.Forms.Button BtnTomarAsistencia;
    }
}