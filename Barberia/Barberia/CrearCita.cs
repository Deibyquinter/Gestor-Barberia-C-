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
    public partial class CrearCita : Form
    {
        

        public CrearCita()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

            tablaCitas.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM CITA";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;

        }

        private void tablaCitas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dar click para que aparezcan los datos en las columnas
                txt_codigoCita.Text = tablaCitas.CurrentRow.Cells[0].Value.ToString();
                txt_NombreCliente.Text = tablaCitas.CurrentRow.Cells[1].Value.ToString();
                txt_dia.Text = tablaCitas.CurrentRow.Cells[2].Value.ToString();
                txt_hora.Text = tablaCitas.CurrentRow.Cells[3].Value.ToString();

            }

            catch { }
        }


        private void btn_crearCita_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO CITA (CODIGO,NOMBRE,DIA,HORA)VALUES(@CODIGO,@NOMBRE,@DIA,@HORA)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO", txt_codigoCita.Text);
            cmd1.Parameters.AddWithValue("@NOMBRE", txt_NombreCliente.Text);
            cmd1.Parameters.AddWithValue("@DIA", txt_dia.Text);
            cmd1.Parameters.AddWithValue("@HORA", txt_hora.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("los datos fueron agregados correctamente");

            tablaCitas.DataSource = llenar_grid();
        }

        private void btn_modificarCita_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE CITA SET CODIGO=@CODIGO, NOMBRE=@NOMBRE, DIA=@DIA, HORA=@HORA WHERE CODIGO=@CODIGO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue("@CODIGO", txt_seleccionCodigoCita.Text);
            cmd2.Parameters.AddWithValue("@NOMBRE", txt_NombreCliente.Text);
            cmd2.Parameters.AddWithValue("@DIA", txt_dia.Text);
            cmd2.Parameters.AddWithValue("@HORA", txt_hora.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("los datos fueron actualizados con exito");
            tablaCitas.DataSource = llenar_grid();
        }

        private void btn_eliminarCita_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM CITA WHERE CODIGO=@CODIGO";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());

            cmd3.Parameters.AddWithValue("@CODIGO", txt_seleccionCodigoCita.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("los datos fueron eliminados con exito");
            tablaCitas.DataSource = llenar_grid();
        }

        private void ver_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuUsuario().Show();
        }
    }
}
