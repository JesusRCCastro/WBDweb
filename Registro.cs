using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDGweb
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
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
            string sql = "insert into usuarios (correo, contrasena) values ('" + TbxRegistroUser.Text + "' , '" + TbxRegistroPassword.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Registrado Correctamente.");
                this.Hide();
                FormLogin Login = new FormLogin();
                Login.Show();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }
    }
}
