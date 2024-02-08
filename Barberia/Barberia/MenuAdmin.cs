using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barberia
{
    public partial class MenuAdmin : Form
    {
   
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void verServicio_Click(object sender, EventArgs e)
        {
            this.Close();
            new CrearServicio().Show();

        }

        private void btn_verUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            new CrearUsuario().Show();
        }

        private void btn_verEmergencia_Click(object sender, EventArgs e)
        {
            this.Close();
            new CrearEmergencia().Show();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new Iniciar_sesion().Show();
        }



    }
}
