namespace SisControlVuelo
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tbx_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(348, 108);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(75, 20);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbx_Username
            // 
            this.tbx_Username.Location = new System.Drawing.Point(243, 146);
            this.tbx_Username.Name = "tbx_Username";
            this.tbx_Username.Size = new System.Drawing.Size(301, 27);
            this.tbx_Username.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(353, 213);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(70, 20);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(243, 253);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(301, 27);
            this.tbx_Password.TabIndex = 3;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(320, 322);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(136, 47);
            this.btn_LogIn.TabIndex = 4;
            this.btn_LogIn.Text = "LogIn";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.AutoSize = true;
            this.lbl_Logo.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Logo.Location = new System.Drawing.Point(308, 9);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(157, 89);
            this.lbl_Logo.TabIndex = 5;
            this.lbl_Logo.Text = "SCV";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Logo);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tbx_Username);
            this.Controls.Add(this.lbl_Username);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tbx_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_Logo;
    }
}

