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
    public partial class IDNiños : Form
    {
        public IDNiños()
        {
            InitializeComponent();
        }

        private void BtnBackMenu_Click(object sender, EventArgs e)
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
