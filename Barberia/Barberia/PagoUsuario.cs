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
    public partial class PagoUsuario : Form
    {
        public PagoUsuario()
        {
            InitializeComponent();
        }

        private void PagoUsuario_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

            tablaPagos.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM PAGOS";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }

        private void tablaPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //dar click para que aparezcan los datos en las columnas
                txt_celular.Text = tablaPagos.CurrentRow.Cells[0].Value.ToString();
                txt_cantidad.Text = tablaPagos.CurrentRow.Cells[1].Value.ToString();
                txt_mensaje.Text = tablaPagos.CurrentRow.Cells[2].Value.ToString();
                

            }

            catch { }
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO PAGOS (CELULAR,CANTIDAD,MENSAJE)VALUES(@CELULAR,@CANTIDAD,@MENSAJE)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CELULAR", txt_celular.Text);
            cmd1.Parameters.AddWithValue("@CANTIDAD", txt_cantidad.Text);
            cmd1.Parameters.AddWithValue("@MENSAJE", txt_mensaje.Text);
            

            cmd1.ExecuteNonQuery();
            MessageBox.Show("PAGO REALIZADO CORRECTAMENTE");

            tablaPagos.DataSource = llenar_grid();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuUsuario().Show();
        }





        //
    }
}
