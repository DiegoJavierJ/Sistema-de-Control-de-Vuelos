﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SisControlVuelo
{
    public class ConnectionClass
    {
        public static SqlConnection Connect(){

            SqlConnection conect = new SqlConnection("Server=LAPTOP-QPULMOF2;Database=DB_ControlDeVuelos;Trusted_Connection=True;");

            conect.Open();

            return conect;
        }
    }
}