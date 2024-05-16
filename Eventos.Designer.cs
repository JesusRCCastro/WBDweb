namespace RDGweb
{
    partial class Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnagregarEvento = new System.Windows.Forms.Button();
            this.TbxNombreActividad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxEstablecerFecha = new System.Windows.Forms.MaskedTextBox();
            this.DgvEventos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.TbxEstablecerFecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnagregarEvento);
            this.panel1.Controls.Add(this.TbxNombreActividad);
            this.panel1.Location = new System.Drawing.Point(77, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 117);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Establecer Fecha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre de Actividad";
            // 
            // BtnagregarEvento
            // 
            this.BtnagregarEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnagregarEvento.Location = new System.Drawing.Point(201, 75);
            this.BtnagregarEvento.Name = "BtnagregarEvento";
            this.BtnagregarEvento.Size = new System.Drawing.Size(75, 28);
            this.BtnagregarEvento.TabIndex = 3;
            this.BtnagregarEvento.Text = "Agregar";
            this.BtnagregarEvento.UseVisualStyleBackColor = true;
            this.BtnagregarEvento.Click += new System.EventHandler(this.BtnagregarEvento_Click);
            // 
            // TbxNombreActividad
            // 
            this.TbxNombreActividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TbxNombreActividad.Location = new System.Drawing.Point(48, 41);
            this.TbxNombreActividad.Name = "TbxNombreActividad";
            this.TbxNombreActividad.Size = new System.Drawing.Size(135, 22);
            this.TbxNombreActividad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Actividad";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Actividades";
            // 
            // TbxEstablecerFecha
            // 
            this.TbxEstablecerFecha.AllowPromptAsInput = false;
            this.TbxEstablecerFecha.Location = new System.Drawing.Point(307, 41);
            this.TbxEstablecerFecha.Mask = "####-##-##";
            this.TbxEstablecerFecha.Name = "TbxEstablecerFecha";
            this.TbxEstablecerFecha.Size = new System.Drawing.Size(100, 22);
            this.TbxEstablecerFecha.TabIndex = 7;
            this.TbxEstablecerFecha.ValidatingType = typeof(System.DateTime);
            // 
            // DgvEventos
            // 
            this.DgvEventos.AllowUserToAddRows = false;
            this.DgvEventos.AllowUserToDeleteRows = false;
            this.DgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEventos.Location = new System.Drawing.Point(158, 79);
            this.DgvEventos.Name = "DgvEventos";
            this.DgvEventos.RowHeadersWidth = 51;
            this.DgvEventos.RowTemplate.Height = 24;
            this.DgvEventos.Size = new System.Drawing.Size(479, 184);
            this.DgvEventos.TabIndex = 7;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 486);
            this.Controls.Add(this.DgvEventos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnagregarEvento;
        private System.Windows.Forms.TextBox TbxNombreActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TbxEstablecerFecha;
        private System.Windows.Forms.DataGridView DgvEventos;
    }
}