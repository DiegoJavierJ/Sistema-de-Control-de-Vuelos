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
        int FlightId;
        string nombre; 
        string nombre1;
        string familia;
        string serie;
        DateTime FechaEntrada;
        DateTime FechaSalida;

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
            Flight vuelo = new Flight();
            DGridView_ModificarVuelo.DataSource = vuelo.GetFlight();
            DGridView_ModificarVuelo.DataMember = "Vuelo";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DGridView_ModificarVuelo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGridView_ModificarVuelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Tbx_CodigoVuelo.Text = DGridView_ModificarVuelo.Rows[e.RowIndex].Cells[1].Value.ToString();
            Tbx_Aerolinea.Text = DGridView_ModificarVuelo.Rows[e.RowIndex].Cells[2].Value.ToString();
            Tbx_AeropuertoSalida.Text = DGridView_ModificarVuelo.Rows[e.RowIndex].Cells[5].Value.ToString();
            Tbx_AeropuertoLlegada.Text = DGridView_ModificarVuelo.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
