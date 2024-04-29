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
       
        public Eventos()
        {
            InitializeComponent();
           
        }
        private void BtnVolverMenuEvento_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MenuPrincipal
            MenuPrincipal formularioMenuPrincipal = new MenuPrincipal();
            // Mostrar el formulario MenuPrincipal
            formularioMenuPrincipal.Show();
            // Cerrar el formulario actual
            this.Close();
        }
        private void CbxSeleccionactividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }  
}
