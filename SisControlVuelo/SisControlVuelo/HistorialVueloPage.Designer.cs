
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(609, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cbox_MostrarPorFecha
            // 
            this.Cbox_MostrarPorFecha.FormattingEnabled = true;
            this.Cbox_MostrarPorFecha.Location = new System.Drawing.Point(40, 56);
            this.Cbox_MostrarPorFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbox_MostrarPorFecha.Name = "Cbox_MostrarPorFecha";
            this.Cbox_MostrarPorFecha.Size = new System.Drawing.Size(138, 28);
            this.Cbox_MostrarPorFecha.TabIndex = 4;
            // 
            // Cbox_MostrarPorAeropuerto
            // 
            this.Cbox_MostrarPorAeropuerto.FormattingEnabled = true;
            this.Cbox_MostrarPorAeropuerto.Location = new System.Drawing.Point(243, 56);
            this.Cbox_MostrarPorAeropuerto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbox_MostrarPorAeropuerto.Name = "Cbox_MostrarPorAeropuerto";
            this.Cbox_MostrarPorAeropuerto.Size = new System.Drawing.Size(138, 28);
            this.Cbox_MostrarPorAeropuerto.TabIndex = 5;
            // 
            // Cbox_MostrarPorAerolinea
            // 
            this.Cbox_MostrarPorAerolinea.FormattingEnabled = true;
            this.Cbox_MostrarPorAerolinea.Location = new System.Drawing.Point(464, 56);
            this.Cbox_MostrarPorAerolinea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbox_MostrarPorAerolinea.Name = "Cbox_MostrarPorAerolinea";
            this.Cbox_MostrarPorAerolinea.Size = new System.Drawing.Size(138, 28);
            this.Cbox_MostrarPorAerolinea.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mostrar por Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mostrar por Aeropuerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mostrar por Aerolinea";
            // 
            // HistorialVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbox_MostrarPorAerolinea);
            this.Controls.Add(this.Cbox_MostrarPorAeropuerto);
            this.Controls.Add(this.Cbox_MostrarPorFecha);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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