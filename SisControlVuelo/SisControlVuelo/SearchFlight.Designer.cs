
namespace SisControlVuelo
{
    partial class SearchFlight
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
            this.Tbox_BuscarVuelo = new System.Windows.Forms.TextBox();
            this.DGridView_BuscarVuelo = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_BuscarVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el codigo del vuelo";
            // 
            // Tbox_BuscarVuelo
            // 
            this.Tbox_BuscarVuelo.Location = new System.Drawing.Point(350, 112);
            this.Tbox_BuscarVuelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbox_BuscarVuelo.Name = "Tbox_BuscarVuelo";
            this.Tbox_BuscarVuelo.Size = new System.Drawing.Size(218, 27);
            this.Tbox_BuscarVuelo.TabIndex = 1;
            this.Tbox_BuscarVuelo.TextChanged += new System.EventHandler(this.Tbox_BuscarVuelo_TextChanged);
            // 
            // DGridView_BuscarVuelo
            // 
            this.DGridView_BuscarVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_BuscarVuelo.Location = new System.Drawing.Point(153, 163);
            this.DGridView_BuscarVuelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGridView_BuscarVuelo.Name = "DGridView_BuscarVuelo";
            this.DGridView_BuscarVuelo.RowHeadersWidth = 51;
            this.DGridView_BuscarVuelo.RowTemplate.Height = 25;
            this.DGridView_BuscarVuelo.Size = new System.Drawing.Size(415, 200);
            this.DGridView_BuscarVuelo.TabIndex = 2;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(482, 371);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(86, 31);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // SearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.DGridView_BuscarVuelo);
            this.Controls.Add(this.Tbox_BuscarVuelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchFlight";
            this.Text = "SearchFlight";
            this.Load += new System.EventHandler(this.SearchFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_BuscarVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_BuscarVuelo;
        private System.Windows.Forms.DataGridView DGridView_BuscarVuelo;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}