using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisControlVuelo
{
    public partial class RemoverVueloPage : Form
    {
        public RemoverVueloPage()
        {
            InitializeComponent();
        }

        private void btn_RemoverVuelo_Click(object sender, EventArgs e)
        {
            SqlConnection sql = ConnectionClass.Connect();
            SqlCommand cmd = new SqlCommand("dbo.STP_Vuelo_DLT", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@varIDVuelo", int.Parse(tbx_NumVuelo.Text));

            int i = cmd.ExecuteNonQuery();
            sql.Close();

            if(i != 0)
            {
                MessageBox.Show(i + "Data Removed");
            }
        }
    }
}
