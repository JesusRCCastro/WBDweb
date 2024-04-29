namespace RDGweb
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.CombBoxNumeroPadres = new System.Windows.Forms.ComboBox();
            this.TextBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxEdadCliente = new System.Windows.Forms.TextBox();
            this.TextBoxDirrecionCliente = new System.Windows.Forms.TextBox();
            this.TextBoxNSS = new System.Windows.Forms.TextBox();
            this.TextBoxCelularCliente = new System.Windows.Forms.TextBox();
            this.TextBoxCorreo = new System.Windows.Forms.TextBox();
            this.TextBoxOficio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.BtnActualizarInfCliente = new System.Windows.Forms.Button();
            this.BtnEliminarCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CombBoxNumeroPadres
            // 
            this.CombBoxNumeroPadres.FormattingEnabled = true;
            this.CombBoxNumeroPadres.Location = new System.Drawing.Point(432, 48);
            this.CombBoxNumeroPadres.Name = "CombBoxNumeroPadres";
            this.CombBoxNumeroPadres.Size = new System.Drawing.Size(121, 24);
            this.CombBoxNumeroPadres.TabIndex = 0;
            this.CombBoxNumeroPadres.SelectedIndexChanged += new System.EventHandler(this.CombBoxNumeroPadres_SelectedIndexChanged);
            // 
            // TextBoxNombreCliente
            // 
            this.TextBoxNombreCliente.Location = new System.Drawing.Point(20, 158);
            this.TextBoxNombreCliente.Name = "TextBoxNombreCliente";
            this.TextBoxNombreCliente.Size = new System.Drawing.Size(154, 22);
            this.TextBoxNombreCliente.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CombBoxNumeroPadres);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Padres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Completo";
            // 
            // TextBoxEdadCliente
            // 
            this.TextBoxEdadCliente.Location = new System.Drawing.Point(247, 158);
            this.TextBoxEdadCliente.Name = "TextBoxEdadCliente";
            this.TextBoxEdadCliente.Size = new System.Drawing.Size(125, 22);
            this.TextBoxEdadCliente.TabIndex = 4;
            // 
            // TextBoxDirrecionCliente
            // 
            this.TextBoxDirrecionCliente.Location = new System.Drawing.Point(23, 218);
            this.TextBoxDirrecionCliente.Name = "TextBoxDirrecionCliente";
            this.TextBoxDirrecionCliente.Size = new System.Drawing.Size(154, 22);
            this.TextBoxDirrecionCliente.TabIndex = 5;
            // 
            // TextBoxNSS
            // 
            this.TextBoxNSS.Location = new System.Drawing.Point(23, 277);
            this.TextBoxNSS.Name = "TextBoxNSS";
            this.TextBoxNSS.Size = new System.Drawing.Size(154, 22);
            this.TextBoxNSS.TabIndex = 6;
            // 
            // TextBoxCelularCliente
            // 
            this.TextBoxCelularCliente.Location = new System.Drawing.Point(247, 218);
            this.TextBoxCelularCliente.Name = "TextBoxCelularCliente";
            this.TextBoxCelularCliente.Size = new System.Drawing.Size(125, 22);
            this.TextBoxCelularCliente.TabIndex = 7;
            // 
            // TextBoxCorreo
            // 
            this.TextBoxCorreo.Location = new System.Drawing.Point(23, 335);
            this.TextBoxCorreo.Name = "TextBoxCorreo";
            this.TextBoxCorreo.Size = new System.Drawing.Size(154, 22);
            this.TextBoxCorreo.TabIndex = 8;
            // 
            // TextBoxOficio
            // 
            this.TextBoxOficio.Location = new System.Drawing.Point(247, 277);
            this.TextBoxOficio.Name = "TextBoxOficio";
            this.TextBoxOficio.Size = new System.Drawing.Size(98, 22);
            this.TextBoxOficio.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(244, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(20, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Location = new System.Drawing.Point(244, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Location = new System.Drawing.Point(20, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numero seguro social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Location = new System.Drawing.Point(244, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Oficio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label8.Location = new System.Drawing.Point(20, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Correo electronico";
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.Location = new System.Drawing.Point(416, 156);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(137, 27);
            this.BtnAgregarCliente.TabIndex = 20;
            this.BtnAgregarCliente.Text = "Agregar cliente";
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // BtnActualizarInfCliente
            // 
            this.BtnActualizarInfCliente.Location = new System.Drawing.Point(416, 199);
            this.BtnActualizarInfCliente.Name = "BtnActualizarInfCliente";
            this.BtnActualizarInfCliente.Size = new System.Drawing.Size(137, 27);
            this.BtnActualizarInfCliente.TabIndex = 21;
            this.BtnActualizarInfCliente.Text = "Actualizar cliente";
            this.BtnActualizarInfCliente.UseVisualStyleBackColor = true;
            this.BtnActualizarInfCliente.Click += new System.EventHandler(this.BtnActualizarInfCliente_Click);
            // 
            // BtnEliminarCliente
            // 
            this.BtnEliminarCliente.Location = new System.Drawing.Point(416, 247);
            this.BtnEliminarCliente.Name = "BtnEliminarCliente";
            this.BtnEliminarCliente.Size = new System.Drawing.Size(137, 27);
            this.BtnEliminarCliente.TabIndex = 22;
            this.BtnEliminarCliente.Text = "Eliminar cliente";
            this.BtnEliminarCliente.UseVisualStyleBackColor = true;
            this.BtnEliminarCliente.Click += new System.EventHandler(this.BtnEliminarCliente_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 421);
            this.Controls.Add(this.BtnEliminarCliente);
            this.Controls.Add(this.BtnActualizarInfCliente);
            this.Controls.Add(this.BtnAgregarCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxOficio);
            this.Controls.Add(this.TextBoxCorreo);
            this.Controls.Add(this.TextBoxCelularCliente);
            this.Controls.Add(this.TextBoxNSS);
            this.Controls.Add(this.TextBoxDirrecionCliente);
            this.Controls.Add(this.TextBoxEdadCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxNombreCliente);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CombBoxNumeroPadres;
        private System.Windows.Forms.TextBox TextBoxNombreCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxEdadCliente;
        private System.Windows.Forms.TextBox TextBoxDirrecionCliente;
        private System.Windows.Forms.TextBox TextBoxNSS;
        private System.Windows.Forms.TextBox TextBoxCelularCliente;
        private System.Windows.Forms.TextBox TextBoxCorreo;
        private System.Windows.Forms.TextBox TextBoxOficio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.Button BtnActualizarInfCliente;
        private System.Windows.Forms.Button BtnEliminarCliente;
    }
}