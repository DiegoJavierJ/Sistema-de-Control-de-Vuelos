
namespace SisControlVuelo
{
    partial class ControlPersonalPage
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
            this.DGridView_ControlPersonal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_ControlPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView_ControlPersonal
            // 
            this.DGridView_ControlPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_ControlPersonal.Location = new System.Drawing.Point(26, 95);
            this.DGridView_ControlPersonal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGridView_ControlPersonal.Name = "DGridView_ControlPersonal";
            this.DGridView_ControlPersonal.RowHeadersWidth = 51;
            this.DGridView_ControlPersonal.RowTemplate.Height = 25;
            this.DGridView_ControlPersonal.Size = new System.Drawing.Size(643, 347);
            this.DGridView_ControlPersonal.TabIndex = 1;
            this.DGridView_ControlPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_ControlPersonal_CellContentClick);
            // 
            // ControlPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.DGridView_ControlPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPersonalPage";
            this.Text = "ControlPersonalPage";
            this.Load += new System.EventHandler(this.ControlPersonalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_ControlPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView_ControlPersonal;
    }
}