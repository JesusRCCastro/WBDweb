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
            Form FormRegistro = new FormRegistro();
            FormRegistro.Show();
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TbxUser.Text;
            string contraseña = TbxPassword.Text;

            

            MySqlConnection con = new MySqlConnection("Server = localhost; Database = Guarderia; User Id = root; Password =  ");
            try
            {
                con.Open();
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("Error" + ex.ToString());
                throw;
            }
            string sql = "Select correo, contrasena from usuarios where correo = '" + nombreUsuario + "' AND contrasena = '" + contraseña + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();

            

            if (read.Read()) 
            {
                this.Hide();
                //MessageBox.Show("Bienvenido " + nombreUsuario);//quitar esto para poner el nuevo form
                MenuPrincipal menuPrincipal = new MenuPrincipal();// esta parte abre el menu pricipal despues de aver autenticado el usuario
                menuPrincipal.Show();// se muestra el menu
            }
            else
            {
                MessageBox.Show("El Usuario o la contraseña son incorrectas favor de verificar");// mensaje que se mostrara en caso de que el usuario o la contraseñas sean erroneas
            }
        }

        private void TbxPassword_TextChanged(object sender, EventArgs e)
        {
            TbxPassword.PasswordChar = '*';
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
