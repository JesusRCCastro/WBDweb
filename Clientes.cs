using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
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
using static Mysqlx.Crud.Order.Types;

namespace RDGweb
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            LoadIdCliente();
            this.BtnActualizarInfCliente.Click += new System.EventHandler(this.BtnActualizarInfCliente_Click);
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

        private void BtnBackMenu_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MenuPrincipal
            MenuPrincipal formularioMenuPrincipal = new MenuPrincipal();
            // Mostrar el formulario MenuPrincipal
            formularioMenuPrincipal.Show();
            // Cerrar el formulario actual
            this.Close();
        }

        //----------------------------------------------------------------------------------------------------------//


        private void UpdateCliente()
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";

            // Comando SQL para actualizar los datos del cliente
            string query = "UPDATE cliente SET Nombre = @Nombre, Edad = @Edad, Dirección = @Dirección, " +
                           "Telefono = @Telefono, NSS = @NSS, Oficio = @Oficio, Correo = @Correo " +
                           "WHERE Telefono = @Telefono;"; // Asumiendo que el teléfono es la clave para encontrar el cliente

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Añade los parámetros con los valores de los TextBox
                    cmd.Parameters.AddWithValue("@Nombre", TextBoxNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@Edad", TextBoxEdadCliente.Text);
                    cmd.Parameters.AddWithValue("@Dirección", TextBoxDirrecionCliente.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TextBoxCelularCliente.Text);
                    cmd.Parameters.AddWithValue("@NSS", TextBoxNSS.Text);
                    cmd.Parameters.AddWithValue("@Oficio", TextBoxOficio.Text);
                    cmd.Parameters.AddWithValue("@Correo", TextBoxCorreo.Text);

                    // Ejecuta la consulta
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente O Si.");
                    }
                    else
                    {
                        MessageBox.Show("No se actualizó ningún dato.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
            }
        }

        private void BtnActualizarInfCliente_Click(object sender, EventArgs e)
        {
            UpdateCliente();
        }

        //----------------------------------------------------------------------------------------------------------//


        public void EliminarCliente(string telefono)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "DELETE FROM cliente WHERE telefono = @telefono;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@telefono", telefono);

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

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            string selectedText = Convert.ToString(CombBoxNumeroPadres.SelectedItem);
            EliminarCliente(selectedText);
        }

        //----------------------------------------------------------------------------------------------------------//

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de nuevos clientes
            NuevoCliente formularioNuevosCliente = new NuevoCliente();
            // Mostrar el formulario de nuevos clientes
            formularioNuevosCliente.Show();
            // Ocultar el formulario actual
            this.Hide();
        }


        //----------------------------------------------------------------------------------------------------------//

    }
}
