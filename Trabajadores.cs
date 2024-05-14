using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RDGweb
{
    public partial class Trabajadores : Form
    {
        private bool listaEmpleadosAbierto = false;
        private MySqlConnection con;
        private string connectionString = "server=localhost;Database=guarderia;Uid=root;Password=";

        public Trabajadores()
        {
            InitializeComponent();
            con = new MySqlConnection(connectionString);
            CargarRoles();
            ObtenerSiguienteID();
            TbxID.ReadOnly = true;
            CbxRoles.DropDownStyle = ComboBoxStyle.DropDown;
            CbxRoles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbxRoles.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TbxNombreTrabajador.Text.Trim();
            RolItem rolSeleccionado = (RolItem)CbxRoles.SelectedItem;
            string correo = TbxCorreoTrabajador.Text.Trim();
            string telefono = TbxTelefonoTrabajador.Text.Trim();

            if (rolSeleccionado == null)
            {
                MessageBox.Show("Por favor, selecciona un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nombre.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsTelefonoValido(telefono))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido (10 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsCorreoValido(correo))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido que termine en .com.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TrabajadorExiste(nombre, correo, telefono))
            {
                MessageBox.Show("El trabajador ya existe en la base de datos con el mismo nombre, correo o teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO `personal` (Nombre, rol_id, Correo, telefono) VALUES (@nombre, @roles, @correo, @telefono)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@roles", rolSeleccionado.Id);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trabajador agregado correctamente.");
                LimpiarCampos();
                ObtenerSiguienteID();
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

        private bool TrabajadorExiste(string nombre, string correo, string telefono)
        {
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM personal WHERE Nombre = @nombre OR Correo = @correo OR telefono = @telefono";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al verificar la existencia del trabajador: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        private bool EsTelefonoValido(string telefono)
        {
            return telefono.Length == 10 && telefono.All(char.IsDigit);
        }

        private bool EsCorreoValido(string correo)
        {
            try
            {
                var addr = new MailAddress(correo);
                return addr.Address == correo && correo.EndsWith(".com");
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

        private void BtnListaEmpleados_Click(object sender, EventArgs e)
        {
            if (!listaEmpleadosAbierto)
            {
                PersonalTrabajo formularioPersonalTrabajo = new PersonalTrabajo();
                formularioPersonalTrabajo.Show();
                listaEmpleadosAbierto = true;
                formularioPersonalTrabajo.FormClosed += (s, args) => listaEmpleadosAbierto = false;
            }
        }

        private void ObtenerSiguienteID()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "SELECT MAX(idPersonal) AS max_id FROM personal";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        object result = comando.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int maxID = Convert.ToInt32(result);
                            TbxID.Text = (maxID + 1).ToString();
                        }
                        else
                        {
                            TbxID.Text = "1";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            TbxNombreTrabajador.Clear();
            TbxCorreoTrabajador.Clear();
            TbxTelefonoTrabajador.Clear();
            CbxRoles.SelectedIndex = -1;
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
}
