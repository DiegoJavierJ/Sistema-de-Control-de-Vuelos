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

        public DataSet GetOneFlight(int ID)
        {
            SqlDataAdapter Adapt = new SqlDataAdapter();
            Adapt.TableMappings.Add("Table", "Vuelo");
            SqlCommand comnd = new SqlCommand();
            comnd.Connection = ConnectionClass.Connect();
            comnd.CommandText = "EXEC dbo.STP_Vuelo_SLTONE " + ID;
            comnd.CommandType = CommandType.Text;
            Adapt.SelectCommand = comnd;
            DataSet dts = new DataSet("vuelo");
            Adapt.Fill(dts);
            return dts;
        }

        public DataSet GetFlightByAirport(string airport)
        {
            SqlDataAdapter Adapt = new SqlDataAdapter();
            Adapt.TableMappings.Add("Table", "Vuelo");
            SqlCommand comnd = new SqlCommand();
            comnd.Connection = ConnectionClass.Connect();
            comnd.CommandText = $"EXEC dbo.STP_VuelosPorAeropuerto_SLT '{airport}'";
            comnd.CommandType = CommandType.Text;
            Adapt.SelectCommand = comnd;
            DataSet dts = new DataSet("vuelo");
            Adapt.Fill(dts);
            return dts;
        }

        public DataSet GetFlightByAirline(string airline)
        {
            SqlDataAdapter Adapt = new SqlDataAdapter();
            Adapt.TableMappings.Add("Table", "Vuelo");
            SqlCommand comnd = new SqlCommand();
            comnd.Connection = ConnectionClass.Connect();
            comnd.CommandText = $"EXEC dbo.STP_VuelosPorAerolinea_SLT '{airline}'";
            comnd.CommandType = CommandType.Text;
            Adapt.SelectCommand = comnd;
            DataSet dts = new DataSet("vuelo");
            Adapt.Fill(dts);
            return dts;
        }

        public DataSet GetFlightByAirportANDAirline(string airport, string airline)
        {
            SqlDataAdapter Adapt = new SqlDataAdapter();
            Adapt.TableMappings.Add("Table", "Vuelo");
            SqlCommand comnd = new SqlCommand();
            comnd.Connection = ConnectionClass.Connect();
            comnd.CommandText = $"dbo.STP_VuelosPorAeropuertoPorAerolinea_SLT '{airport}', '{airline}'";
            comnd.CommandType = CommandType.Text;
            Adapt.SelectCommand = comnd;
            DataSet dts = new DataSet("vuelo");
            Adapt.Fill(dts);
            return dts;
        }
    }
}
