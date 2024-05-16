using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RDGweb
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
            ObtenerSiguienteID();
            ObtenerSiguienteIDNiño();
        }

        private void ObtenerSiguienteIDNiño()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "SELECT MAX(idNiño) AS max_id FROM niños"; // Cambia a la tabla de niños
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        object result = comando.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int maxID = Convert.ToInt32(result);
                            tbxIdniño.Text = (maxID + 1).ToString(); // Asigna el siguiente ID al TextBox
                        }
                        else
                        {
                            tbxIdniño.Text = "1"; // Si no hay ningún registro, comienza desde 1
                        }
                    }
                }

                // Establecer el TextBox como de solo lectura
                tbxIdniño.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID del niño: " + ex.Message);
            }
        }

        private void ObtenerSiguienteID()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "SELECT MAX(idCliente) AS max_id FROM cliente"; // Cambia a la tabla de cliente
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        object result = comando.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int maxID = Convert.ToInt32(result);
                            tbxIdpadre.Text = (maxID + 1).ToString(); // Asigna el siguiente ID al TextBox
                        }
                        else
                        {
                            tbxIdpadre.Text = "1"; // Si no hay ningún registro, comienza desde 1
                        }
                    }
                }
                tbxIdpadre.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message);
            }
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (string.IsNullOrWhiteSpace(TextBoxNuevoNombreCliente.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoEdadCliente.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoDirrecionCliente.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoCelularCliente.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoNSS.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoOficio.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoCorreo.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoNombreNiño.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevaFechaNiño.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevoNumeroContacto.Text) ||
                string.IsNullOrWhiteSpace(TextBoxNuevaEdadNiño.Text) ||
                string.IsNullOrWhiteSpace(tbxIdpadre.Text) ||
                string.IsNullOrWhiteSpace(tbxIdniño.Text) ||
                string.IsNullOrWhiteSpace(TextBoxActividad.Text))
                
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!int.TryParse(TextBoxNuevoEdadCliente.Text, out _))
            {
                MessageBox.Show("La edad del cliente debe ser un número entero.");
                return;
            }

            if (!DateTime.TryParse(TextBoxNuevaFechaNiño.Text, out _))
            {
                MessageBox.Show("La fecha de nacimiento del niño no es válida.");
                return;
            }

            if (!int.TryParse(TextBoxNuevaEdadNiño.Text, out int edad) || edad > 4)
            {
                MessageBox.Show("La edad del niño debe ser un número entero y no puede ser mayor a 4 años.");
                return;
            }

            if (!Regex.IsMatch(TextBoxNuevoNombreCliente.Text, @"^[a-zA-Z\s]+$") ||
                !Regex.IsMatch(TextBoxNuevoOficio.Text, @"^[a-zA-Z\s]+$") ||
                !Regex.IsMatch(TextBoxNuevoNombreNiño.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Los nombres y el oficio solo deben contener letras.");
                return;
            }

            if (!Regex.IsMatch(TextBoxNuevoNSS.Text, @"^\d{11}$"))
            {
                MessageBox.Show("El NSS debe contener exactamente 11 dígitos.");
                return;
            }

            if (!Regex.IsMatch(TextBoxNuevoCorreo.Text, @"^[^@]+@[^@]+\.[^@]+$"))
            {
                MessageBox.Show("El correo electrónico debe tener un formato válido con '@' y '.com'.");
                return;
            }

            if (!(TextBoxActividad.Text == "Masculino" || TextBoxActividad.Text == "Femenino"))
            {
                MessageBox.Show("El género solo puede ser 'Masculino' o 'Femenino'.");
                return;
            }

            if (!Regex.IsMatch(TextBoxNuevoCelularCliente.Text, @"^\d{10}$") ||
                !Regex.IsMatch(TextBoxNuevoNumeroContacto.Text, @"^\d{10}$"))
            {
                MessageBox.Show("El celular y el número de contacto deben contener exactamente 10 dígitos.");
                return;
            }

            // Insertar datos en la base de datos
            string connectionString = "server=localhost;user=root;database=guarderia;port=3306;password=";
            string queryCliente = "INSERT INTO cliente (Nombre, Edad, Dirección, Telefono, NSS, Oficio, Correo, idCliente) VALUES (@Nombre, @Edad, @Dirección, @Telefono, @NSS, @Oficio, @Correo, @idcliente); SELECT LAST_INSERT_ID();";
            string queryNiños = "INSERT INTO niños (Nombre, `Fecha de Nacimiento`, NumContacto, Edad, Genero, idNiño) VALUES (@NombreNiño, @FechaNacimiento, @NumContacto, @EdadNiño, @GeneroNiño, @idniño); SELECT LAST_INSERT_ID();";
           
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    int idPadre, idniño;

                    // Insertar en la tabla cliente y obtener el ID
                    using (MySqlCommand cmd = new MySqlCommand(queryCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", TextBoxNuevoNombreCliente.Text);
                        cmd.Parameters.AddWithValue("@Edad", TextBoxNuevoEdadCliente.Text);
                        cmd.Parameters.AddWithValue("@Dirección", TextBoxNuevoDirrecionCliente.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TextBoxNuevoCelularCliente.Text);
                        cmd.Parameters.AddWithValue("@NSS", TextBoxNuevoNSS.Text);
                        cmd.Parameters.AddWithValue("@Oficio", TextBoxNuevoOficio.Text);
                        cmd.Parameters.AddWithValue("@Correo", TextBoxNuevoCorreo.Text);
                        cmd.Parameters.AddWithValue("@idpadres", tbxIdpadre.Text);
                        

                        idPadre = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insertar en la tabla niños y obtener el ID
                    using (MySqlCommand cmd = new MySqlCommand(queryNiños, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreNiño", TextBoxNuevoNombreNiño.Text);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", TextBoxNuevaFechaNiño.Text);
                        cmd.Parameters.AddWithValue("@NumContacto", TextBoxNuevoNumeroContacto.Text);
                        cmd.Parameters.AddWithValue("@EdadNiño", TextBoxNuevaEdadNiño.Text);
                        cmd.Parameters.AddWithValue("@GeneroNiño", TextBoxActividad.Text);
                        cmd.Parameters.AddWithValue("@idniño", tbxIdniño.Text);
                        

                        idniño = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    int idCliente = ObtenerUltimoId("cliente");
                    tbxIdpadre.Text = idPadre.ToString();
                    tbxIdpadre.ReadOnly = true;

                    // Obtener ID del niño y mostrarlo en TextBox
                    int idNiño = ObtenerUltimoId("niños");
                    tbxIdniño.Text = idniño.ToString();
                    tbxIdniño.ReadOnly = true;

                    // Mostrar mensaje de éxito
                    MessageBox.Show($"La información se ha añadido correctamente. ID del Padre: {idPadre}, ID del Niño: {idniño}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
            }

        }
        private int ObtenerUltimoId(string tabla)
        {
            int ultimoId = 0;
            string connectionString = "server=localhost;user=root;database=guarderia;port=3306;password=";
            string query = $"SELECT MAX(id) FROM {tabla};";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        ultimoId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el último ID: " + ex.Message);
                }
            }

            return ultimoId + 1;
        }
    }
}
