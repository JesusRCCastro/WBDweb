using MySql.Data.MySqlClient;
using System;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RDGweb
{
    public partial class AgregarNiño : Form
    {
        private Padre padreSeleccionado;
        public AgregarNiño()
        {
            InitializeComponent();
            CargarPadres(); // Cargar padres existentes al ComboBox
            ObtenerSiguienteIDNiño(); // Obtener el siguiente ID para el nuevo niño
        }

        private void ObtenerSiguienteIDNiño()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "SELECT MAX(idNiño) AS max_id FROM niños";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        object result = comando.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int maxID = Convert.ToInt32(result);
                            tbxIdNiño.Text = (maxID + 1).ToString();
                        }
                        else
                        {
                            tbxIdNiño.Text = "1";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID del niño: " + ex.Message);
            }
        }

        private void CargarPadres()
        {
            string connectionString = "server=localhost;user=root;password=;database=guarderia;";

            string query = "SELECT idCliente, Nombre FROM cliente";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["idCliente"]);
                            string nombre = reader["Nombre"].ToString();
                            Padre padre = new Padre(id, nombre);
                            cbxPadreNiñoNuevo.Items.Add(padre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los padres: " + ex.Message);
            }
        }

        private void BtnAgregarNiño_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (string.IsNullOrWhiteSpace(tbxNombreNiño.Text) ||
                string.IsNullOrWhiteSpace(MaskFechanuevo.Text) ||
                string.IsNullOrWhiteSpace(TbxNumeroNuevo.Text) ||
                string.IsNullOrWhiteSpace(CbxGeneroNuevoNiño.Text) ||
                string.IsNullOrWhiteSpace(tbxIdNiño.Text) ||
                string.IsNullOrWhiteSpace(tbxEdadNiño.Text) ||
                cbxPadreNiñoNuevo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (!int.TryParse(tbxEdadNiño.Text, out int edad) || edad > 4)
            {
                MessageBox.Show("La edad del niño debe ser un número entero y no puede ser mayor a 4 años.");
                return;
            }


            if (!DateTime.TryParse(MaskFechanuevo.Text, out _))
            {
                MessageBox.Show("La fecha de nacimiento es invalida no puede ser mayor a la fecha actual, recuerde que tiene que estar en el formato AAAA-MM-DD");
                return;
            }
            if (!Regex.IsMatch(TbxNumeroNuevo.Text, @"^\d{10}$"))
            {
                MessageBox.Show("El Numero de Contacto debe contener exactamente 10 dígitos.");
                return;
            }
            if (!(CbxGeneroNuevoNiño.Text == "Masculino" || CbxGeneroNuevoNiño.Text == "Femenino"))
            {
                MessageBox.Show("El género solo puede ser 'Masculino' o 'Femenino'.");
                return;
            }
            if (!Regex.IsMatch(tbxNombreNiño.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El Nombre no puede incluir numeros o espacios vacios");
                return;
            }
            

            Padre padreSeleccionado = (Padre)cbxPadreNiñoNuevo.SelectedItem;

            string connectionString = "server=localhost;user=root;database=guarderia;port=3306;password=";
            string query = "INSERT INTO niños (Nombre, Edad, id_Padre, Genero, `Fecha de Nacimiento`, NumContacto) VALUES (@Nombre, @Edad, @IdPadre, @Genero, @FechaNacimiento, @Contacto);";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", tbxNombreNiño.Text);
                        cmd.Parameters.AddWithValue("@Edad", Convert.ToInt32(tbxEdadNiño.Text));
                        cmd.Parameters.AddWithValue("@IdPadre", padreSeleccionado.Id);
                        cmd.Parameters.AddWithValue("@Genero", CbxGeneroNuevoNiño.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@FechaNacimiento",MaskFechanuevo.Text);
                        cmd.Parameters.AddWithValue("@Contacto",TbxNumeroNuevo.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Niño agregado correctamente.");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el niño: " + ex.Message);
            }
        }
       

        private void LimpiarCampos()
        {
            tbxNombreNiño.Clear();
            tbxEdadNiño.Clear();
            cbxPadreNiñoNuevo.SelectedIndex = -1;
            ObtenerSiguienteIDNiño();
        }
    }

    public class Padre
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Padre(int id, string nombre)
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
