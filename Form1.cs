using MySql.Data.MySqlClient;
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
                MessageBox.Show("Bienvenido " + nombreUsuario);
            }
            else
            {
                MessageBox.Show("No existe " + nombreUsuario);
            }
        }
    }
}
