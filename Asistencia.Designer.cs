﻿namespace RDGweb
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuscarNiño = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFalta = new System.Windows.Forms.Button();
            this.DgvAsistencia = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxIdNiño
            // 
            this.TbxIdNiño.Location = new System.Drawing.Point(149, 51);
            this.TbxIdNiño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxIdNiño.Multiline = true;
            this.TbxIdNiño.Name = "TbxIdNiño";
            this.TbxIdNiño.Size = new System.Drawing.Size(135, 27);
            this.TbxIdNiño.TabIndex = 0;
            // 
            // BtnTomarAsistencia
            // 
            this.BtnTomarAsistencia.Location = new System.Drawing.Point(403, 113);
            this.BtnTomarAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnTomarAsistencia.Name = "BtnTomarAsistencia";
            this.BtnTomarAsistencia.Size = new System.Drawing.Size(160, 38);
            this.BtnTomarAsistencia.TabIndex = 1;
            this.BtnTomarAsistencia.Text = "Tomar Asistencia";
            this.BtnTomarAsistencia.UseVisualStyleBackColor = true;
            this.BtnTomarAsistencia.Click += new System.EventHandler(this.BtnTomarAsistencia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BtnBuscarNiño);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbxIdNiño);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 100);
            this.panel1.TabIndex = 2;
            // 
            // BtnBuscarNiño
            // 
            this.BtnBuscarNiño.Location = new System.Drawing.Point(315, 45);
            this.BtnBuscarNiño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscarNiño.Name = "BtnBuscarNiño";
            this.BtnBuscarNiño.Size = new System.Drawing.Size(123, 34);
            this.BtnBuscarNiño.TabIndex = 6;
            this.BtnBuscarNiño.Text = "Buscar Niño";
            this.BtnBuscarNiño.UseVisualStyleBackColor = true;
            this.BtnBuscarNiño.Click += new System.EventHandler(this.BtnBuscarNiño_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el ID del Niño";
            // 
            // BtnFalta
            // 
            this.BtnFalta.Location = new System.Drawing.Point(403, 263);
            this.BtnFalta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFalta.Name = "BtnFalta";
            this.BtnFalta.Size = new System.Drawing.Size(160, 38);
            this.BtnFalta.TabIndex = 3;
            this.BtnFalta.Text = "Marcar Falta";
            this.BtnFalta.UseVisualStyleBackColor = true;
            this.BtnFalta.Click += new System.EventHandler(this.BtnFalta_Click);
            // 
            // DgvAsistencia
            // 
            this.DgvAsistencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColAsistencia});
            this.DgvAsistencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.DgvAsistencia.Location = new System.Drawing.Point(0, 100);
            this.DgvAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvAsistencia.Name = "DgvAsistencia";
            this.DgvAsistencia.RowHeadersWidth = 51;
            this.DgvAsistencia.RowTemplate.Height = 24;
            this.DgvAsistencia.Size = new System.Drawing.Size(402, 243);
            this.DgvAsistencia.TabIndex = 4;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre del NIño";
            this.ColNombre.MinimumWidth = 6;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 125;
            // 
            // ColAsistencia
            // 
            this.ColAsistencia.HeaderText = "Asistencia";
            this.ColAsistencia.MinimumWidth = 6;
            this.ColAsistencia.Name = "ColAsistencia";
            this.ColAsistencia.Width = 125;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(563, 343);
            this.Controls.Add(this.DgvAsistencia);
            this.Controls.Add(this.BtnFalta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnTomarAsistencia);
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

        private System.Windows.Forms.TextBox TbxIdNiño;
        private System.Windows.Forms.Button BtnTomarAsistencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnFalta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvAsistencia;
        private System.Windows.Forms.Button BtnBuscarNiño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsistencia;
    }
}