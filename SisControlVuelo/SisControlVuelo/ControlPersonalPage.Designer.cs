
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
            this.Tbox_Nombre = new System.Windows.Forms.TextBox();
            this.Tbox_Apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_ControlPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView_ControlPersonal
            // 
            this.DGridView_ControlPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_ControlPersonal.Location = new System.Drawing.Point(23, 71);
            this.DGridView_ControlPersonal.Name = "DGridView_ControlPersonal";
            this.DGridView_ControlPersonal.RowHeadersWidth = 51;
            this.DGridView_ControlPersonal.RowTemplate.Height = 25;
            this.DGridView_ControlPersonal.Size = new System.Drawing.Size(563, 260);
            this.DGridView_ControlPersonal.TabIndex = 1;
            this.DGridView_ControlPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_ControlPersonal_CellContentClick);
            // 
            // Tbox_Nombre
            // 
            this.Tbox_Nombre.Location = new System.Drawing.Point(206, 42);
            this.Tbox_Nombre.Name = "Tbox_Nombre";
            this.Tbox_Nombre.Size = new System.Drawing.Size(100, 23);
            this.Tbox_Nombre.TabIndex = 2;
            // 
            // Tbox_Apellido
            // 
            this.Tbox_Apellido.Location = new System.Drawing.Point(407, 42);
            this.Tbox_Apellido.Name = "Tbox_Apellido";
            this.Tbox_Apellido.Size = new System.Drawing.Size(100, 23);
            this.Tbox_Apellido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ControlPersonalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbox_Apellido);
            this.Controls.Add(this.Tbox_Nombre);
            this.Controls.Add(this.DGridView_ControlPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ControlPersonalPage";
            this.Text = "ControlPersonalPage";
            this.Load += new System.EventHandler(this.ControlPersonalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_ControlPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView_ControlPersonal;
        private System.Windows.Forms.TextBox Tbox_Nombre;
        private System.Windows.Forms.TextBox Tbox_Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}