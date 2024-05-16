using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDGweb
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            // establecer el boton enter para acceder ala cuenta
            this.AcceptButton = BtnInicioSesion;
            // con esto reconoce el teclado y ya podemos acceder con enter (yo lo ocupaba me desesperaba al dar clic)
            this.KeyPreview = true;

            this.KeyDown += FormLogin_KeyDown;
            // this.CancelButton = BtnCancel;
            button1.MouseDown += button1_MouseDown;
            button1.MouseUp += button1_MouseUp;
        }
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Escape)
            {
                //mostrar el mensaje de confirmacion
                DialogResult result = MessageBox.Show("¿Estas seguro de que quieres cerrar RDGweb?","Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        private void LklRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            FormRegistro Registro = new FormRegistro();
            Registro.Show();
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TbxUser.Text;
            string contraseña = TbxPassword.Text;

            //verificar si lo campos estan vacios
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, ingresa tanto el nombre de usuario como la contraseña.");
                return;
            }

            //verificar la longitud minima de la contraseña
            if (contraseña.Length < 8) //requerimos una contraseña de almenos 8 caracteres 
            {
                MessageBox.Show("la contraseña debe tener al menos 8 caracteres");
                return;
            }

            // Ingresa a la base de datos
            MySqlConnection con = new MySqlConnection("Server=localhost;Database=Guarderia;Uid=root;Password=");
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            // Toma la información de la base de datos
            string sql = "SELECT correo, contrasena FROM usuarios WHERE correo = @nombreUsuario AND contrasena = @contraseña";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            MySqlDataReader read = cmd.ExecuteReader();

            if (read.Read())
            {
                this.Hide();
                MenuPrincipal menuPrincipal = new MenuPrincipal(nombreUsuario);
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("El Usuario o la contraseña son incorrectas. Favor de verificar.");
            }

            con.Close(); // Cerrar la conexión a la base de datos después de usarla
        }


        private void TbxPassword_TextChanged(object sender, EventArgs e)
        {
            TbxPassword.PasswordChar = '*';
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // Mostrar la contraseña cuando se mantenga presionado el botón
            TbxPassword.PasswordChar = '\0';
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            // Volver a ocultar la contraseña cuando se suelte el botón
            TbxPassword.PasswordChar = '*';
        }   
    }
}
