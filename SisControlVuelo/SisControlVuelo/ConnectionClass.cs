using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SisControlVuelo
{
    class ConnectionClass
    {
        public static SqlConnection Connect()
        {
            SqlConnection conect = new SqlConnection();

            conect.Open();

            return conect;
        }
    }
}
