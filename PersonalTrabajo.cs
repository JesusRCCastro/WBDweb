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
    public partial class PersonalTrabajo : Form
    {
        public PersonalTrabajo()
        {
            InitializeComponent();
            LlenarGridConActividades();
        }

        private void LlenarGridConActividades()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "SELECT * FROM personal";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            DgvTrabajadores.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void InsertarActividad(string idPersona, string Roles, string Correo, string Nombre, string Telefono)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "INSERT INTO personal (idPersonal, Roles, Correo, Nombre, Telefono) VALUES (@ID, @Rol, @Correo, @Nombre, @Telefono )";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idPersonal", idPersona);
                        comando.Parameters.AddWithValue("@Roles", Roles);
                        comando.Parameters.AddWithValue("@Correo", Correo);
                        comando.Parameters.AddWithValue("@Nombre", Nombre);
                        comando.Parameters.AddWithValue("@Telefono", Telefono);

                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Datos guardados correctamente.");
                            LlenarGridConActividades(); // Actualizar DataGridView si es necesario
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron guardar los datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }
    }
}
