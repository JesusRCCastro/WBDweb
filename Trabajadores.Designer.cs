﻿namespace RDGweb
{
    partial class Trabajadores
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxNombre = new System.Windows.Forms.ComboBox();
            this.BtnVolvermenutrabajdores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxTelefonoTrabajador = new System.Windows.Forms.TextBox();
            this.TbxCorreoTrabajador = new System.Windows.Forms.TextBox();
            this.TbxRolTrabajador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxIDTrabajador = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxNombreTrabajador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnListaEmpleados = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CbxNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 100);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trabajadores";
            // 
            // CbxNombre
            // 
            this.CbxNombre.FormattingEnabled = true;
            this.CbxNombre.Location = new System.Drawing.Point(294, 56);
            this.CbxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbxNombre.Name = "CbxNombre";
            this.CbxNombre.Size = new System.Drawing.Size(159, 24);
            this.CbxNombre.TabIndex = 0;
            this.CbxNombre.SelectedIndexChanged += new System.EventHandler(this.CbxNombre_SelectedIndexChanged);
            // 
            // BtnVolvermenutrabajdores
            // 
            this.BtnVolvermenutrabajdores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnVolvermenutrabajdores.Location = new System.Drawing.Point(360, 13);
            this.BtnVolvermenutrabajdores.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVolvermenutrabajdores.Name = "BtnVolvermenutrabajdores";
            this.BtnVolvermenutrabajdores.Size = new System.Drawing.Size(119, 25);
            this.BtnVolvermenutrabajdores.TabIndex = 23;
            this.BtnVolvermenutrabajdores.Text = "Volver al menu";
            this.BtnVolvermenutrabajdores.UseVisualStyleBackColor = false;
            this.BtnVolvermenutrabajdores.Click += new System.EventHandler(this.BtnVolvermenutrabajdores_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(291, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(28, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Correo";
            // 
            // TbxTelefonoTrabajador
            // 
            this.TbxTelefonoTrabajador.Location = new System.Drawing.Point(294, 127);
            this.TbxTelefonoTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxTelefonoTrabajador.Name = "TbxTelefonoTrabajador";
            this.TbxTelefonoTrabajador.Size = new System.Drawing.Size(125, 22);
            this.TbxTelefonoTrabajador.TabIndex = 17;
            // 
            // TbxCorreoTrabajador
            // 
            this.TbxCorreoTrabajador.Location = new System.Drawing.Point(32, 194);
            this.TbxCorreoTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxCorreoTrabajador.Name = "TbxCorreoTrabajador";
            this.TbxCorreoTrabajador.Size = new System.Drawing.Size(227, 22);
            this.TbxCorreoTrabajador.TabIndex = 16;
            // 
            // TbxRolTrabajador
            // 
            this.TbxRolTrabajador.Location = new System.Drawing.Point(294, 194);
            this.TbxRolTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxRolTrabajador.Name = "TbxRolTrabajador";
            this.TbxRolTrabajador.Size = new System.Drawing.Size(125, 22);
            this.TbxRolTrabajador.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(291, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rol";
            // 
            // TbxIDTrabajador
            // 
            this.TbxIDTrabajador.Location = new System.Drawing.Point(31, 251);
            this.TbxIDTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxIDTrabajador.Name = "TbxIDTrabajador";
            this.TbxIDTrabajador.Size = new System.Drawing.Size(67, 22);
            this.TbxIDTrabajador.TabIndex = 13;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAgregar.Location = new System.Drawing.Point(193, 260);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 33);
            this.BtnAgregar.TabIndex = 21;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEliminar.Location = new System.Drawing.Point(319, 260);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 33);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.BtnListaEmpleados);
            this.panel2.Controls.Add(this.BtnVolvermenutrabajdores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 311);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 49);
            this.panel2.TabIndex = 23;
            // 
            // TbxNombreTrabajador
            // 
            this.TbxNombreTrabajador.Location = new System.Drawing.Point(32, 127);
            this.TbxNombreTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbxNombreTrabajador.Name = "TbxNombreTrabajador";
            this.TbxNombreTrabajador.Size = new System.Drawing.Size(200, 22);
            this.TbxNombreTrabajador.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(29, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre";
            // 
            // BtnListaEmpleados
            // 
            this.BtnListaEmpleados.Location = new System.Drawing.Point(29, 14);
            this.BtnListaEmpleados.Name = "BtnListaEmpleados";
            this.BtnListaEmpleados.Size = new System.Drawing.Size(147, 24);
            this.BtnListaEmpleados.TabIndex = 24;
            this.BtnListaEmpleados.Text = "Lista de empleados";
            this.BtnListaEmpleados.UseVisualStyleBackColor = true;
            this.BtnListaEmpleados.Click += new System.EventHandler(this.BtnListaEmpleados_Click);
            // 
            // Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(490, 360);
            this.Controls.Add(this.TbxNombreTrabajador);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxTelefonoTrabajador);
            this.Controls.Add(this.TbxCorreoTrabajador);
            this.Controls.Add(this.TbxRolTrabajador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxIDTrabajador);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Trabajadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxTelefonoTrabajador;
        private System.Windows.Forms.TextBox TbxCorreoTrabajador;
        private System.Windows.Forms.TextBox TbxRolTrabajador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxIDTrabajador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TbxNombreTrabajador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnVolvermenutrabajdores;
        private System.Windows.Forms.Button BtnListaEmpleados;
    }
}