using System;
using System.Windows.Forms;

namespace SisControlVuelo
{
    public partial class AddFlightPage : Form
    {
        public AddFlightPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddFlightPage
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AddFlightPage";
            this.Load += new System.EventHandler(this.AddFlightPage_Load);
            this.ResumeLayout(false);

        }

        private void AddFlightPage_Load(object sender, EventArgs e)
        {

        }
    }
}