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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.BtnTomarAsistencia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFalta = new System.Windows.Forms.Button();
            this.DgvAsistencia = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTomarAsistencia
            // 
            this.BtnTomarAsistencia.Location = new System.Drawing.Point(435, 220);
            this.BtnTomarAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTomarAsistencia.Name = "BtnTomarAsistencia";
            this.BtnTomarAsistencia.Size = new System.Drawing.Size(126, 33);
            this.BtnTomarAsistencia.TabIndex = 1;
            this.BtnTomarAsistencia.Text = "Tomar Asistencia";
            this.BtnTomarAsistencia.UseVisualStyleBackColor = true;
            this.BtnTomarAsistencia.Click += new System.EventHandler(this.BtnTomarAsistencia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 93);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tomar Asistencia";
            // 
            // BtnFalta
            // 
            this.BtnFalta.Location = new System.Drawing.Point(435, 283);
            this.BtnFalta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFalta.Name = "BtnFalta";
            this.BtnFalta.Size = new System.Drawing.Size(126, 33);
            this.BtnFalta.TabIndex = 3;
            this.BtnFalta.Text = "Marcar Falta";
            this.BtnFalta.UseVisualStyleBackColor = true;
            this.BtnFalta.Click += new System.EventHandler(this.BtnFalta_Click);
            // 
            // DgvAsistencia
            // 
            this.DgvAsistencia.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsistencia.Location = new System.Drawing.Point(199, 167);
            this.DgvAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvAsistencia.Name = "DgvAsistencia";
            this.DgvAsistencia.RowHeadersWidth = 51;
            this.DgvAsistencia.RowTemplate.Height = 24;
            this.DgvAsistencia.Size = new System.Drawing.Size(392, 171);
            this.DgvAsistencia.TabIndex = 4;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 457);
            this.Controls.Add(this.BtnFalta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnTomarAsistencia);
            this.Controls.Add(this.DgvAsistencia);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Asistencia_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnTomarAsistencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFalta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvAsistencia;
    }
}