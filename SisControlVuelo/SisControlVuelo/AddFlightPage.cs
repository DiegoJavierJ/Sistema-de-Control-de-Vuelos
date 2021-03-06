using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

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
        private Label Estado;
        private TextBox tbx_Estado;
        private Label label1;
        private TextBox tbx_Codigo;
        private TextBox Tbox_Aerolinea;
        private TextBox Tbox_AeropuertoS;
        private TextBox Tbox_AeropuertoE;
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
            this.Estado = new System.Windows.Forms.Label();
            this.tbx_Estado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Codigo = new System.Windows.Forms.TextBox();
            this.Tbox_Aerolinea = new System.Windows.Forms.TextBox();
            this.Tbox_AeropuertoS = new System.Windows.Forms.TextBox();
            this.Tbox_AeropuertoE = new System.Windows.Forms.TextBox();
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
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de Llegada";
            // 
            // Tbox_Avion
            // 
            this.Tbox_Avion.Location = new System.Drawing.Point(105, 72);
            this.Tbox_Avion.Name = "Tbox_Avion";
            this.Tbox_Avion.Size = new System.Drawing.Size(156, 23);
            this.Tbox_Avion.TabIndex = 1;
            this.Tbox_Avion.TextChanged += new System.EventHandler(this.Tbox_Avion_TextChanged);
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
            this.Tbox_HoraLlegada.Location = new System.Drawing.Point(300, 130);
            this.Tbox_HoraLlegada.Name = "Tbox_HoraLlegada";
            this.Tbox_HoraLlegada.Size = new System.Drawing.Size(156, 23);
            this.Tbox_HoraLlegada.TabIndex = 1;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(217, 336);
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
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(105, 247);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(42, 15);
            this.Estado.TabIndex = 7;
            this.Estado.Text = "Estado";
            // 
            // tbx_Estado
            // 
            this.tbx_Estado.Location = new System.Drawing.Point(105, 270);
            this.tbx_Estado.Name = "tbx_Estado";
            this.tbx_Estado.Size = new System.Drawing.Size(156, 23);
            this.tbx_Estado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo";
            // 
            // tbx_Codigo
            // 
            this.tbx_Codigo.Location = new System.Drawing.Point(300, 270);
            this.tbx_Codigo.Name = "tbx_Codigo";
            this.tbx_Codigo.Size = new System.Drawing.Size(156, 23);
            this.tbx_Codigo.TabIndex = 10;
            // 
            // Tbox_Aerolinea
            // 
            this.Tbox_Aerolinea.Location = new System.Drawing.Point(300, 72);
            this.Tbox_Aerolinea.Name = "Tbox_Aerolinea";
            this.Tbox_Aerolinea.Size = new System.Drawing.Size(156, 23);
            this.Tbox_Aerolinea.TabIndex = 11;
            // 
            // Tbox_AeropuertoS
            // 
            this.Tbox_AeropuertoS.Location = new System.Drawing.Point(105, 203);
            this.Tbox_AeropuertoS.Name = "Tbox_AeropuertoS";
            this.Tbox_AeropuertoS.Size = new System.Drawing.Size(156, 23);
            this.Tbox_AeropuertoS.TabIndex = 12;
            // 
            // Tbox_AeropuertoE
            // 
            this.Tbox_AeropuertoE.Location = new System.Drawing.Point(300, 203);
            this.Tbox_AeropuertoE.Name = "Tbox_AeropuertoE";
            this.Tbox_AeropuertoE.Size = new System.Drawing.Size(156, 23);
            this.Tbox_AeropuertoE.TabIndex = 13;
            // 
            // AddFlightPage
            // 
            this.ClientSize = new System.Drawing.Size(591, 490);
            this.Controls.Add(this.Tbox_AeropuertoE);
            this.Controls.Add(this.Tbox_AeropuertoS);
            this.Controls.Add(this.Tbox_Aerolinea);
            this.Controls.Add(this.tbx_Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Estado);
            this.Controls.Add(this.Estado);
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
            this.Load += new System.EventHandler(this.AddFlightPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = ConnectionClass.Connect();
            SqlCommand cmd = new SqlCommand("dbo.STP_Vuelo_INS",sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@varCodigo", tbx_Codigo.Text);
            cmd.Parameters.AddWithValue("@varID_Avion", int.Parse(Tbox_Avion.Text));
            cmd.Parameters.AddWithValue("@varID_Aerolinea", int.Parse(Tbox_Aerolinea.Text));
            cmd.Parameters.AddWithValue("@varIDAeropuertoSalida", int.Parse(Tbox_AeropuertoS.Text));
            cmd.Parameters.AddWithValue("@varIDAeropuertoLlegada", int.Parse(Tbox_AeropuertoE.Text));
            cmd.Parameters.AddWithValue("@FechaSalida", Tbox_HoraSalida.Text);
            cmd.Parameters.AddWithValue("@FechaLlegada", Tbox_HoraLlegada.Text);
            cmd.Parameters.AddWithValue("@Estado", tbx_Estado.Text);

            int i = cmd.ExecuteNonQuery();
            sql.Close();

            if(i != 0)
            {
                MessageBox.Show(i + " Data Saved");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbox_Avion_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddFlightPage_Load(object sender, EventArgs e)
        {

        }

        private void Cbox_Aerolinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}