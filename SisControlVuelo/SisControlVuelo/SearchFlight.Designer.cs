
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGridView_BuscarVuelo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_BuscarVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el codigo del vuelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 23);
            this.textBox1.TabIndex = 1;
            // 
            // DGridView_BuscarVuelo
            // 
            this.DGridView_BuscarVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_BuscarVuelo.Location = new System.Drawing.Point(134, 122);
            this.DGridView_BuscarVuelo.Name = "DGridView_BuscarVuelo";
            this.DGridView_BuscarVuelo.RowTemplate.Height = 25;
            this.DGridView_BuscarVuelo.Size = new System.Drawing.Size(363, 150);
            this.DGridView_BuscarVuelo.TabIndex = 2;
            // 
            // SearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGridView_BuscarVuelo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchFlight";
            this.Text = "SearchFlight";
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_BuscarVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGridView_BuscarVuelo;
    }
}