﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        }

        private void btn_RemoverVuelo_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModificarVuelo_Click(object sender, EventArgs e)
        {

        }

        private void btn_CambiarCuenta_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
            this.Close();
        }
    }
}
