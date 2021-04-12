using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SisControlVuelo
{
    public class ConnectionClass
    {
        public static SqlConnection Connect(){

            SqlConnection conect = new SqlConnection(@"Server = 35.192.17.65; Database = ControlDeVuelosDB; User Id = sqlserver; Password = LCK09octP2HkAA9M");

            conect.Open();

            return conect;
        }
    }
}
