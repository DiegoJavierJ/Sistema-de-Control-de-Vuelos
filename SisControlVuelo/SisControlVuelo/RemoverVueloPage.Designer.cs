
namespace SisControlVuelo
{
    partial class RemoverVueloPage
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
            this.tbx_NumVuelo = new System.Windows.Forms.TextBox();
            this.btn_RemoverVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Vuelo";
            // 
            // tbx_NumVuelo
            // 
            this.tbx_NumVuelo.Location = new System.Drawing.Point(157, 177);
            this.tbx_NumVuelo.Name = "tbx_NumVuelo";
            this.tbx_NumVuelo.Size = new System.Drawing.Size(280, 27);
            this.tbx_NumVuelo.TabIndex = 1;
            // 
            // btn_RemoverVuelo
            // 
            this.btn_RemoverVuelo.Location = new System.Drawing.Point(228, 230);
            this.btn_RemoverVuelo.Name = "btn_RemoverVuelo";
            this.btn_RemoverVuelo.Size = new System.Drawing.Size(126, 30);
            this.btn_RemoverVuelo.TabIndex = 2;
            this.btn_RemoverVuelo.Text = "Remover";
            this.btn_RemoverVuelo.UseVisualStyleBackColor = true;
            // 
            // RemoverVueloPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 490);
            this.Controls.Add(this.btn_RemoverVuelo);
            this.Controls.Add(this.tbx_NumVuelo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoverVueloPage";
            this.Text = "RemoverVueloPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_NumVuelo;
        private System.Windows.Forms.Button btn_RemoverVuelo;
    }
}