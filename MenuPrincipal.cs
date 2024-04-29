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

            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
        }
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            // no le cambie el nombre pero es el de cerrar sesion xd
            DialogResult result = MessageBox.Show("¿Desea Cerrar Sesion?","Confirmar Cierre de Sesion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            // verificar el resultado del ususario
            if (result == DialogResult.Yes)
            {
                //cerrar sesion y regresar al formulario del loggin
                // Verificar si ya hay una instancia del formulario de inicio de sesión
                FormLogin formLogin = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
                if (formLogin != null)
                {
                    // Si ya hay una instancia, mostrarla y cerrar el formulario actual
                    formLogin.Show();
                    this.Close();
                }
                else
                {
                    // Si no hay una instancia, crear una nueva instancia y mostrarla
                    formLogin = new FormLogin();
                    formLogin.Show();
                    this.Close();
                }
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

        private void BtnIDNiños_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de los niños
            IDNiños formularioIDNiños = new IDNiños();
            // Mostrar el formulario de los niños
            formularioIDNiños.Show();
            // Cerrar el formulario actual
            this.Close();
        }


        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de asistencia
            Asistencia FormAsistencia = new Asistencia();
            // Mostrar el formulario de asistencia
            FormAsistencia.Show();
            // Cerrar el formulario actual
            this.Close();
        }

        private void BtnClientesPadres_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de los clientes
            Clientes FormClientes = new Clientes();
            // Mostrar el formulario de los clientes
            FormClientes.Show();
            // Cerrar el formulario actual
            this.Close();
        }

        private void BtnEventos_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de eventos
            Eventos FormEventos = new Eventos();
            // Mostrar el formulario de eventos
            FormEventos.Show();
            // Cerrar el formulario actual
            this.Close();
        }

        private void BtnListaDeTrabajadores_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de lso trabajadores
            Trabajadores FormTrabajadores = new Trabajadores();
            // Mostrar el formulario de trabajadores
            FormTrabajadores.Show();
            // Cerrar el formulario actual
            this.Close();
        }
    }
}
