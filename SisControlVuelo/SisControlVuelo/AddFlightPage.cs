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
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(591, 314);
            this.Name = "AddFlightPage";
            this.ResumeLayout(false);

        }
=======
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AddFlightPage";
            this.Load += new System.EventHandler(this.AddFlightPage_Load);
            this.ResumeLayout(false);

        }

        private void AddFlightPage_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 8407a21e802f89070d6868e684e8d1025021d953
    }
}