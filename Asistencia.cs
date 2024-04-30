using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RDGweb
{
    public partial class Asistencia : Form
    {
        MySqlConnection conexion;

        public Asistencia()
        {
            InitializeComponent();
            // Inicializar la conexión a la base de datos
            string cadenaConexion = "server=localhost;user=root;password=;database=guarderia;";
            conexion = new MySqlConnection(cadenaConexion);
            LlenarGridConNiños();
        }

        private void LlenarGridConNiños()
        {
            try
            {
                conexion.Open();
                string query = "SELECT Nombre FROM niños";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                DgvAsistencia.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnTomarAsistencia_Click(object sender, EventArgs e)
        {
            // Verificamos si se ha seleccionado una fila en el DataGridView
            if (DgvAsistencia.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = DgvAsistencia.SelectedRows[0].Index;

                // Obtener el nombre del niño de la primera columna del DataGridView
                string nombreNiño = DgvAsistencia.Rows[indiceFila].Cells[0].Value.ToString();

                // Mostrar un mensaje indicando que se ha tomado la asistencia para el niño seleccionado
                MessageBox.Show("Se ha tomado la asistencia para " + nombreNiño);

                // No es necesario marcar asistencia en el DataGridView, ya que se sigue mostrando el nombre del niño
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para marcar la asistencia.");
            }
        }

        private void BtnFalta_Click(object sender, EventArgs e)
        {
            // Verificamos si se ha seleccionado una fila en el DataGridView
            if (DgvAsistencia.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = DgvAsistencia.SelectedRows[0].Index;

                // Obtener el nombre del niño de la primera columna del DataGridView
                string nombreNiño = DgvAsistencia.Rows[indiceFila].Cells[0].Value.ToString();

                // Mostrar un mensaje indicando que se ha marcado falta para el niño seleccionado
                MessageBox.Show("Se ha marcado falta para " + nombreNiño);

                // No es necesario marcar falta en el DataGridView, ya que se sigue mostrando el nombre del niño
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para marcar la falta.");
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
