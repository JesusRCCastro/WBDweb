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
        public Asistencia()
        {
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
          
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
        }

        private void BtnFalta_Click(object sender, EventArgs e)
        {

        }

        private void Asistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerramos la conexión con la base de datos al cerrar el formulario
           // if (conexion != null && conexion.State == ConnectionState.Open)
            //{
               // conexion.Close();
           // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MenuPrincipal
            MenuPrincipal formularioMenuPrincipal = new MenuPrincipal();
            // Mostrar el formulario MenuPrincipal
            formularioMenuPrincipal.Show();
            // Cerrar el formulario actual
            this.Close();
        }
    }
}
