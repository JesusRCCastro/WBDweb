namespace RDGweb
{
    partial class PersonalTrabajo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Trabajadores";
            // 
            // DgvTrabajadores
            // 
            this.DgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTrabajadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTrabajadores.Location = new System.Drawing.Point(0, 100);
            this.DgvTrabajadores.Name = "DgvTrabajadores";
            this.DgvTrabajadores.RowHeadersWidth = 51;
            this.DgvTrabajadores.RowTemplate.Height = 24;
            this.DgvTrabajadores.Size = new System.Drawing.Size(729, 360);
            this.DgvTrabajadores.TabIndex = 1;
            // 
            // PersonalTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 460);
            this.Controls.Add(this.DgvTrabajadores);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PersonalTrabajo";
            this.Text = "PersonalTrabajo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTrabajadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvTrabajadores;
    }
}