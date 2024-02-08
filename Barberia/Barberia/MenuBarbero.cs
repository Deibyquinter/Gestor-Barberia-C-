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
    public partial class MenuBarbero : Form
    {
        public MenuBarbero()
        {
            InitializeComponent();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new Iniciar_sesion().Show();
        }

        private void btn_gestionarCitas_Click(object sender, EventArgs e)
        {
            this.Close();
            new GestionarCitas().Show();
        }
    }



}
