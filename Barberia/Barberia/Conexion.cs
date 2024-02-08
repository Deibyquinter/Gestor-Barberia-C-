using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barberia
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DEIBYQUINTER;DATABASE=bd_barber;integrated security=true;");

            cn.Open();
            return cn;

        }
    }
}
