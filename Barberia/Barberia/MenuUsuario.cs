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
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            new Iniciar_sesion().Show();    
        }

        private void btn_verCita_Click(object sender, EventArgs e)
        {
            this.Close();
            new CrearCita().Show(); 
        }

        private void btn_verPago_Click(object sender, EventArgs e)
        {
            this.Close();
            new PagoUsuario().Show();   
        }
    }
}
