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
using MySql.Data.MySqlClient;

namespace RDGweb
{
    public partial class AñadirIncidencias : Form
    {
        public AñadirIncidencias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=guarderia;port=3306;password=";
            string queryCliente = "INSERT INTO incidencias (IdNiño, FechaIncidencia, Descripcion) VALUES (@IdNiño, @Fecha, @Descripcion)";

            // Validación de IdNiño
            if (!int.TryParse(TextID.Text, out int idNiño))
            {
                MessageBox.Show("El ID del niño debe ser un número entero.");
                return; // Detener la ejecución si la validación falla
            }

            // Validación de FechaIncidencia
            if (!DateTime.TryParseExact(TextFechaIncidencia.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime fechaIncidencia))
            {
                MessageBox.Show("La fecha de incidencia debe estar en el formato AAAA-MM-DD.");
                return; // Detener la ejecución si la validación falla
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Insertando en la tabla incidencias
                    using (MySqlCommand cmd = new MySqlCommand(queryCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdNiño", idNiño);
                        cmd.Parameters.AddWithValue("@Fecha", fechaIncidencia);  // Usar el objeto DateTime validado
                        cmd.Parameters.AddWithValue("@Descripcion", TextDescripcion.Text);

                        cmd.ExecuteNonQuery();
                    }

                    // Mostrar mensaje de éxito
                    MessageBox.Show("La información se ha añadido correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
            }
        }
    }
}
