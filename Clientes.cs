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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            LoadIdCliente();
            CombBoxNumeroPadres.SelectedIndexChanged += CombBoxNumeroPadres_SelectedIndexChanged;
        }

        private void CombBoxNumeroPadres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CombBoxNumeroPadres.SelectedItem != null)
            {
                string selectedText = Convert.ToString(CombBoxNumeroPadres.SelectedItem);
                NombreCliente(selectedText);
                EdadCliente(selectedText);
                DireccionCliente(selectedText);
                CelularCliente(selectedText);
                NSSCliente(selectedText);
                OficioCliente(selectedText);
                CorreoCliente(selectedText);
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ítem.");
            }
        }

        private void LoadIdCliente()
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Telefono FROM cliente;";  // Consulta para obtener los IDs

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Abrir la conexión a la base de datos

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    CombBoxNumeroPadres.Items.Clear();  // Limpiar el ComboBox antes de llenarlo

                    while (reader.Read())
                    {
                        // Añadir cada idIncidencia al ComboBox
                        CombBoxNumeroPadres.Items.Add(reader["Telefono"].ToString());
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

        private void NombreCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Nombre FROM cliente WHERE Telefono = @Telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxNombreCliente.Text = reader["Nombre"].ToString();
                    }
                    else
                    {
                        TextBoxNombreCliente.Text = "No se encontró el nombre.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el nombre: " + ex.Message);
                }
            }
        }

        private void EdadCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Edad FROM cliente WHERE telefono = @telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxEdadCliente.Text = reader["Edad"].ToString() + "  años";
                    }
                    else
                    {
                        TextBoxEdadCliente.Text = "No se encontró descripción.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la edad: " + ex.Message);
                }
            }

        }

        private void DireccionCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT `Dirección` FROM cliente WHERE telefono = @telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxDirrecionCliente.Text = reader["Dirección"].ToString();
                    }
                    else
                    {
                        TextBoxDirrecionCliente.Text = "No se encontró descripción.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la dirección: " + ex.ToString());
                }
            }
        }

        private void CelularCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT `Telefono` FROM cliente WHERE telefono = @telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxCelularCliente.Text = reader["Telefono"].ToString();
                    }
                    else
                    {
                        TextBoxCelularCliente.Text = "No se encontró celular.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la dirección: " + ex.ToString());
                }
            }
        }

        private void NSSCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT `NSS` FROM cliente WHERE telefono = @telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxNSS.Text = reader["NSS"].ToString();
                    }
                    else
                    {
                        TextBoxNSS.Text = "No se encontró NSS.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la NSS: " + ex.ToString());
                }
            }
        }

        private void OficioCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT `Oficio` FROM cliente WHERE telefono = @telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxOficio.Text = reader["Oficio"].ToString();
                    }
                    else
                    {
                        TextBoxOficio.Text = "No se encontró oficio.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la oficio: " + ex.ToString());
                }
            }
        }

        private void CorreoCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT `Correo` FROM cliente WHERE telefono = @telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxCorreo.Text = reader["Correo"].ToString();
                    }
                    else
                    {
                        TextBoxCorreo.Text = "No se encontró correo.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la correo: " + ex.ToString());
                }
            }
        }
    }
}
