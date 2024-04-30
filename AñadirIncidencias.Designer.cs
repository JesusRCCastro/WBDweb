namespace RDGweb
{
    partial class AñadirIncidencias
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.TextFechaIncidencia = new System.Windows.Forms.TextBox();
            this.TextDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID del niño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha del incidente";
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(21, 54);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(100, 22);
            this.TextID.TabIndex = 6;
            // 
            // TextFechaIncidencia
            // 
            this.TextFechaIncidencia.Location = new System.Drawing.Point(167, 54);
            this.TextFechaIncidencia.Name = "TextFechaIncidencia";
            this.TextFechaIncidencia.Size = new System.Drawing.Size(121, 22);
            this.TextFechaIncidencia.TabIndex = 7;
            // 
            // TextDescripcion
            // 
            this.TextDescripcion.Location = new System.Drawing.Point(21, 121);
            this.TextDescripcion.Name = "TextDescripcion";
            this.TextDescripcion.Size = new System.Drawing.Size(267, 22);
            this.TextDescripcion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripcion";
            // 
            // AñadirIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextDescripcion);
            this.Controls.Add(this.TextFechaIncidencia);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AñadirIncidencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirIncidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.TextBox TextFechaIncidencia;
        private System.Windows.Forms.TextBox TextDescripcion;
        private System.Windows.Forms.Label label3;
    }
}