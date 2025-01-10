using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemasPedidos
{
    internal class BDGeneral
    {
       public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = SEGUIMIENTOPEDIDOS; Data Source = DESKTOP-HTSSO6T\\SQLEXPRESS");
            conexion.Open();
            return conexion;
        }

    }

}
