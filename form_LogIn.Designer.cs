namespace Astect
{
    partial class form_LogIn
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
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_UserPassword = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_UserPassword = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_UserRegistration = new System.Windows.Forms.Button();
            this.ll_Forgot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(240, 57);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(135, 39);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User Name:";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UserPassword
            // 
            this.lbl_UserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserPassword.Location = new System.Drawing.Point(240, 128);
            this.lbl_UserPassword.Name = "lbl_UserPassword";
            this.lbl_UserPassword.Size = new System.Drawing.Size(131, 39);
            this.lbl_UserPassword.TabIndex = 0;
            this.lbl_UserPassword.Text = "Password:";
            this.lbl_UserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(244, 99);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(291, 26);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_UserPassword
            // 
            this.txt_UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserPassword.Location = new System.Drawing.Point(244, 170);
            this.txt_UserPassword.Name = "txt_UserPassword";
            this.txt_UserPassword.PasswordChar = '*';
            this.txt_UserPassword.Size = new System.Drawing.Size(291, 26);
            this.txt_UserPassword.TabIndex = 2;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.Location = new System.Drawing.Point(273, 236);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(229, 53);
            this.btn_LogIn.TabIndex = 3;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Tomato;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(12, 385);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(176, 53);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_UserRegistration
            // 
            this.btn_UserRegistration.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_UserRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UserRegistration.Location = new System.Drawing.Point(273, 307);
            this.btn_UserRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UserRegistration.Name = "btn_UserRegistration";
            this.btn_UserRegistration.Size = new System.Drawing.Size(229, 42);
            this.btn_UserRegistration.TabIndex = 5;
            this.btn_UserRegistration.Text = "Register";
            this.btn_UserRegistration.UseVisualStyleBackColor = false;
            this.btn_UserRegistration.Click += new System.EventHandler(this.btn_UserRegistration_Click);
            // 
            // ll_Forgot
            // 
            this.ll_Forgot.AutoSize = true;
            this.ll_Forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_Forgot.Location = new System.Drawing.Point(418, 199);
            this.ll_Forgot.Name = "ll_Forgot";
            this.ll_Forgot.Size = new System.Drawing.Size(117, 16);
            this.ll_Forgot.TabIndex = 6;
            this.ll_Forgot.TabStop = true;
            this.ll_Forgot.Text = "Forgot Password?";
            this.ll_Forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Forgot_LinkClicked);
            // 
            // form_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ll_Forgot);
            this.Controls.Add(this.btn_UserRegistration);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.txt_UserPassword);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserPassword);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "form_LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_UserPassword;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_UserPassword;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_UserRegistration;
        private System.Windows.Forms.LinkLabel ll_Forgot;
    }
}

