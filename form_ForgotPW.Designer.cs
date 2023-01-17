namespace Astect
{
    partial class form_ForgotPW
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_forgotPW = new System.Windows.Forms.Button();
            this.lbl_forgotPW = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Username.Location = new System.Drawing.Point(205, 125);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(87, 20);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Username.Location = new System.Drawing.Point(347, 122);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(254, 26);
            this.txt_Username.TabIndex = 1;
            // 
            // btn_forgotPW
            // 
            this.btn_forgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_forgotPW.Location = new System.Drawing.Point(249, 197);
            this.btn_forgotPW.Name = "btn_forgotPW";
            this.btn_forgotPW.Size = new System.Drawing.Size(117, 59);
            this.btn_forgotPW.TabIndex = 2;
            this.btn_forgotPW.Text = "Submit";
            this.btn_forgotPW.UseVisualStyleBackColor = true;
            this.btn_forgotPW.Click += new System.EventHandler(this.btn_forgotPW_Click);
            // 
            // lbl_forgotPW
            // 
            this.lbl_forgotPW.AutoSize = true;
            this.lbl_forgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forgotPW.Location = new System.Drawing.Point(205, 50);
            this.lbl_forgotPW.Name = "lbl_forgotPW";
            this.lbl_forgotPW.Size = new System.Drawing.Size(406, 20);
            this.lbl_forgotPW.TabIndex = 3;
            this.lbl_forgotPW.Text = "Enter your username to receive your password reset link.";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Back.Location = new System.Drawing.Point(455, 197);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(117, 59);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(344, 155);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 17);
            this.lbl_Error.TabIndex = 5;
            // 
            // form_ForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_forgotPW);
            this.Controls.Add(this.btn_forgotPW);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Name = "form_ForgotPW";
            this.Text = "form_ForgotPW";
            this.Load += new System.EventHandler(this.form_ForgotPW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_forgotPW;
        private System.Windows.Forms.Label lbl_forgotPW;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Error;
    }
}