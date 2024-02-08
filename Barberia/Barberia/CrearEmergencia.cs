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
    public partial class CrearEmergencia : Form
    {
        public CrearEmergencia()
        {
            InitializeComponent();
        }

        private void CrearEmergencia_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

            tablaEmergencia.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM EMERGENCIAS";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;

        }
        private void tablaEmergencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dar click para que aparezcan los datos en las columnas
                txt_codigoEmergencia.Text = tablaEmergencia.CurrentRow.Cells[0].Value.ToString();
                txt_nombreEmergencia.Text = tablaEmergencia.CurrentRow.Cells[1].Value.ToString();
                txt_NumeroUsuario.Text = tablaEmergencia.CurrentRow.Cells[2].Value.ToString();
                txt_correoUsuario.Text = tablaEmergencia.CurrentRow.Cells[3].Value.ToString();
            }

            catch { }
        }

        private void btn_crearEmergencia_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO EMERGENCIAS (CODIGO,NOMBRE,NUMERO_USUARIO,CORREO_USUARIO)VALUES(@CODIGO,@NOMBRE,@NUMERO_USUARIO,@CORREO_USUARIO)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", txt_codigoEmergencia.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE", txt_nombreEmergencia.Text);
            cmd1.Parameters.AddWithValue("@NUMERO_USUARIO", txt_NumeroUsuario.Text);
            cmd1.Parameters.AddWithValue("@CORREO_USUARIO", txt_correoUsuario.Text);



            cmd1.ExecuteNonQuery();
            MessageBox.Show("los datos fueron agregados correctamente");

            tablaEmergencia.DataSource = llenar_grid();
        }

        private void btn_modificarEmergencia_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE EMERGENCIAS SET @CODIGO=@CODIGO,@NOMBRE,@NUMERO_USUARIO,@CORREO_USUARIO WHERE CODIGO=@CODIGO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@CODIGO", txt_codigoEmergencia.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", txt_nombreEmergencia.Text);
            cmd2.Parameters.AddWithValue("@NUMERO_USUARIO", txt_NumeroUsuario.Text);
            cmd2.Parameters.AddWithValue("@CORREO_USUARIO", txt_correoUsuario.Text);


            cmd2.ExecuteNonQuery();
            MessageBox.Show("los datos fueron actualizados con exito");
            tablaEmergencia.DataSource = llenar_grid();
        }

        private void btn_eliminarEmergencia_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM EMERGENCIAS WHERE CODIGO=@CODIGO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());

            cmd3.Parameters.AddWithValue("@CODIGO", txt_seleccionCodigoEmergencia.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("los datos fueron eliminados con exito");
            tablaEmergencia.DataSource = llenar_grid();
        }

        private void verMenuAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuAdmin().Show();
        }
    }
}
