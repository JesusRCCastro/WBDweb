using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RDGweb
{
    public partial class IDNiños : Form
    {
        private List<string> nombresNiños = new List<string>(); // Lista para almacenar los nombres de los niños

        public IDNiños()
        {
            InitializeComponent();
            LoadNombresNiños(); // Cambiar el nombre del método para cargar los nombres de los niños
            LbxNombreNiño.SelectedIndexChanged += LbxNombreNiño_SelectedIndexChanged; // Agregar evento para manejar la selección en el ListBox
            TextBoxBuscar.TextChanged += TextBoxBuscar_TextChanged; // Agregar evento para manejar el cambio de texto en el TextBox de búsqueda

            // Configurar TextBoxes como solo lectura
            TextBoxNombreNiño.ReadOnly = true;
            TextBoxGenero.ReadOnly = true;
            TextBoxEdad.ReadOnly = true;
            MaskedTextBoxFechaNac.ReadOnly = true;
            TextBoxNumContacto.ReadOnly = true;
        }


        private void TextBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string searchText = TextBoxBuscar.Text.ToLower(); // Convertir el texto de búsqueda a minúsculas para hacer la comparación de manera insensible a mayúsculas/minúsculas

            // Filtrar los elementos del ListBox para mostrar solo aquellos que contienen el texto de búsqueda
            LbxNombreNiño.Items.Clear();
            foreach (var item in nombresNiños)
            {
                if (item.ToLower().Contains(searchText))
                {
                    LbxNombreNiño.Items.Add(item);
                }
            }
        }
        
        private void LbxNombreNiño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbxNombreNiño.SelectedItem != null)
            {
                // Obtener el nombre del niño seleccionado y cargar sus datos
                string selectedNombreNiño = LbxNombreNiño.SelectedItem.ToString();
                CargarDatosNiño(selectedNombreNiño);
            }
        }

        private void LoadNombresNiños() // Cambiar el nombre del método para cargar los nombres de los niños
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Nombre FROM niños;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    LbxNombreNiño.Items.Clear();

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        nombresNiños.Add(nombre); // Agregar el nombre a la lista
                        LbxNombreNiño.Items.Add(reader["Nombre"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los nombres de los niños: " + ex.Message);
                }
            }
        }

        private void CargarDatosNiño(string nombreNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT * FROM niños WHERE Nombre = @NombreNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreNiño", nombreNiño);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxNombreNiño.Text = reader["Nombre"].ToString();
                        TextBoxGenero.Text = reader["Genero"].ToString();
                        TextBoxEdad.Text = reader["Edad"].ToString() + " años";
                        // Debug: Imprimir el valor de la fecha de nacimiento obtenido de la base de datos
                        Console.WriteLine("Valor de Fecha de Nacimiento desde la base de datos: " + reader["Fecha de Nacimiento"]);

                        // Verificar si el valor de la fecha de nacimiento es válido
                        if (reader["Fecha de Nacimiento"] != DBNull.Value)
                        {
                            // Intentar convertir la fecha y establecerla en el MaskedTextBox
                            try
                            {
                                DateTime fechaNacimiento = Convert.ToDateTime(reader["Fecha de Nacimiento"]);
                                MaskedTextBoxFechaNac.Text = fechaNacimiento.ToString("yyyy-MM-dd");
                            }
                            catch (FormatException)
                            {
                                // Si hay un error de formato al convertir la fecha, establecer el texto en blanco
                                MaskedTextBoxFechaNac.Text = "";
                            }
                        }
                        else
                        {
                            // Si el valor es DBNull, establecer el texto en blanco
                            MaskedTextBoxFechaNac.Text = "";
                        }

                        TextBoxNumContacto.Text = reader["NumContacto"].ToString();
                    }
                    else
                    {
                        LimpiarCampos();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del niño: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            TextBoxNombreNiño.Text = "";
            TextBoxGenero.Text = "";
            TextBoxEdad.Text = "";
            // Limpiar también el contenido del MaskedTextBox
            MaskedTextBoxFechaNac.Text = "";
            TextBoxNumContacto.Text = "";
        }

        private void DarDeBaja(string nombreNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "DELETE FROM niños WHERE Nombre = @NombreNiño;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreNiño", nombreNiño);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("El niño se eliminó correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún niño con el nombre proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar al niño: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LbxNombreNiño.SelectedItem != null)
            {
                string selectedNombreNiño = LbxNombreNiño.SelectedItem.ToString();
                DarDeBaja(selectedNombreNiño);

                LimpiarDatos();
                LoadNombresNiños();

            }
        }

        private void LimpiarDatos()
        {
            TextBoxNombreNiño.Clear();
            TextBoxGenero.Clear();
            TextBoxEdad.Clear();
            MaskedTextBoxFechaNac.Clear();
            TextBoxNumContacto.Clear();
        }
    }
}
