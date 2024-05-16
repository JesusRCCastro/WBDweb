namespace RDGweb
{
    partial class AgregarNiño
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
            this.cbxPadreNiñoNuevo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxNombreNiño = new System.Windows.Forms.TextBox();
            this.tbxEdadNiño = new System.Windows.Forms.TextBox();
            this.tbxIdNiño = new System.Windows.Forms.TextBox();
            this.TbxNumeroNuevo = new System.Windows.Forms.TextBox();
            this.MaskFechanuevo = new System.Windows.Forms.MaskedTextBox();
            this.CbxGeneroNuevoNiño = new System.Windows.Forms.ComboBox();
            this.BtnAgregarNiño = new System.Windows.Forms.Button();
            this.tbxIdPadre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cbxPadreNiñoNuevo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 86);
            this.panel1.TabIndex = 0;
            // 
            // cbxPadreNiñoNuevo
            // 
            this.cbxPadreNiñoNuevo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxPadreNiñoNuevo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxPadreNiñoNuevo.FormattingEnabled = true;
            this.cbxPadreNiñoNuevo.Location = new System.Drawing.Point(272, 62);
            this.cbxPadreNiñoNuevo.Name = "cbxPadreNiñoNuevo";
            this.cbxPadreNiñoNuevo.Size = new System.Drawing.Size(162, 21);
            this.cbxPadreNiñoNuevo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Niños";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Niño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Contacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID del Niño";
            // 
            // tbxNombreNiño
            // 
            this.tbxNombreNiño.Location = new System.Drawing.Point(43, 149);
            this.tbxNombreNiño.Name = "tbxNombreNiño";
            this.tbxNombreNiño.Size = new System.Drawing.Size(100, 20);
            this.tbxNombreNiño.TabIndex = 7;
            // 
            // tbxEdadNiño
            // 
            this.tbxEdadNiño.Location = new System.Drawing.Point(301, 212);
            this.tbxEdadNiño.Name = "tbxEdadNiño";
            this.tbxEdadNiño.Size = new System.Drawing.Size(100, 20);
            this.tbxEdadNiño.TabIndex = 8;
            // 
            // tbxIdNiño
            // 
            this.tbxIdNiño.Location = new System.Drawing.Point(324, 283);
            this.tbxIdNiño.Name = "tbxIdNiño";
            this.tbxIdNiño.Size = new System.Drawing.Size(52, 20);
            this.tbxIdNiño.TabIndex = 9;
            // 
            // TbxNumeroNuevo
            // 
            this.TbxNumeroNuevo.Location = new System.Drawing.Point(43, 212);
            this.TbxNumeroNuevo.Name = "TbxNumeroNuevo";
            this.TbxNumeroNuevo.Size = new System.Drawing.Size(100, 20);
            this.TbxNumeroNuevo.TabIndex = 10;
            // 
            // MaskFechanuevo
            // 
            this.MaskFechanuevo.Location = new System.Drawing.Point(301, 149);
            this.MaskFechanuevo.Mask = "####-##-##";
            this.MaskFechanuevo.Name = "MaskFechanuevo";
            this.MaskFechanuevo.Size = new System.Drawing.Size(100, 20);
            this.MaskFechanuevo.TabIndex = 11;
            this.MaskFechanuevo.ValidatingType = typeof(System.DateTime);
            // 
            // CbxGeneroNuevoNiño
            // 
            this.CbxGeneroNuevoNiño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxGeneroNuevoNiño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxGeneroNuevoNiño.FormattingEnabled = true;
            this.CbxGeneroNuevoNiño.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CbxGeneroNuevoNiño.Location = new System.Drawing.Point(43, 282);
            this.CbxGeneroNuevoNiño.Name = "CbxGeneroNuevoNiño";
            this.CbxGeneroNuevoNiño.Size = new System.Drawing.Size(121, 21);
            this.CbxGeneroNuevoNiño.TabIndex = 12;
            // 
            // BtnAgregarNiño
            // 
            this.BtnAgregarNiño.Location = new System.Drawing.Point(167, 367);
            this.BtnAgregarNiño.Name = "BtnAgregarNiño";
            this.BtnAgregarNiño.Size = new System.Drawing.Size(115, 33);
            this.BtnAgregarNiño.TabIndex = 13;
            this.BtnAgregarNiño.Text = "Agregar Niño";
            this.BtnAgregarNiño.UseVisualStyleBackColor = true;
            this.BtnAgregarNiño.Click += new System.EventHandler(this.BtnAgregarNiño_Click);
            this.BtnAgregarNiño.Enter += new System.EventHandler(this.BtnAgregarNiño_Click);
            // 
            // tbxIdPadre
            // 
            this.tbxIdPadre.Location = new System.Drawing.Point(324, 348);
            this.tbxIdPadre.Name = "tbxIdPadre";
            this.tbxIdPadre.Size = new System.Drawing.Size(52, 20);
            this.tbxIdPadre.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID del Padre o Tutor";
            // 
            // AgregarNiño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.tbxIdPadre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAgregarNiño);
            this.Controls.Add(this.CbxGeneroNuevoNiño);
            this.Controls.Add(this.MaskFechanuevo);
            this.Controls.Add(this.TbxNumeroNuevo);
            this.Controls.Add(this.tbxIdNiño);
            this.Controls.Add(this.tbxEdadNiño);
            this.Controls.Add(this.tbxNombreNiño);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarNiño";
            this.Text = "AgregarNiño";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxPadreNiñoNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxNombreNiño;
        private System.Windows.Forms.TextBox tbxEdadNiño;
        private System.Windows.Forms.TextBox tbxIdNiño;
        private System.Windows.Forms.TextBox TbxNumeroNuevo;
        private System.Windows.Forms.MaskedTextBox MaskFechanuevo;
        private System.Windows.Forms.ComboBox CbxGeneroNuevoNiño;
        private System.Windows.Forms.Button BtnAgregarNiño;
        private System.Windows.Forms.TextBox tbxIdPadre;
        private System.Windows.Forms.Label label8;
    }
}