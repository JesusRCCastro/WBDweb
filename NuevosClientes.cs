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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=guarderia;port=3306;password=";
            string queryCliente = "INSERT INTO cliente (Nombre, Edad, Dirección, Telefono, NSS, Oficio, Correo) VALUES (@Nombre, @Edad, @Dirección, @Telefono, @NSS, @Oficio, @Correo)";
            string queryNiños = "INSERT INTO niños (Nombre, `FechaNacimiento`, NumContacto, Edad, Genero) VALUES (@NombreNiño, @FechaNacimiento, @NumContacto, @EdadNiño, @GeneroNiño)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Insertando en la tabla cliente
                    using (MySqlCommand cmd = new MySqlCommand(queryCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", TextBoxNuevoNombreCliente.Text);
                        cmd.Parameters.AddWithValue("@Edad", TextBoxNuevoEdadCliente.Text);
                        cmd.Parameters.AddWithValue("@Dirección", TextBoxNuevoDirrecionCliente.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TextBoxNuevoCelularCliente.Text);
                        cmd.Parameters.AddWithValue("@NSS", TextBoxNuevoNSS.Text);
                        cmd.Parameters.AddWithValue("@Oficio", TextBoxNuevoOficio.Text);
                        cmd.Parameters.AddWithValue("@Correo", TextBoxNuevoCorreo.Text);

                        cmd.ExecuteNonQuery();
                    }

                    // Insertando en la tabla niños
                    using (MySqlCommand cmd = new MySqlCommand(queryNiños, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreNiño", TextBoxNuevoNombreNiño.Text);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", TextBoxNuevaFechaNiño.Text);
                        cmd.Parameters.AddWithValue("@NumContacto", TextBoxNuevoNumeroContacto.Text);
                        cmd.Parameters.AddWithValue("@EdadNiño", TextBoxNuevaEdadNiño.Text);
                        cmd.Parameters.AddWithValue("@GeneroNiño", TextBoxActividad.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar datos: " + ex.Message);
                }
            }
        }
    }
}
