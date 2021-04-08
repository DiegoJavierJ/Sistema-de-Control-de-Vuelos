
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
            this.btn_MostrarFecha = new System.Windows.Forms.Button();
            this.btn_MostrarAerolinea = new System.Windows.Forms.Button();
            this.btn_MostrarAeropuerto = new System.Windows.Forms.Button();
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
            // btn_MostrarFecha
            // 
            this.btn_MostrarFecha.Location = new System.Drawing.Point(41, 42);
            this.btn_MostrarFecha.Name = "btn_MostrarFecha";
            this.btn_MostrarFecha.Size = new System.Drawing.Size(130, 23);
            this.btn_MostrarFecha.TabIndex = 1;
            this.btn_MostrarFecha.Text = "Mostrar por Fecha";
            this.btn_MostrarFecha.UseVisualStyleBackColor = true;
            // 
            // btn_MostrarAerolinea
            // 
            this.btn_MostrarAerolinea.Location = new System.Drawing.Point(210, 42);
            this.btn_MostrarAerolinea.Name = "btn_MostrarAerolinea";
            this.btn_MostrarAerolinea.Size = new System.Drawing.Size(151, 23);
            this.btn_MostrarAerolinea.TabIndex = 2;
            this.btn_MostrarAerolinea.Text = "Mostrar por Aerolinea";
            this.btn_MostrarAerolinea.UseVisualStyleBackColor = true;
            // 
            // btn_MostrarAeropuerto
            // 
            this.btn_MostrarAeropuerto.Location = new System.Drawing.Point(386, 42);
            this.btn_MostrarAeropuerto.Name = "btn_MostrarAeropuerto";
            this.btn_MostrarAeropuerto.Size = new System.Drawing.Size(151, 23);
            this.btn_MostrarAeropuerto.TabIndex = 3;
            this.btn_MostrarAeropuerto.Text = "Mostrar por Aeropuerto";
            this.btn_MostrarAeropuerto.UseVisualStyleBackColor = true;
            // 
            // HistorialVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_MostrarAeropuerto);
            this.Controls.Add(this.btn_MostrarAerolinea);
            this.Controls.Add(this.btn_MostrarFecha);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_MostrarFecha;
        private System.Windows.Forms.Button btn_MostrarAerolinea;
        private System.Windows.Forms.Button btn_MostrarAeropuerto;
    }
}