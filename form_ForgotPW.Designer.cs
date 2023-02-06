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
            this.pnl_codeValidator = new System.Windows.Forms.Panel();
            this.lbl_codeError = new System.Windows.Forms.Label();
            this.btn_codeSubmit = new System.Windows.Forms.Button();
            this.btn_codeBack = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.pnl_resetPassword = new System.Windows.Forms.Panel();
            this.lbl_newPasswordError = new System.Windows.Forms.Label();
            this.btn_newPasswordSubmit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_enterPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txt_enterPassword = new System.Windows.Forms.TextBox();
            this.lbl_enterPasswordConfirm = new System.Windows.Forms.Label();
            this.lbl_enterPassword = new System.Windows.Forms.Label();
            this.pnl_codeValidator.SuspendLayout();
            this.pnl_resetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(205, 125);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(111, 24);
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
            this.btn_forgotPW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_forgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgotPW.Location = new System.Drawing.Point(249, 197);
            this.btn_forgotPW.Name = "btn_forgotPW";
            this.btn_forgotPW.Size = new System.Drawing.Size(117, 59);
            this.btn_forgotPW.TabIndex = 2;
            this.btn_forgotPW.Text = "Submit";
            this.btn_forgotPW.UseVisualStyleBackColor = false;
            this.btn_forgotPW.Click += new System.EventHandler(this.btn_forgotPW_Click);
            // 
            // lbl_forgotPW
            // 
            this.lbl_forgotPW.AutoSize = true;
            this.lbl_forgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgotPW.Location = new System.Drawing.Point(145, 48);
            this.lbl_forgotPW.Name = "lbl_forgotPW";
            this.lbl_forgotPW.Size = new System.Drawing.Size(542, 24);
            this.lbl_forgotPW.TabIndex = 3;
            this.lbl_forgotPW.Text = "Enter your username to receive your password reset link:";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Tomato;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(455, 197);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(117, 59);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
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
            // pnl_codeValidator
            // 
            this.pnl_codeValidator.Controls.Add(this.lbl_codeError);
            this.pnl_codeValidator.Controls.Add(this.btn_codeSubmit);
            this.pnl_codeValidator.Controls.Add(this.btn_codeBack);
            this.pnl_codeValidator.Controls.Add(this.txt_code);
            this.pnl_codeValidator.Controls.Add(this.lbl_code);
            this.pnl_codeValidator.Location = new System.Drawing.Point(85, 346);
            this.pnl_codeValidator.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_codeValidator.Name = "pnl_codeValidator";
            this.pnl_codeValidator.Size = new System.Drawing.Size(60, 54);
            this.pnl_codeValidator.TabIndex = 6;
            this.pnl_codeValidator.Visible = false;
            // 
            // lbl_codeError
            // 
            this.lbl_codeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_codeError.Location = new System.Drawing.Point(229, 153);
            this.lbl_codeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codeError.Name = "lbl_codeError";
            this.lbl_codeError.Size = new System.Drawing.Size(275, 33);
            this.lbl_codeError.TabIndex = 3;
            // 
            // btn_codeSubmit
            // 
            this.btn_codeSubmit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_codeSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_codeSubmit.Location = new System.Drawing.Point(141, 218);
            this.btn_codeSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_codeSubmit.Name = "btn_codeSubmit";
            this.btn_codeSubmit.Size = new System.Drawing.Size(137, 56);
            this.btn_codeSubmit.TabIndex = 2;
            this.btn_codeSubmit.Text = "Submit";
            this.btn_codeSubmit.UseVisualStyleBackColor = false;
            this.btn_codeSubmit.Click += new System.EventHandler(this.btn_codeSubmit_Click);
            // 
            // btn_codeBack
            // 
            this.btn_codeBack.BackColor = System.Drawing.Color.Tomato;
            this.btn_codeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_codeBack.Location = new System.Drawing.Point(405, 218);
            this.btn_codeBack.Margin = new System.Windows.Forms.Padding(2);
            this.btn_codeBack.Name = "btn_codeBack";
            this.btn_codeBack.Size = new System.Drawing.Size(137, 56);
            this.btn_codeBack.TabIndex = 3;
            this.btn_codeBack.Text = "Back";
            this.btn_codeBack.UseVisualStyleBackColor = false;
            this.btn_codeBack.Click += new System.EventHandler(this.btn_codeBack_Click);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(212, 118);
            this.txt_code.Margin = new System.Windows.Forms.Padding(2);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(276, 26);
            this.txt_code.TabIndex = 1;
            // 
            // lbl_code
            // 
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.Location = new System.Drawing.Point(229, 44);
            this.lbl_code.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(240, 24);
            this.lbl_code.TabIndex = 0;
            this.lbl_code.Text = "Please enter reset code";
            // 
            // pnl_resetPassword
            // 
            this.pnl_resetPassword.Controls.Add(this.lbl_newPasswordError);
            this.pnl_resetPassword.Controls.Add(this.btn_newPasswordSubmit);
            this.pnl_resetPassword.Controls.Add(this.btn_Cancel);
            this.pnl_resetPassword.Controls.Add(this.txt_enterPasswordConfirm);
            this.pnl_resetPassword.Controls.Add(this.txt_enterPassword);
            this.pnl_resetPassword.Controls.Add(this.lbl_enterPasswordConfirm);
            this.pnl_resetPassword.Controls.Add(this.lbl_enterPassword);
            this.pnl_resetPassword.Location = new System.Drawing.Point(580, 346);
            this.pnl_resetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_resetPassword.Name = "pnl_resetPassword";
            this.pnl_resetPassword.Size = new System.Drawing.Size(73, 54);
            this.pnl_resetPassword.TabIndex = 7;
            this.pnl_resetPassword.Visible = false;
            // 
            // lbl_newPasswordError
            // 
            this.lbl_newPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_newPasswordError.Location = new System.Drawing.Point(86, 131);
            this.lbl_newPasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_newPasswordError.Name = "lbl_newPasswordError";
            this.lbl_newPasswordError.Size = new System.Drawing.Size(433, 23);
            this.lbl_newPasswordError.TabIndex = 3;
            // 
            // btn_newPasswordSubmit
            // 
            this.btn_newPasswordSubmit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_newPasswordSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newPasswordSubmit.Location = new System.Drawing.Point(85, 173);
            this.btn_newPasswordSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newPasswordSubmit.Name = "btn_newPasswordSubmit";
            this.btn_newPasswordSubmit.Size = new System.Drawing.Size(171, 61);
            this.btn_newPasswordSubmit.TabIndex = 3;
            this.btn_newPasswordSubmit.Text = "Submit";
            this.btn_newPasswordSubmit.UseVisualStyleBackColor = false;
            this.btn_newPasswordSubmit.Click += new System.EventHandler(this.btn_newPasswordSubmit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Tomato;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(347, 173);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(171, 61);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_enterPasswordConfirm
            // 
            this.txt_enterPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enterPasswordConfirm.Location = new System.Drawing.Point(347, 88);
            this.txt_enterPasswordConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txt_enterPasswordConfirm.Name = "txt_enterPasswordConfirm";
            this.txt_enterPasswordConfirm.PasswordChar = '*';
            this.txt_enterPasswordConfirm.Size = new System.Drawing.Size(241, 26);
            this.txt_enterPasswordConfirm.TabIndex = 2;
            // 
            // txt_enterPassword
            // 
            this.txt_enterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enterPassword.Location = new System.Drawing.Point(347, 35);
            this.txt_enterPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_enterPassword.Name = "txt_enterPassword";
            this.txt_enterPassword.PasswordChar = '*';
            this.txt_enterPassword.Size = new System.Drawing.Size(241, 26);
            this.txt_enterPassword.TabIndex = 1;
            // 
            // lbl_enterPasswordConfirm
            // 
            this.lbl_enterPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterPasswordConfirm.Location = new System.Drawing.Point(86, 91);
            this.lbl_enterPasswordConfirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_enterPasswordConfirm.Name = "lbl_enterPasswordConfirm";
            this.lbl_enterPasswordConfirm.Size = new System.Drawing.Size(243, 34);
            this.lbl_enterPasswordConfirm.TabIndex = 0;
            this.lbl_enterPasswordConfirm.Text = "Confirm new password";
            // 
            // lbl_enterPassword
            // 
            this.lbl_enterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterPassword.Location = new System.Drawing.Point(86, 35);
            this.lbl_enterPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_enterPassword.Name = "lbl_enterPassword";
            this.lbl_enterPassword.Size = new System.Drawing.Size(243, 34);
            this.lbl_enterPassword.TabIndex = 0;
            this.lbl_enterPassword.Text = "Enter new password";
            // 
            // form_ForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_resetPassword);
            this.Controls.Add(this.pnl_codeValidator);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_forgotPW);
            this.Controls.Add(this.btn_forgotPW);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Name = "form_ForgotPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ForgotPW";
            this.Load += new System.EventHandler(this.form_ForgotPW_Load);
            this.pnl_codeValidator.ResumeLayout(false);
            this.pnl_codeValidator.PerformLayout();
            this.pnl_resetPassword.ResumeLayout(false);
            this.pnl_resetPassword.PerformLayout();
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
        private System.Windows.Forms.Panel pnl_codeValidator;
        private System.Windows.Forms.Button btn_codeSubmit;
        private System.Windows.Forms.Button btn_codeBack;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_codeError;
        private System.Windows.Forms.Panel pnl_resetPassword;
        private System.Windows.Forms.Button btn_newPasswordSubmit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_enterPasswordConfirm;
        private System.Windows.Forms.TextBox txt_enterPassword;
        private System.Windows.Forms.Label lbl_enterPasswordConfirm;
        private System.Windows.Forms.Label lbl_enterPassword;
        private System.Windows.Forms.Label lbl_newPasswordError;
    }
}