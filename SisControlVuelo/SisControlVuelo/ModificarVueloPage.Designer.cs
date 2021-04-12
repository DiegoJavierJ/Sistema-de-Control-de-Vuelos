
namespace SisControlVuelo
{
    partial class ModificarVueloPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_CodigoVuelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_Aerolinea = new System.Windows.Forms.TextBox();
            this.Tbx_AeropuertoSalida = new System.Windows.Forms.TextBox();
            this.Tbx_AeropuertoLlegada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGridView_ModificarVuelo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbx_FechaEntrada = new System.Windows.Forms.TextBox();
            this.Tbx_Estado = new System.Windows.Forms.TextBox();
            this.Tbx_FechaSalida = new System.Windows.Forms.TextBox();
            this.Tbx_Avion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_ModificarVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Vuelo";
            // 
            // Tbx_CodigoVuelo
            // 
            this.Tbx_CodigoVuelo.Location = new System.Drawing.Point(170, 59);
            this.Tbx_CodigoVuelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tbx_CodigoVuelo.Name = "Tbx_CodigoVuelo";
            this.Tbx_CodigoVuelo.Size = new System.Drawing.Size(118, 23);
            this.Tbx_CodigoVuelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aerolinea";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(410, 335);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(110, 22);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "AeropuertoSalida";
            // 
            // Tbx_Aerolinea
            // 
            this.Tbx_Aerolinea.Location = new System.Drawing.Point(401, 59);
            this.Tbx_Aerolinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tbx_Aerolinea.Name = "Tbx_Aerolinea";
            this.Tbx_Aerolinea.Size = new System.Drawing.Size(119, 23);
            this.Tbx_Aerolinea.TabIndex = 6;
            // 
            // Tbx_AeropuertoSalida
            // 
            this.Tbx_AeropuertoSalida.Location = new System.Drawing.Point(170, 132);
            this.Tbx_AeropuertoSalida.Name = "Tbx_AeropuertoSalida";
            this.Tbx_AeropuertoSalida.Size = new System.Drawing.Size(117, 23);
            this.Tbx_AeropuertoSalida.TabIndex = 7;
            // 
            // Tbx_AeropuertoLlegada
            // 
            this.Tbx_AeropuertoLlegada.Location = new System.Drawing.Point(401, 132);
            this.Tbx_AeropuertoLlegada.Name = "Tbx_AeropuertoLlegada";
            this.Tbx_AeropuertoLlegada.Size = new System.Drawing.Size(119, 23);
            this.Tbx_AeropuertoLlegada.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(293, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "AeropuertoLlegada";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DGridView_ModificarVuelo
            // 
            this.DGridView_ModificarVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_ModificarVuelo.Location = new System.Drawing.Point(69, 211);
            this.DGridView_ModificarVuelo.Name = "DGridView_ModificarVuelo";
            this.DGridView_ModificarVuelo.RowTemplate.Height = 25;
            this.DGridView_ModificarVuelo.Size = new System.Drawing.Size(451, 119);
            this.DGridView_ModificarVuelo.TabIndex = 11;
            this.DGridView_ModificarVuelo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_ModificarVuelo_CellContentDoubleClick);
            this.DGridView_ModificarVuelo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_ModificarVuelo_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Avion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "FechaLlegada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "FechaSalida";
            // 
            // Tbx_FechaEntrada
            // 
            this.Tbx_FechaEntrada.Location = new System.Drawing.Point(401, 173);
            this.Tbx_FechaEntrada.Name = "Tbx_FechaEntrada";
            this.Tbx_FechaEntrada.Size = new System.Drawing.Size(119, 23);
            this.Tbx_FechaEntrada.TabIndex = 16;
            // 
            // Tbx_Estado
            // 
            this.Tbx_Estado.Location = new System.Drawing.Point(401, 99);
            this.Tbx_Estado.Name = "Tbx_Estado";
            this.Tbx_Estado.Size = new System.Drawing.Size(119, 23);
            this.Tbx_Estado.TabIndex = 17;
            // 
            // Tbx_FechaSalida
            // 
            this.Tbx_FechaSalida.Location = new System.Drawing.Point(170, 172);
            this.Tbx_FechaSalida.Name = "Tbx_FechaSalida";
            this.Tbx_FechaSalida.Size = new System.Drawing.Size(117, 23);
            this.Tbx_FechaSalida.TabIndex = 18;
            // 
            // Tbx_Avion
            // 
            this.Tbx_Avion.Location = new System.Drawing.Point(170, 99);
            this.Tbx_Avion.Name = "Tbx_Avion";
            this.Tbx_Avion.Size = new System.Drawing.Size(117, 23);
            this.Tbx_Avion.TabIndex = 19;
            // 
            // ModificarVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 405);
            this.Controls.Add(this.Tbx_Avion);
            this.Controls.Add(this.Tbx_FechaSalida);
            this.Controls.Add(this.Tbx_Estado);
            this.Controls.Add(this.Tbx_FechaEntrada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGridView_ModificarVuelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbx_AeropuertoLlegada);
            this.Controls.Add(this.Tbx_AeropuertoSalida);
            this.Controls.Add(this.Tbx_Aerolinea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tbx_CodigoVuelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModificarVueloPage";
            this.Text = "ModificarVueloPage";
            this.Load += new System.EventHandler(this.ModificarVueloPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_ModificarVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_CodigoVuelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbx_Aerolinea;
        private System.Windows.Forms.TextBox Tbx_AeropuertoSalida;
        private System.Windows.Forms.TextBox Tbx_AeropuertoLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGridView_ModificarVuelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbx_FechaEntrada;
        private System.Windows.Forms.TextBox Tbx_Estado;
        private System.Windows.Forms.TextBox Tbx_FechaSalida;
        private System.Windows.Forms.TextBox Tbx_Avion;
    }
}