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
    public partial class Trabajadores : Form
    {
        private MySqlConnection con;
        private string connectionString = "server=localhost;Database=Guarderia;Uid=root;Password=";
        public Trabajadores()
        {
            InitializeComponent();
            con = new MySqlConnection(connectionString);
            CargarTrabajadores();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = TbxNombreTrabajador.Text;
            string Roles = TbxRolTrabajador.Text;
            string Correo = TbxCorreoTrabajador.Text;
            string Telefono = TbxTelefonoTrabajador.Text;

            if(!string.IsNullOrWhiteSpace(Nombre) && !string.IsNullOrWhiteSpace(Roles) && !string.IsNullOrWhiteSpace(Correo) && !string.IsNullOrWhiteSpace(Telefono))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO `personal` (Nombre, Roles, Correo, telefono) VALUES (@nombre, @roles, @correo, @telefono)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@roles", Roles);
                    cmd.Parameters.AddWithValue("@correo", Correo);
                    cmd.Parameters.AddWithValue("@telefono", Telefono);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trabajador agregado correctamente.");
                    CargarTrabajadores();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al agregar el trabajador: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string nombreABuscar = CbxNombre.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(nombreABuscar))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM `personal` WHERE Nombre = @nombre";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", nombreABuscar);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Trabajador eliminado correctamente.");
                    CargarTrabajadores();
                    LimpiarTextBox();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al eliminar el trabajador: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un nombre para eliminar.");
            }
        }

        private void CargarTrabajadores()
        {
            try
            {
                con.Open();
                string query = "SELECT Nombre FROM `personal`";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                CbxNombre.Items.Clear();
                while (reader.Read())
                {
                    CbxNombre.Items.Add(reader["Nombre"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los trabajadores: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreABuscar = CbxNombre.SelectedItem.ToString();
            if (!string.IsNullOrWhiteSpace(nombreABuscar))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM `personal` WHERE Nombre = @nombre";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", nombreABuscar);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TbxIDTrabajador.Text = reader["idPersonal"].ToString();
                        TbxRolTrabajador.Text = reader["Roles"].ToString();
                        TbxCorreoTrabajador.Text = reader["Correo"].ToString();
                        TbxNombreTrabajador.Text = reader["Nombre"].ToString();
                        TbxTelefonoTrabajador.Text = reader["telefono"].ToString();
                    }
                    else
                    {
                        LimpiarTextBox();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al buscar el trabajador: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
            
                
        }

        private void LimpiarTextBox()
        {
                TbxIDTrabajador.Text = "";
                TbxRolTrabajador.Text = "";
                TbxCorreoTrabajador.Text = "";
                TbxNombreTrabajador.Text = "";
                TbxTelefonoTrabajador.Text = "";
   
        }

        private void BtnVolvermenutrabajdores_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MenuPrincipal
            MenuPrincipal formularioMenuPrincipal = new MenuPrincipal();
            // Mostrar el formulario MenuPrincipal
            formularioMenuPrincipal.Show();
            // Cerrar el formulario actual
            this.Close();
        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {

        }
    }
}
