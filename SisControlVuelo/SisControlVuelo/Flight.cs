using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SisControlVuelo
{
    public class Flight
    {
        public DataSet GetFlight()
        {
            SqlDataAdapter Adapt = new SqlDataAdapter();
            Adapt.TableMappings.Add("Table", "Vuelo");
            SqlCommand comnd = new SqlCommand();
            comnd.Connection = ConnectionClass.Connect();
            comnd.CommandText = "EXEC dbo.STP_Vuelo_SLTALL";
            comnd.CommandType = CommandType.Text;
            Adapt.SelectCommand = comnd;
            DataSet dts = new DataSet("vuelo");
            Adapt.Fill(dts);
            return dts;
        }
    }
}
