using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SisControlVuelo
{
    public class Personal
    {
        public DataSet GetPersonal()
        {
            SqlDataAdapter Adapt = new SqlDataAdapter();
            Adapt.TableMappings.Add("Table", "Personal");
            SqlCommand comnd = new SqlCommand();
            comnd.Connection = ConnectionClass.Connect();
            comnd.CommandText = "EXEC dbo.STP_Personal_Vuelo_SLTALL";
            comnd.CommandType = CommandType.Text;
            Adapt.SelectCommand = comnd;
            DataSet dts = new DataSet("persona");
            Adapt.Fill(dts);
            return dts;
        }
    }
}
