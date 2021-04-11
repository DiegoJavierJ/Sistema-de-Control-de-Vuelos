using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SisControlVuelo
{
    public partial class AddAirlinePage : Form
    {
        public AddAirlinePage()
        {
            InitializeComponent();
        }

        private void btn_AgregarAerolinea_Click(object sender, EventArgs e)
        {
            SqlConnection sql = ConnectionClass.Connect();
            SqlCommand cmd = new SqlCommand("dbo.STP_Aerolinea_INS", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@varNombre", textBox1.Text);
            cmd.Parameters.AddWithValue("@varIDPais", int.Parse(textBox2.Text));

            int i = cmd.ExecuteNonQuery();
            sql.Close();

            if(i != 0) 
            {
                MessageBox.Show(i + "Data Saved");
            }
        }
    }
}
