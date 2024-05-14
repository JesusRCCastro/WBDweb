using MySql.Data.MySqlClient;
using System;
using System.Linq;
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
            string username = TbxRegistroUser.Text.Trim();
            string password = TbxRegistroPassword.Text.Trim();

            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Validar que el nombre no contenga números
            if (username.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre de usuario no puede contener números.");
                return;
            }

            // Validar que la contraseña tenga al menos 8 caracteres
            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            // Validar que no haya espacios en el usuario
            if (username.Contains(" "))
            {
                MessageBox.Show("El nombre de usuario no puede contener espacios.");
                return;
            }

            // Validar que la contraseña no sea solo espacios
            if (password.All(char.IsWhiteSpace))
            {
                MessageBox.Show("La contraseña no puede ser solo espacios.");
                return;
            }

            // Establecer conexión con la base de datos
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = Guarderia; User Id = root; Password =  ");
            try
            {
                con.Open();

                // Verificar si el usuario ya existe en la base de datos
                string checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE correo = @correo";
                MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, con);
                checkCmd.Parameters.AddWithValue("@correo", username);
                int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (userCount > 0)
                {
                    MessageBox.Show("El usuario ya está registrado.");
                    return;
                }

                // Consulta SQL para insertar los datos del nuevo usuario en la base de datos
                string sql = "INSERT INTO usuarios (correo, contrasena) VALUES (@correo, @contrasena)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                // Asignar los valores de los parámetros
                cmd.Parameters.AddWithValue("@correo", username);
                cmd.Parameters.AddWithValue("@contrasena", password);

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
