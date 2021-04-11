
namespace SisControlVuelo
{
    partial class AddAirlinePage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Aerolinea = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Pais = new System.Windows.Forms.Label();
            this.btn_AgregarAerolinea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label_Aerolinea
            // 
            this.label_Aerolinea.AutoSize = true;
            this.label_Aerolinea.Location = new System.Drawing.Point(216, 113);
            this.label_Aerolinea.Name = "label_Aerolinea";
            this.label_Aerolinea.Size = new System.Drawing.Size(57, 15);
            this.label_Aerolinea.TabIndex = 1;
            this.label_Aerolinea.Text = "Aerolinea";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label_Pais
            // 
            this.label_Pais.AutoSize = true;
            this.label_Pais.Location = new System.Drawing.Point(209, 154);
            this.label_Pais.Name = "label_Pais";
            this.label_Pais.Size = new System.Drawing.Size(64, 15);
            this.label_Pais.TabIndex = 3;
            this.label_Pais.Text = "PaisOrigen";
            // 
            // btn_AgregarAerolinea
            // 
            this.btn_AgregarAerolinea.Location = new System.Drawing.Point(312, 200);
            this.btn_AgregarAerolinea.Name = "btn_AgregarAerolinea";
            this.btn_AgregarAerolinea.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarAerolinea.TabIndex = 4;
            this.btn_AgregarAerolinea.Text = "Agregar";
            this.btn_AgregarAerolinea.UseVisualStyleBackColor = true;
            this.btn_AgregarAerolinea.Click += new System.EventHandler(this.btn_AgregarAerolinea_Click);
            // 
            // AddAirlinePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AgregarAerolinea);
            this.Controls.Add(this.label_Pais);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Aerolinea);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAirlinePage";
            this.Text = "AddAirlinePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Aerolinea;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Pais;
        private System.Windows.Forms.Button btn_AgregarAerolinea;
    }
}