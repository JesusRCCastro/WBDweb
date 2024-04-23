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


    }
}
