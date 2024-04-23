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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

            button7.Click += button7_Click;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // no le cambie el nombre pero es el de cerrar sesion xd
            DialogResult result = MessageBox.Show("¿Desea Cerrar Sesion?","Confirmar Cierre de Sesion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            // verificar el resultado del ususario
            if (result == DialogResult.Yes)
            {
                //cerrar sesion y regresar al formulario del loggin
                Form FormLogin =new FormLogin();
                FormLogin.Show();
                this.Close();
            }
        }

        private void BtnIncidencias_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de incidencias
            Incidencias formularioIncidencias = new Incidencias();
            // Mostrar el formulario de incidencias
            formularioIncidencias.Show();
            // Cerrar el formulario actual
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de incidencias
            IDNiños formularioIDNiños = new IDNiños();
            // Mostrar el formulario de incidencias
            formularioIDNiños.Show();
            // Cerrar el formulario actual
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crea una instancia que muestre el formulario de lista de trabajadores
            

        }

        private void BtnClientesPadres_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de incidencias
            Clientes formularioClientes = new Clientes();
            // Mostrar el formulario de incidencias
            formularioClientes.Show();
            // Cerrar el formulario actual
            this.Close();
        }
    }
}
