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
        private MySqlConnection conexion;
        private string cadenaConexion = ("Server = localhost; Database = Guarderia; User Id = root; Password =  ");
        public Asistencia()
        {
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            // Aquí establecemos la conexión con la base de datos al cargar el formulario
            conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
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

            // Verificamos si el estudiante ya ha sido registrado para la asistencia hoy
            string queryVerificar = "SELECT IdNiño, Fecha FROM asistencia WHERE IdNiño = @idEstudiante AND Fecha = @fecha";
            MySqlCommand comandoVerificar = new MySqlCommand(queryVerificar, conexion);
            comandoVerificar.Parameters.AddWithValue("@idEstudiante", idEstudiante);

            try
            {
                int cantidadRegistros = Convert.ToInt32(comandoVerificar.ExecuteScalar());
                if (cantidadRegistros > 0)
                {
                    MessageBox.Show("El estudiante ya ha sido registrado para la asistencia hoy.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la asistencia: " + ex.Message);
                return;
            }

            // Si el estudiante no ha sido registrado hoy, procedemos a registrar la asistencia
            string queryInsertar = "INSERT INTO asistencia (IdNiño, Fecha) VALUES (@idEstudiante, @fecha)";
            MySqlCommand comandoInsertar = new MySqlCommand(queryInsertar, conexion);
            comandoInsertar.Parameters.AddWithValue("@idEstudiante", idEstudiante);
            comandoInsertar.Parameters.AddWithValue("@fecha", DateTime.Now);

            try
            {
                comandoInsertar.ExecuteNonQuery();
                MessageBox.Show("Asistencia registrada correctamente para el estudiante con ID: " + idEstudiante);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la asistencia: " + ex.Message);
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
