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
    public partial class CrearServicio : Form
    {
        public CrearServicio()
        {
            InitializeComponent();
        }

        private void CrearServicio_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

            tablaServicios.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM SERVICIOS";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;

        }

        private void tablaServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dar click para que aparezcan los datos en las columnas
                txt_codigoServicio.Text = tablaServicios.CurrentRow.Cells[0].Value.ToString();
                txt_NombreServicio.Text = tablaServicios.CurrentRow.Cells[1].Value.ToString();
                txt_valorServicio.Text = tablaServicios.CurrentRow.Cells[2].Value.ToString();
                
            }

            catch { }
        }

        private void btn_crearServicio_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO SERVICIOS (CODIGO,SERVICIO,VALOR)VALUES(@CODIGO,@SERVICIO,@VALOR)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", txt_codigoServicio.Text);
            cmd1.Parameters.AddWithValue("@SERVICIO", txt_NombreServicio.Text);
            cmd1.Parameters.AddWithValue("@VALOR", txt_valorServicio.Text);
            

            cmd1.ExecuteNonQuery();
            MessageBox.Show("los datos fueron agregados correctamente");

            tablaServicios.DataSource = llenar_grid();
        }

        private void btn_modificarServicio_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE SERVICIOS SET CODIGO=@CODIGO, SERVICIO=@SERVICIO, VALOR=@VALOR WHERE CODIGO=@CODIGO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@CODIGO", txt_seleccionCodigoServicio.Text);
            cmd2.Parameters.AddWithValue("@SERVICIO", txt_NombreServicio.Text);
            cmd2.Parameters.AddWithValue("@VALOR", txt_valorServicio.Text);
            
            cmd2.ExecuteNonQuery();
            MessageBox.Show("los datos fueron actualizados con exito");
            tablaServicios.DataSource = llenar_grid();
        }

        private void btn_eliminarServicio_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM SERVICIOS WHERE CODIGO=@CODIGO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());

            cmd3.Parameters.AddWithValue("@CODIGO", txt_seleccionCodigoServicio.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("los datos fueron eliminados con exito");
            tablaServicios.DataSource = llenar_grid();
        }

        private void verMenuAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuAdmin().Show();
        }


    }
}
