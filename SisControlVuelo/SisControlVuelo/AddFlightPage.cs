using System;
using System.Windows.Forms;

namespace SisControlVuelo
{
    public partial class AddFlightPage : Form
    {
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Tbox_Avion;
        private TextBox Tbox_HoraSalida;
        private TextBox Tbox_HoraLlegada;
        private Button Btn_Agregar;
        private Label label6;
        private ComboBox Cbox_Aerolinea;
        private ComboBox Cbox_AeropuertoS;
        private ComboBox Cbox_AeropuertoE;
        private Label label_Avion;

        public AddFlightPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label_Avion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbox_Avion = new System.Windows.Forms.TextBox();
            this.Tbox_HoraSalida = new System.Windows.Forms.TextBox();
            this.Tbox_HoraLlegada = new System.Windows.Forms.TextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbox_Aerolinea = new System.Windows.Forms.ComboBox();
            this.Cbox_AeropuertoS = new System.Windows.Forms.ComboBox();
            this.Cbox_AeropuertoE = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Avion
            // 
            this.label_Avion.AutoSize = true;
            this.label_Avion.Location = new System.Drawing.Point(105, 45);
            this.label_Avion.Name = "label_Avion";
            this.label_Avion.Size = new System.Drawing.Size(38, 15);
            this.label_Avion.TabIndex = 0;
            this.label_Avion.Text = "Avion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aeropuerto de Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aeropuerto de Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hora de Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hora de Llegada";
            // 
            // Tbox_Avion
            // 
            this.Tbox_Avion.Location = new System.Drawing.Point(300, 134);
            this.Tbox_Avion.Name = "Tbox_Avion";
            this.Tbox_Avion.Size = new System.Drawing.Size(156, 23);
            this.Tbox_Avion.TabIndex = 1;
            // 
            // Tbox_HoraSalida
            // 
            this.Tbox_HoraSalida.Location = new System.Drawing.Point(105, 134);
            this.Tbox_HoraSalida.Name = "Tbox_HoraSalida";
            this.Tbox_HoraSalida.Size = new System.Drawing.Size(156, 23);
            this.Tbox_HoraSalida.TabIndex = 1;
            // 
            // Tbox_HoraLlegada
            // 
            this.Tbox_HoraLlegada.Location = new System.Drawing.Point(105, 72);
            this.Tbox_HoraLlegada.Name = "Tbox_HoraLlegada";
            this.Tbox_HoraLlegada.Size = new System.Drawing.Size(156, 23);
            this.Tbox_HoraLlegada.TabIndex = 1;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(225, 258);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(126, 30);
            this.Btn_Agregar.TabIndex = 2;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Aerolinea";
            // 
            // Cbox_Aerolinea
            // 
            this.Cbox_Aerolinea.FormattingEnabled = true;
            this.Cbox_Aerolinea.Location = new System.Drawing.Point(300, 72);
            this.Cbox_Aerolinea.Name = "Cbox_Aerolinea";
            this.Cbox_Aerolinea.Size = new System.Drawing.Size(156, 23);
            this.Cbox_Aerolinea.TabIndex = 4;
            // 
            // Cbox_AeropuertoS
            // 
            this.Cbox_AeropuertoS.FormattingEnabled = true;
            this.Cbox_AeropuertoS.Location = new System.Drawing.Point(105, 203);
            this.Cbox_AeropuertoS.Name = "Cbox_AeropuertoS";
            this.Cbox_AeropuertoS.Size = new System.Drawing.Size(156, 23);
            this.Cbox_AeropuertoS.TabIndex = 5;
            // 
            // Cbox_AeropuertoE
            // 
            this.Cbox_AeropuertoE.FormattingEnabled = true;
            this.Cbox_AeropuertoE.Location = new System.Drawing.Point(300, 203);
            this.Cbox_AeropuertoE.Name = "Cbox_AeropuertoE";
            this.Cbox_AeropuertoE.Size = new System.Drawing.Size(156, 23);
            this.Cbox_AeropuertoE.TabIndex = 6;
            // 
            // AddFlightPage
            // 
            this.ClientSize = new System.Drawing.Size(591, 490);
            this.Controls.Add(this.Cbox_AeropuertoE);
            this.Controls.Add(this.Cbox_AeropuertoS);
            this.Controls.Add(this.Cbox_Aerolinea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Tbox_HoraLlegada);
            this.Controls.Add(this.Tbox_HoraSalida);
            this.Controls.Add(this.Tbox_Avion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Avion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFlightPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}