using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barberia
{
    public partial class Iniciar_sesion : Form
    {
        public Iniciar_sesion()
        {
            InitializeComponent();
        }

        private void Iniciar_sesion_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();

            

            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*)FROM USUARIOS WHERE USUARIO='" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "'", Conexion.Conectar());

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString()=="1")
            {

                if (comboUsuario.SelectedItem == "Administrador")
                {
                    new MenuAdmin().Show();


                }
                else
                    if (comboUsuario.SelectedItem == "Usuario")
                {

                    new MenuUsuario().Show();

                }
                else
                    if (comboUsuario.SelectedItem == "Barbero")
                {

                    new MenuBarbero().Show();
                }

                    this.Hide();
                
            }
            else 
            {
                MessageBox.Show("acceso denegado"); 
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
