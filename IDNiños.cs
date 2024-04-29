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
    public partial class IDNiños : Form
    {
        public IDNiños()
        {
            InitializeComponent();
            LoadIdCliente();
            ComBoxIDCliente.SelectedIndexChanged += ComBoxIDCliente_SelectedIndexChanged;
        }
        private void ComBoxIDCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBoxIDCliente.SelectedItem != null)
            {
                int selectedIdCliente = Convert.ToInt32(ComBoxIDCliente.SelectedItem.ToString());
                NombreCliente(selectedIdCliente);
                EdadCliente(selectedIdCliente); 
                GeneroCliente(selectedIdCliente);
                FechaNacCliente(selectedIdCliente);
                NumCliente(selectedIdCliente);
            }
        }

        private void LoadIdCliente()
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT idNiño FROM niños;";  // Consulta para obtener los IDs

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Abrir la conexión a la base de datos

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    ComBoxIDCliente.Items.Clear();  // Limpiar el ComboBox antes de llenarlo

                    while (reader.Read())
                    {
                        // Añadir cada idIncidencia al ComboBox
                        ComBoxIDCliente.Items.Add(reader["idNiño"].ToString());
                    }

                    reader.Close();  // Cerrar el lector
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error en caso de fallo
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }

        }

        private void NombreCliente(int idNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Nombre FROM niños WHERE idNiño = @idNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNiño", idNiño);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxNombreNiño.Text = reader["Nombre"].ToString();
                    }
                    else
                    {
                        TextBoxNombreNiño.Text = "No se encontró descripción.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el nombre: " + ex.Message);
                }
            }

        }

        private void GeneroCliente(int idNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Genero FROM niños WHERE idNiño = @idNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNiño", idNiño);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxGenero.Text = reader["Genero"].ToString();
                    }
                    else
                    {
                        TextBoxGenero.Text = "No se encontró descripción.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la edad: " + ex.Message);
                }
            }

        }


        private void EdadCliente(int idNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Edad FROM niños WHERE idNiño = @idNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNiño", idNiño);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxEdad.Text = reader["Edad"].ToString() + "  años";
                    }
                    else
                    {
                        TextBoxEdad.Text = "No se encontró descripción.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la edad: " + ex.Message);
                }
            }

        }

        private void FechaNacCliente(int idNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT `FechaNacimiento` FROM niños WHERE idNiño = @idNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNiño", idNiño);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TextBoxFechaNac.Text = reader["FechaNacimiento"].ToString();
                        }
                        else
                        {
                            TextBoxFechaNac.Text = "No se encontró la fecha de nacimiento.";
                        }
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la fecha de nacimiento: " + ex.Message);
                }
            } 
        }

        private void NumCliente(int idNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT NumContacto FROM niños WHERE idNiño = @idNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNiño", idNiño);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxNumContacto.Text = reader["NumContacto"].ToString();
                    }
                    else
                    {
                        TextBoxNumContacto.Text = "No se encontró numero.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el numero: " + ex.Message);
                }
            }

        }
        private void DarDeBaja(int idNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "DELETE FROM niños WHERE idNiño = @idNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idNiño", idNiño);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("La fila se eliminó correctamente.");
                        // Puedes agregar aquí cualquier otra lógica que necesites después de eliminar la fila.
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna fila para eliminar con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la fila: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComBoxIDCliente.SelectedItem != null)
            {
                int selectedIdCliente = Convert.ToInt32(ComBoxIDCliente.SelectedItem.ToString());
                DarDeBaja(selectedIdCliente);
            }
        }
    }

}
