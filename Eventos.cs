using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace RDGweb
{
    public partial class Eventos : Form
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        public Eventos()
        {
            InitializeComponent();
            // Inicializar la conexión a la base de datos
            string cadenaConexion = "server=localhost;user=root;password=;database=guarderia;";
            conexion = new MySqlConnection(cadenaConexion);
            LlenarGridConActividades();
            // Configurar el DataGridView como de solo lectura
            DgvEventos.ReadOnly = true;

            // Opcional: Configurar cada columna como de solo lectura
            foreach (DataGridViewColumn column in DgvEventos.Columns)
            {
                column.ReadOnly = true;
            }

            // Deshabilitar la edición
            DgvEventos.AllowUserToAddRows = false;    // Deshabilitar la adición de filas por el usuario
            DgvEventos.AllowUserToDeleteRows = false; // Deshabilitar la eliminación de filas por el usuario
            DgvEventos.AllowUserToOrderColumns = false; // Deshabilitar la reordenación de columnas por el usuario
            DgvEventos.AllowUserToResizeColumns = false; // Deshabilitar el redimensionamiento de columnas por el usuario
            DgvEventos.AllowUserToResizeRows = false; // Deshabilitar el redimensionamiento de filas por el usuario

        }
        private void LlenarGridConActividades()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "SELECT * FROM actividades";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            DgvEventos.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void BtnagregarEvento_Click(object sender, EventArgs e)
        {
            // Comprobar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TbxNombreActividad.Text) || string.IsNullOrWhiteSpace(TbxEstablecerFecha.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
            }
            else
            {
                InsertarActividad(TbxNombreActividad.Text, TbxEstablecerFecha.Text);
            }

        }
        private void InsertarActividad(string nombreActividad, string fechaActividad)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "INSERT INTO actividades (NombreAct, Horario) VALUES (@nombre, @fecha)";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombre", nombreActividad);
                        comando.Parameters.AddWithValue("@fecha", fechaActividad);

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
