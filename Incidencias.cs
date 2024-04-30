using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RDGweb
{
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
            LoadIdIncidencias();  // Cargar los IDs de incidencias al inicializar el formulario
            ComBIDNiños.SelectedIndexChanged += ComBIDNiños_SelectedIndexChanged;
        }

        private void ComBIDNiños_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBIDNiños.SelectedItem != null)
            {
                int selectedIdIncidencia = Convert.ToInt32(ComBIDNiños.SelectedItem.ToString());
                LoadDescripcionIncidencia(selectedIdIncidencia);
                LoadFechaIncidencia(selectedIdIncidencia);
            }
        }

        private void LoadIdIncidencias()
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT idIncidencia FROM incidencias;";  // Consulta para obtener los IDs

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();  // Abrir la conexión a la base de datos

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    ComBIDNiños.Items.Clear();  // Limpiar el ComboBox antes de llenarlo

                    while (reader.Read())
                    {
                        // Añadir cada idIncidencia al ComboBox
                        ComBIDNiños.Items.Add(reader["idIncidencia"].ToString());
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

        private void LoadDescripcionIncidencia(int idIncidencia)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT Descripcion FROM incidencias WHERE idIncidencia = @idIncidencia;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idIncidencia", idIncidencia);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxInf_Incidencias.Text = reader["Descripcion"].ToString();
                    }
                    else
                    {
                        TextBoxInf_Incidencias.Text = "No se encontró descripción.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la descripción: " + ex.Message);
                }
            }
        }
        private void LoadFechaIncidencia(int idIncidencia)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT `FechaIncidencia` FROM incidencias WHERE idIncidencia = @idIncidencia;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idIncidencia", idIncidencia);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TexBoxFechaIncidencias.Text = reader["FechaIncidencia"].ToString();
                    }
                    else
                    {
                        TexBoxFechaIncidencias.Text = "No se encontró fecha.";
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la fecha: " + ex.Message);
                }
            }
        }

    }
}