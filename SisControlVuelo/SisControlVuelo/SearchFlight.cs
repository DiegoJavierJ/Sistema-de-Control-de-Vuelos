using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisControlVuelo
{
    public partial class SearchFlight : Form
    {
        public SearchFlight()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Flight vuelo = new Flight();
            int Parameter = Convert.ToInt32(Tbox_BuscarVuelo.Text);
            DGridView_BuscarVuelo.DataSource = vuelo.GetOneFlight(Parameter);
            DGridView_BuscarVuelo.DataMember = "Vuelo";
        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {

        }

        private void Tbox_BuscarVuelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
