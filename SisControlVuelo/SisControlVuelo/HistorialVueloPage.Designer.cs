
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
            this.DGridView_HistorialVuelos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbox_MostrarPorAeropuerto = new System.Windows.Forms.TextBox();
            this.Tbox_MostrarPorAerolinea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_HistorialVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView_HistorialVuelos
            // 
            this.DGridView_HistorialVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_HistorialVuelos.Location = new System.Drawing.Point(23, 71);
            this.DGridView_HistorialVuelos.Name = "DGridView_HistorialVuelos";
            this.DGridView_HistorialVuelos.RowHeadersWidth = 51;
            this.DGridView_HistorialVuelos.RowTemplate.Height = 25;
            this.DGridView_HistorialVuelos.Size = new System.Drawing.Size(552, 260);
            this.DGridView_HistorialVuelos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mostrar por Aeropuerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mostrar por Aerolinea";
            // 
            // Tbox_MostrarPorAeropuerto
            // 
            this.Tbox_MostrarPorAeropuerto.Location = new System.Drawing.Point(161, 41);
            this.Tbox_MostrarPorAeropuerto.Name = "Tbox_MostrarPorAeropuerto";
            this.Tbox_MostrarPorAeropuerto.Size = new System.Drawing.Size(131, 23);
            this.Tbox_MostrarPorAeropuerto.TabIndex = 10;
            // 
            // Tbox_MostrarPorAerolinea
            // 
            this.Tbox_MostrarPorAerolinea.Location = new System.Drawing.Point(426, 42);
            this.Tbox_MostrarPorAerolinea.Name = "Tbox_MostrarPorAerolinea";
            this.Tbox_MostrarPorAerolinea.Size = new System.Drawing.Size(149, 23);
            this.Tbox_MostrarPorAerolinea.TabIndex = 11;
            // 
            // HistorialVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Tbox_MostrarPorAerolinea);
            this.Controls.Add(this.Tbox_MostrarPorAeropuerto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGridView_HistorialVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistorialVueloPage";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HistorialVueloPage";
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_HistorialVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView_HistorialVuelos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbox_MostrarPorAeropuerto;
        private System.Windows.Forms.TextBox Tbox_MostrarPorAerolinea;
    }
}