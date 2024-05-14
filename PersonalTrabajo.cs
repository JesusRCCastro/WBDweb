using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace RDGweb
{
    public partial class PersonalTrabajo : Form
    {
        private DataTable dt; // Variable para almacenar los datos originales

        public PersonalTrabajo()
        {
            InitializeComponent();
            LlenarGridConActividades();
            DgvTrabajadores.ReadOnly = true;
            BtnEliminarTrabajador.Click += BtnEliminarTrabajador_Click;
            DgvTrabajadores.CellClick += DgvTrabajadores_CellClick;
            TbxBuscarEmpleado.TextChanged += TbxBuscarEmpleado_TextChanged;
        }

        private void LlenarGridConActividades()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = @"
                        SELECT p.idPersonal, p.Nombre, r.Nombre AS RolNombre, p.Correo, p.Telefono
                        FROM personal p
                        JOIN roles r ON p.rol_id = r.id";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            dt = new DataTable(); // Inicializar el DataTable
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

        private void BtnEliminarTrabajador_Click(object sender, EventArgs e)
        {
            if (DgvTrabajadores.SelectedCells.Count > 0)
            {
                int selectedRowIndex = DgvTrabajadores.SelectedCells[0].RowIndex;
                DataGridViewRow row = DgvTrabajadores.Rows[selectedRowIndex];
                string idPersonal = row.Cells["idPersonal"].Value.ToString();
                string nombre = row.Cells["Nombre"].Value.ToString();

                DialogResult result = MessageBox.Show($"¿Estás seguro que deseas eliminar a {nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    EliminarTrabajador(idPersonal);
                    // Limpiar el TextBox de búsqueda
                    TbxBuscarEmpleado.Text = "";
                }
                if (result == DialogResult.No)
                {
                    // Limpiar el TextBox de búsqueda
                    TbxBuscarEmpleado.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un trabajador para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpiar el TextBox de búsqueda
                TbxBuscarEmpleado.Text = "";
            }
        }

        private void EliminarTrabajador(string idPersonal)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;user=root;password=;database=guarderia;"))
                {
                    conexion.Open();
                    string query = "DELETE FROM personal WHERE idPersonal = @idPersonal";
                    using (MySqlCommand comando = new MySqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idPersonal", idPersonal);

                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Trabajador eliminado correctamente.");
                            LlenarGridConActividades(); // Actualizar DataGridView si es necesario
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el trabajador.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el trabajador: " + ex.Message);
            }
        }

        private void DgvTrabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DgvTrabajadores.ClearSelection();
                DgvTrabajadores.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            }
        }

        private void TbxBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = TbxBuscarEmpleado.Text.Replace("'", "''");
                string query = string.Format("Nombre LIKE '%{0}%' OR Telefono LIKE '%{0}%'", filter); // Excluyendo idPersonal
                (DgvTrabajadores.DataSource as DataTable).DefaultView.RowFilter = query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }


        private DataTable FiltrarDataTable(DataTable dt, string columnName, string filter)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("{0} LIKE '%{1}%'", columnName, filter);
            return dv.ToTable();
        }

    }
}
