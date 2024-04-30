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
        private string connectionString = "server=localhost;Database=guarderia;Uid=root;Password=";

        public Trabajadores()
        {
            InitializeComponent();
            con = new MySqlConnection(connectionString);
            CargarTrabajadores();
            CargarRoles(); // Nuevo: Cargar los roles al iniciar el formulario
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = TbxNombreTrabajador.Text;
            RolItem rolSeleccionado = (RolItem)CbxRoles.SelectedItem; // Nuevo: Obtener el rol seleccionado
            string Correo = TbxCorreoTrabajador.Text;
            string Telefono = TbxTelefonoTrabajador.Text;

            if (rolSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(Nombre) && !string.IsNullOrWhiteSpace(Correo) && !string.IsNullOrWhiteSpace(Telefono))
            {
                // Validar el número de teléfono
                if (!EsTelefonoValido(Telefono))
                {
                    MessageBox.Show("Por favor, ingresa un número de teléfono válido (10 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar el correo electrónico
                if (!EsCorreoValido(Correo))
                {
                    MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    con.Open();
                    string query = "INSERT INTO `personal` (Nombre, Roles, Correo, telefono) VALUES (@nombre, @roles, @correo, @telefono)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", Nombre);
                    cmd.Parameters.AddWithValue("@roles", rolSeleccionado.Id); // Nuevo: Insertar el ID del rol
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

        private bool EsTelefonoValido(string telefono)
        {
            if (telefono.Length == 10 && telefono.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        private bool EsCorreoValido(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private void CargarRoles()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    con.Open();
                    string query = "SELECT id, nombre FROM roles";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            CbxRoles.Items.Clear();
                            while (reader.Read())
                            {
                                CbxRoles.Items.Add(new RolItem((int)reader["id"], reader["nombre"].ToString()));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los roles: " + ex.Message);
            }
        }

        private void CargarTrabajadores()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    con.Open();
                    string query = "SELECT Nombre FROM `personal`";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            CbxNombre.Items.Clear();
                            while (reader.Read())
                            {
                                CbxNombre.Items.Add(reader["Nombre"].ToString());
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los trabajadores: " + ex.Message);
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
                        CbxRoles.Text = reader["rol_id"].ToString();
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

        private void LimpiarTextBox()
        {
            TbxIDTrabajador.Text = "";
            TbxNombreTrabajador.Text = "";
            TbxTelefonoTrabajador.Text = "";
        }

        private void BtnListaEmpleados_Click(object sender, EventArgs e)
        {
            PersonalTrabajo formularioPersonalTrabajo = new PersonalTrabajo();
            formularioPersonalTrabajo.Show();
        }
    }

    public class RolItem
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public RolItem(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
