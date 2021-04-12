using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisControlVuelo
{
    public partial class ControlPersonalPage : Form
    {
        public ControlPersonalPage()
        {
            InitializeComponent();
        }

        private void DGridView_ControlPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ControlPersonalPage_Load(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            DGridView_ControlPersonal.DataSource = personal.GetPersonal();
            DGridView_ControlPersonal.DataMember = "Personal";
        }
    }
}
