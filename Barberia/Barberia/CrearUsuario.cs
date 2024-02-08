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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

            tablaUsuarios.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM USUARIOS";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;

        }
        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dar click para que aparezcan los datos en las columnas
                txt_codigoUsuario.Text = tablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                txt_NombreUsuario.Text = tablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                txt_contraseña.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();

            }

            catch { }
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO USUARIOS (CODIGO,USUARIO,CONTRASEÑA)VALUES(@CODIGO,@USUARIO,@CONTRASEÑA)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", txt_codigoUsuario.Text);
            cmd1.Parameters.AddWithValue("@USUARIO", txt_NombreUsuario.Text);
            cmd1.Parameters.AddWithValue("@CONTRASEÑA", txt_contraseña.Text);


            cmd1.ExecuteNonQuery();
            MessageBox.Show("los datos fueron agregados correctamente");

            tablaUsuarios.DataSource = llenar_grid();
        }

        private void btn_modificarUsuario_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE USUARIOS SET CODIGO=@CODIGO, USUARIO=@USUARIO, CONTRASEÑA=@CONTRASEÑA WHERE CODIGO=@CODIGO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@CODIGO", txt_seleccionCodigoUsuario.Text);
            cmd2.Parameters.AddWithValue("@USUARIO", txt_NombreUsuario.Text);
            cmd2.Parameters.AddWithValue("@CONTRASEÑA", txt_contraseña.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("los datos fueron actualizados con exito");
            tablaUsuarios.DataSource = llenar_grid();
        }

        private void btn_eliminarUsuario_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM USUARIOS WHERE CODIGO=@CODIGO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());

            cmd3.Parameters.AddWithValue("@CODIGO", txt_seleccionCodigoUsuario.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("los datos fueron eliminados con exito");
            tablaUsuarios.DataSource = llenar_grid();
        }

        private void verMenuAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuAdmin().Show();
        }







    }
}
