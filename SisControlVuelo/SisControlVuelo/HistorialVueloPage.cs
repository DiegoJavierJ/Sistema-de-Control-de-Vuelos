using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace SisControlVuelo
{
    public partial class HistorialVueloPage : Form
    {
        public HistorialVueloPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tbox_MostrarPorAeropuerto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbox_MostrarPorAerolinea_TextChanged(object sender, EventArgs e)
        {
            String Aeropuerto = Tbox_MostrarPorAeropuerto.Text;
        }

        private void DGridView_HistorialVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HistorialVueloPage_Load(object sender, EventArgs e)
        {
            Flight vuelo = new Flight();
            DGridView_HistorialVuelos.DataSource = vuelo.GetFlight();
            DGridView_HistorialVuelos.DataMember = "Vuelo";
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if(Tbox_MostrarPorAerolinea.Text.Length == 0 && Tbox_MostrarPorAeropuerto.Text.Length != 0)
            {
                Flight vuelo = new Flight();
                DGridView_HistorialVuelos.DataSource = vuelo.GetFlightByAirport(Tbox_MostrarPorAeropuerto.Text);
                DGridView_HistorialVuelos.DataMember = "Vuelo";
            }
            else if(Tbox_MostrarPorAerolinea.Text.Length != 0 && Tbox_MostrarPorAeropuerto.Text.Length == 0)
            {
                Flight vuelo = new Flight();
                DGridView_HistorialVuelos.DataSource = vuelo.GetFlightByAirline(Tbox_MostrarPorAerolinea.Text);
                DGridView_HistorialVuelos.DataMember = "Vuelo";
            }
            else if (Tbox_MostrarPorAerolinea.Text.Length != 0 && Tbox_MostrarPorAeropuerto.Text.Length != 0)
            {
                Flight vuelo = new Flight();
                DGridView_HistorialVuelos.DataSource = vuelo.GetFlightByAirportANDAirline(Tbox_MostrarPorAeropuerto.Text, Tbox_MostrarPorAerolinea.Text);
                DGridView_HistorialVuelos.DataMember = "Vuelo";
            }

        }
    }
}
