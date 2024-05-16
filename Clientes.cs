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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RDGweb
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            LoadNombresNiños();
            CombBoxNombreNiño.SelectedIndexChanged += CombBoxNombreNiño_SelectedIndexChanged;
            TextBoxNombrePadre.ReadOnly = true;
            TextBoxEdadPadre.ReadOnly = true;
            TextBoxDireccionPadre.ReadOnly = true;
            TextBoxNSS.ReadOnly = true;
            TextBoxOficio.ReadOnly = true;
            TextBoxCorreo.ReadOnly = true;
            TextBoxCelularPadre.ReadOnly= true;
            IDPadres.ReadOnly = true;

        }

        private void CombBoxNombreNiño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CombBoxNombreNiño.SelectedItem != null)
            {
   
                string selectedNombreNiño = CombBoxNombreNiño.SelectedItem.ToString();
                LimpiarDatosPadre();
                CargarDatosPadre(selectedNombreNiño);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un niño.");

            }
           
        }
        private void LoadNombresNiños()
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

                    CombBoxNombreNiño.Items.Clear();

                    while (reader.Read())
                    {
                        CombBoxNombreNiño.Items.Add(reader["Nombre"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los nombres de los niños: " + ex.Message);
                }
            }
        }
        private void CargarDatosPadre(string nombreNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "SELECT c.* " +
                           "FROM cliente c " +
                           "INNER JOIN niños n ON c.idCliente = n.id_Padre " +
                           "WHERE n.Nombre = @NombreNiño;";

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
                        TextBoxNombrePadre.Text = reader["Nombre"].ToString();
                        TextBoxEdadPadre.Text = reader["Edad"].ToString() + " años";
                        TextBoxDireccionPadre.Text = reader["Dirección"].ToString();
                        TextBoxNSS.Text = reader["NSS"].ToString();
                        TextBoxOficio.Text = reader["Oficio"].ToString();
                        TextBoxCorreo.Text = reader["Correo"].ToString();
                        TextBoxCelularPadre.Text = reader["Telefono"].ToString();
                        IDPadres.Text = reader["idCliente"].ToString();
                    }
                    else
                    {
                        LimpiarDatosPadre();
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del padre: " + ex.Message);
                }
            }
        }
        private void LimpiarDatosPadre()
        {
            TextBoxNombrePadre.Clear();
            TextBoxEdadPadre.Clear();
            TextBoxDireccionPadre.Clear();
            TextBoxNSS.Clear();
            TextBoxOficio.Clear();
            TextBoxCorreo.Clear();
            TextBoxCelularPadre.Clear();
            IDPadres.Clear();
        }

        
        

        

        //----------------------------------------------------------------------------------------------------------//


        
        private void EliminarPadre(string nombreNiño)
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";
            string query = "DELETE FROM cliente WHERE idCliente IN (SELECT id_Padre FROM niños WHERE Nombre = @NombreNiño);";

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
                        MessageBox.Show("El padre se eliminó correctamente.");
                        LoadNombresNiños();// Actualizar la lista de nombres de niños
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún padre asociado al niño proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar al padre: " + ex.Message);
                }
            }
        }
        private void BtnEliminarPadre_Click(object sender, EventArgs e)
        {
            if (CombBoxNombreNiño.SelectedItem != null)
            {
                string selectedNombreNiño = CombBoxNombreNiño.SelectedItem.ToString();
                EliminarPadre(selectedNombreNiño);
            }
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

        private void BtnAgregarNiño_Click(object sender, EventArgs e)
        {
            AgregarNiño agregarNiñoForm = new AgregarNiño(); // Crear una instancia del formulario AgregarNiño
            agregarNiñoForm.ShowDialog();
        }


        //----------------------------------------------------------------------------------------------------------//

    }
}
