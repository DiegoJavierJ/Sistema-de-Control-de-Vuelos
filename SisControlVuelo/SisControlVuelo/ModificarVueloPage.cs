using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisControlVuelo
{
    public partial class ModificarVueloPage : Form
    {
        public ModificarVueloPage()
        {
            InitializeComponent();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = ConnectionClass.Connect();
            SqlCommand cmd = new SqlCommand("dbo.STP_Vuelo_UPD", sql);
            cmd.CommandType = CommandType.StoredProcedure;
        }

        private void ModificarVueloPage_Load(object sender, EventArgs e)
        {

        }
    }
}
