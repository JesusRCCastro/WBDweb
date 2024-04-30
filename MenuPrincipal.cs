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
        public MenuPrincipal(string usuario)
        {
            InitializeComponent();
            MostrarFormulario(new FormInicio());
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            lblUsername.Text = usuario;
        }

        private void MostrarFormulario(Form formulario)
        {
            //limpar el panel
            panelCentral.Controls.Clear();

            //mostar el formulario en el panel central
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            //ajustar el tamaño
            formulario.Size = panelCentral.ClientSize;
            //establecer el form para que se ajuste al tamaño del panel
            formulario.Dock = DockStyle.Fill;
            //agrega el form al panel
            panelCentral.Controls.Add(formulario);
            //mostrar el form
            formulario.Show();
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
            MostrarFormulario(new Incidencias());
        }

        private void BtnIDNiños_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new IDNiños());
        }


        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Asistencia());
        }

        private void BtnClientesPadres_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Clientes());
        }

        private void BtnEventos_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Eventos());
        }

        private void BtnListaDeTrabajadores_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new Trabajadores());
        }

    }
}
