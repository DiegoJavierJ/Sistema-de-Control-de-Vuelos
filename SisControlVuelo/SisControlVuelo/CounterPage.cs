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
    public partial class CounterPage : Form
    {
        public CounterPage()
        {
            InitializeComponent();
        }

        private void CounterPage_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_HistorialVuelo_Click(object sender, EventArgs e)
        {
            this.Panel_InfoSCV.Controls.Clear();
            HistorialVueloPage historialVueloPage = new HistorialVueloPage() {TopLevel = false };
            this.Panel_InfoSCV.Controls.Add(historialVueloPage);
            historialVueloPage.Show();
        }

        private void btn_RemoverVuelo_Click(object sender, EventArgs e)
        {
            this.Panel_InfoSCV.Controls.Clear();
            RemoverVueloPage removerVueloPage = new RemoverVueloPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_InfoSCV.Controls.Add(removerVueloPage);
            removerVueloPage.Show();
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            this.Panel_InfoSCV.Controls.Clear();
            AddFlightPage frm = new AddFlightPage { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_InfoSCV.Controls.Add(frm);
            frm.Show();
        }

        private void btn_ModificarVuelo_Click(object sender, EventArgs e)
        {
            this.Panel_InfoSCV.Controls.Clear();
            ModificarVueloPage modificarVueloPage = new ModificarVueloPage { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_InfoSCV.Controls.Add(modificarVueloPage);
            modificarVueloPage.Show();
        }

        private void btn_CambiarCuenta_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
            this.Close();
        }

        private void Panel_InfoSCV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_AgregarAerolinea_Click(object sender, EventArgs e)
        {
            this.Panel_InfoSCV.Controls.Clear();
            AddAirlinePage addAirlinePage = new AddAirlinePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_InfoSCV.Controls.Add(addAirlinePage);
            addAirlinePage.Show();
        }

        private void Btn_BuscarVuelo_Click(object sender, EventArgs e)
        {
            this.Panel_InfoSCV.Controls.Clear();
            SearchFlight addAirlinePage = new SearchFlight() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_InfoSCV.Controls.Add(addAirlinePage);
            addAirlinePage.Show();
        }
    }
}
