
namespace SisControlVuelo
{
    partial class HistorialVueloPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cbox_MostrarPorFecha = new System.Windows.Forms.ComboBox();
            this.Cbox_MostrarPorAeropuerto = new System.Windows.Forms.ComboBox();
            this.Cbox_MostrarPorAerolinea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(533, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cbox_MostrarPorFecha
            // 
            this.Cbox_MostrarPorFecha.FormattingEnabled = true;
            this.Cbox_MostrarPorFecha.Location = new System.Drawing.Point(35, 42);
            this.Cbox_MostrarPorFecha.Name = "Cbox_MostrarPorFecha";
            this.Cbox_MostrarPorFecha.Size = new System.Drawing.Size(121, 23);
            this.Cbox_MostrarPorFecha.TabIndex = 4;
            // 
            // Cbox_MostrarPorAeropuerto
            // 
            this.Cbox_MostrarPorAeropuerto.FormattingEnabled = true;
            this.Cbox_MostrarPorAeropuerto.Location = new System.Drawing.Point(213, 42);
            this.Cbox_MostrarPorAeropuerto.Name = "Cbox_MostrarPorAeropuerto";
            this.Cbox_MostrarPorAeropuerto.Size = new System.Drawing.Size(121, 23);
            this.Cbox_MostrarPorAeropuerto.TabIndex = 5;
            // 
            // Cbox_MostrarPorAerolinea
            // 
            this.Cbox_MostrarPorAerolinea.FormattingEnabled = true;
            this.Cbox_MostrarPorAerolinea.Location = new System.Drawing.Point(406, 42);
            this.Cbox_MostrarPorAerolinea.Name = "Cbox_MostrarPorAerolinea";
            this.Cbox_MostrarPorAerolinea.Size = new System.Drawing.Size(121, 23);
            this.Cbox_MostrarPorAerolinea.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mostrar por Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mostrar por Aeropuerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mostrar por Aerolinea";
            // 
            // HistorialVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbox_MostrarPorAerolinea);
            this.Controls.Add(this.Cbox_MostrarPorAeropuerto);
            this.Controls.Add(this.Cbox_MostrarPorFecha);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistorialVueloPage";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HistorialVueloPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Cbox_MostrarPorFecha;
        private System.Windows.Forms.ComboBox Cbox_MostrarPorAeropuerto;
        private System.Windows.Forms.ComboBox Cbox_MostrarPorAerolinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}