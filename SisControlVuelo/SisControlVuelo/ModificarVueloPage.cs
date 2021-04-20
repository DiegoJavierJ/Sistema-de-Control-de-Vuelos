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
            cmd.Parameters.AddWithValue("@varCodigo", Tbx_CodigoVuelo.Text);
            cmd.Parameters.AddWithValue("@varIDAvionNuevo", int.Parse(Tbx_Avion.Text));
            cmd.Parameters.AddWithValue("@varIDAerolineaNueva", int.Parse(Tbx_Aerolinea.Text));
            cmd.Parameters.AddWithValue("@varIDAeropuertoSalidaNuevo", int.Parse(Tbx_AeropuertoSalida.Text));
            cmd.Parameters.AddWithValue("@varIDAeropuertoLlegadaNuevo", int.Parse(Tbx_AeropuertoLlegada.Text));
            cmd.Parameters.AddWithValue("@varFechaSalidaNueva", Tbx_FechaSalida.Text);
            cmd.Parameters.AddWithValue("@varFechaLlegadaNueva", Tbx_FechaEntrada.Text);
            cmd.Parameters.AddWithValue("@varEstadoNuevo", Tbx_Estado.Text);

            int i = cmd.ExecuteNonQuery();
            sql.Close();

            if (i != 0)
            {
                MessageBox.Show(i + " Data Saved");
            }
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
        }
    }
}
