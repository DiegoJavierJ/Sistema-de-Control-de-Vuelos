
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
            this.tbx_IdVuelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Campos = new System.Windows.Forms.ComboBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_CambioCampo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Vuelo";
            // 
            // tbx_IdVuelo
            // 
            this.tbx_IdVuelo.Location = new System.Drawing.Point(148, 89);
            this.tbx_IdVuelo.Name = "tbx_IdVuelo";
            this.tbx_IdVuelo.Size = new System.Drawing.Size(280, 27);
            this.tbx_IdVuelo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Campo a Modificar";
            // 
            // cbx_Campos
            // 
            this.cbx_Campos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Campos.FormattingEnabled = true;
            this.cbx_Campos.Items.AddRange(new object[] {
            "Aeropuerto Salida",
            "Aeropuerto Llegada",
            "Hora Salida",
            "Hora Entrada",
            "Aerolinea"});
            this.cbx_Campos.Location = new System.Drawing.Point(148, 183);
            this.cbx_Campos.Name = "cbx_Campos";
            this.cbx_Campos.Size = new System.Drawing.Size(280, 28);
            this.cbx_Campos.TabIndex = 3;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(211, 350);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(126, 30);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cambio a Realizar";
            // 
            // tbx_CambioCampo
            // 
            this.tbx_CambioCampo.Location = new System.Drawing.Point(148, 277);
            this.tbx_CambioCampo.Name = "tbx_CambioCampo";
            this.tbx_CambioCampo.Size = new System.Drawing.Size(280, 27);
            this.tbx_CambioCampo.TabIndex = 6;
            // 
            // ModificarVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 490);
            this.Controls.Add(this.tbx_CambioCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.cbx_Campos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_IdVuelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarVueloPage";
            this.Text = "ModificarVueloPage";
            this.Load += new System.EventHandler(this.ModificarVueloPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_IdVuelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Campos;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_CambioCampo;
    }
}