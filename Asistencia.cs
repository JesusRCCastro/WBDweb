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
    public partial class Asistencia : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        public Asistencia()
        {
            InitializeComponent();
            // Inicializar la conexión a la base de datos
            string cadenaConexion = "server=localhost;user=root;password=;database=guarderia;";
            conexion = new MySqlConnection(cadenaConexion);

        }

        private void BtnBuscarNiño_Click(object sender, EventArgs e)
        {
            // Verificamos si se ingresó un ID de estudiante válido
            if (string.IsNullOrWhiteSpace(TbxIdNiño.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del estudiante.");
                return;
            }

            // Verificamos si el ID del estudiante es un número válido
            if (!int.TryParse(TbxIdNiño.Text, out int idEstudiante))
            {
                MessageBox.Show("El ID del estudiante debe ser un número entero válido.");
                return;
            }

            // Obtener el ID del niño desde el TextBox
            int id = Convert.ToInt32(TbxIdNiño.Text);

            // Consulta para obtener la información del niño
            string consulta = "SELECT Nombre FROM niños WHERE idNiño = @id";

            try
            {
                conexion.Open();
                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mostrar el nombre del niño en la primera columna del DataGridView
                        DgvAsistencia.Rows.Add(reader["nombre"].ToString(), "", "");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún niño con ese ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el niño: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnTomarAsistencia_Click(object sender, EventArgs e)
        {
            // Verificamos si se ingresó un ID de estudiante válido
            if (string.IsNullOrWhiteSpace(TbxIdNiño.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del estudiante.");
                return;
            }

            // Verificamos si el ID del estudiante es un número válido
            if (!int.TryParse(TbxIdNiño.Text, out int idEstudiante))
            {
                MessageBox.Show("El ID del estudiante debe ser un número entero válido.");
                return;
            }

            // Obtener el índice de la fila seleccionada
            int indiceFila = DgvAsistencia.CurrentRow.Index;

            // Obtener el ID del niño
            int id = Convert.ToInt32(TbxIdNiño.Text);

            // Marcar asistencia en la segunda columna del DataGridView
            DgvAsistencia.Rows[indiceFila].Cells[1].Value = "Asistencia";

            // Guardar en la base de datos la asistencia del niño
            string consulta = "UPDATE asistencia SET Presencia = 1 WHERE idNiño = @id";

            try
            {
                conexion.Open();
                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar la asistencia: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        private void BtnFalta_Click(object sender, EventArgs e)
        {
            // Verificamos si se ingresó un ID de estudiante válido
            if (string.IsNullOrWhiteSpace(TbxIdNiño.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del estudiante.");
                return;
            }

            // Verificamos si el ID del estudiante es un número válido
            if (!int.TryParse(TbxIdNiño.Text, out int idEstudiante))
            {
                MessageBox.Show("El ID del estudiante debe ser un número entero válido.");
                return;
            }

            // Obtener el índice de la fila seleccionada
            int indiceFila = DgvAsistencia.CurrentRow.Index;

            // Obtener el ID del niño
            int id = Convert.ToInt32(TbxIdNiño.Text);

            // Marcar falta en la tercera columna del DataGridView
            DgvAsistencia.Rows[indiceFila].Cells[1].Value = "Falta";

            // Guardar en la base de datos la falta del niño
            string consulta = "UPDATE asistencia SET Ausente = 1 WHERE idNiño = @id";

            try
            {
                conexion.Open();
                comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar la falta: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        private void Asistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerramos la conexión con la base de datos al cerrar el formulario
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
