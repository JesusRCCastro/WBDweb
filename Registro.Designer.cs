namespace RDGweb
{
    partial class FormRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxRegistroUser = new System.Windows.Forms.TextBox();
            this.TbxRegistroPassword = new System.Windows.Forms.TextBox();
            this.BtnGuardarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conraseña";
            // 
            // TbxRegistroUser
            // 
            this.TbxRegistroUser.Location = new System.Drawing.Point(128, 87);
            this.TbxRegistroUser.Name = "TbxRegistroUser";
            this.TbxRegistroUser.Size = new System.Drawing.Size(175, 22);
            this.TbxRegistroUser.TabIndex = 2;
            // 
            // TbxRegistroPassword
            // 
            this.TbxRegistroPassword.Location = new System.Drawing.Point(128, 177);
            this.TbxRegistroPassword.Name = "TbxRegistroPassword";
            this.TbxRegistroPassword.Size = new System.Drawing.Size(175, 22);
            this.TbxRegistroPassword.TabIndex = 3;
            // 
            // BtnGuardarDatos
            // 
            this.BtnGuardarDatos.Location = new System.Drawing.Point(128, 264);
            this.BtnGuardarDatos.Name = "BtnGuardarDatos";
            this.BtnGuardarDatos.Size = new System.Drawing.Size(124, 32);
            this.BtnGuardarDatos.TabIndex = 4;
            this.BtnGuardarDatos.Text = "Guardar";
            this.BtnGuardarDatos.UseVisualStyleBackColor = true;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(383, 351);
            this.Controls.Add(this.BtnGuardarDatos);
            this.Controls.Add(this.TbxRegistroPassword);
            this.Controls.Add(this.TbxRegistroUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxRegistroUser;
        private System.Windows.Forms.TextBox TbxRegistroPassword;
        private System.Windows.Forms.Button BtnGuardarDatos;
    }
}