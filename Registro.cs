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
            //validar que no haya campos vacios
            if (string.IsNullOrWhiteSpace(TbxRegistroUser.Text) || string.IsNullOrWhiteSpace(TbxRegistroPassword.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Validar que la contraseña tenga al menos 8 caracteres
            if (TbxRegistroPassword.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }
            // establecer coneccion con la base de datos
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = Guarderia; User Id = root; Password =  ");
            try
            {
                con.Open();
                // Consulta SQL para insertar los datos del nuevo usuario en la base de datos
                string sql = "INSERT INTO usuarios (correo, contrasena) VALUES (@correo, @contrasena)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Asignar los valores de los parámetros
                cmd.Parameters.AddWithValue("@correo", TbxRegistroUser.Text);
                cmd.Parameters.AddWithValue("@contrasena", TbxRegistroPassword.Text);

                // Ejecutar la consulta
                int registrosInsertados = cmd.ExecuteNonQuery();

                if (registrosInsertados > 0)
                {
                    MessageBox.Show("Usuario registrado correctamente.");
                    this.Hide();
                    FormLogin Login = new FormLogin();
                    Login.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        private void BtnRegresarlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin Login = new FormLogin();
            Login.Show();
        }
    }
}
