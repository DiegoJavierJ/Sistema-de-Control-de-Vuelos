
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
            this.Label_MostrarPorAeropuerto = new System.Windows.Forms.Label();
            this.Tbox_MostrarPorAerolinea = new System.Windows.Forms.TextBox();
            this.Tbox_MostrarPorAeropuerto = new System.Windows.Forms.TextBox();
            this.Label_MostrarPorAerolinea = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
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
            this.DGridView_HistorialVuelos.Size = new System.Drawing.Size(563, 260);
            this.DGridView_HistorialVuelos.TabIndex = 0;
            this.DGridView_HistorialVuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_HistorialVuelos_CellContentClick);
            // 
            // Label_MostrarPorAeropuerto
            // 
            this.Label_MostrarPorAeropuerto.AutoSize = true;
            this.Label_MostrarPorAeropuerto.Location = new System.Drawing.Point(23, 44);
            this.Label_MostrarPorAeropuerto.Name = "Label_MostrarPorAeropuerto";
            this.Label_MostrarPorAeropuerto.Size = new System.Drawing.Size(132, 15);
            this.Label_MostrarPorAeropuerto.TabIndex = 8;
            this.Label_MostrarPorAeropuerto.Text = "Mostrar por Aeropuerto";
            // 
            // Tbox_MostrarPorAerolinea
            // 
            this.Tbox_MostrarPorAerolinea.Location = new System.Drawing.Point(154, 41);
            this.Tbox_MostrarPorAerolinea.Name = "Tbox_MostrarPorAerolinea";
            this.Tbox_MostrarPorAerolinea.Size = new System.Drawing.Size(149, 23);
            this.Tbox_MostrarPorAerolinea.TabIndex = 11;
            this.Tbox_MostrarPorAerolinea.TextChanged += new System.EventHandler(this.Tbox_MostrarPorAerolinea_TextChanged);
            // 
            // Tbox_MostrarPorAeropuerto
            // 
            this.Tbox_MostrarPorAeropuerto.Location = new System.Drawing.Point(437, 41);
            this.Tbox_MostrarPorAeropuerto.Name = "Tbox_MostrarPorAeropuerto";
            this.Tbox_MostrarPorAeropuerto.Size = new System.Drawing.Size(149, 23);
            this.Tbox_MostrarPorAeropuerto.TabIndex = 10;
            this.Tbox_MostrarPorAeropuerto.TextChanged += new System.EventHandler(this.Tbox_MostrarPorAeropuerto_TextChanged);
            // 
            // Label_MostrarPorAerolinea
            // 
            this.Label_MostrarPorAerolinea.AutoSize = true;
            this.Label_MostrarPorAerolinea.Location = new System.Drawing.Point(309, 44);
            this.Label_MostrarPorAerolinea.Name = "Label_MostrarPorAerolinea";
            this.Label_MostrarPorAerolinea.Size = new System.Drawing.Size(122, 15);
            this.Label_MostrarPorAerolinea.TabIndex = 12;
            this.Label_MostrarPorAerolinea.Text = "Mostrar por Aerolinea";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(511, 337);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 13;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // HistorialVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Label_MostrarPorAerolinea);
            this.Controls.Add(this.Tbox_MostrarPorAerolinea);
            this.Controls.Add(this.Tbox_MostrarPorAeropuerto);
            this.Controls.Add(this.Label_MostrarPorAeropuerto);
            this.Controls.Add(this.DGridView_HistorialVuelos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistorialVueloPage";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HistorialVueloPage";
            this.Load += new System.EventHandler(this.HistorialVueloPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_HistorialVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView_HistorialVuelos;
        private System.Windows.Forms.Label Label_MostrarPorAeropuerto;
        private System.Windows.Forms.TextBox Tbox_MostrarPorAerolinea;
        private System.Windows.Forms.TextBox Tbox_MostrarPorAeropuerto;
        private System.Windows.Forms.Label Label_MostrarPorAerolinea;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}