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
            this.pnl_resetPassword = new System.Windows.Forms.Panel();
            this.btn_newPasswordSubmit = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_enterPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txt_enterPassword = new System.Windows.Forms.TextBox();
            this.lbl_enterPasswordConfirm = new System.Windows.Forms.Label();
            this.lbl_enterPassword = new System.Windows.Forms.Label();
            this.lbl_codeError = new System.Windows.Forms.Label();
            this.btn_codeSubmit = new System.Windows.Forms.Button();
            this.btn_codeBack = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_newPasswordError = new System.Windows.Forms.Label();
            this.pnl_codeValidator.SuspendLayout();
            this.pnl_resetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Username.Location = new System.Drawing.Point(308, 192);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(130, 29);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Username.Location = new System.Drawing.Point(520, 188);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(379, 35);
            this.txt_Username.TabIndex = 1;
            // 
            // btn_forgotPW
            // 
            this.btn_forgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_forgotPW.Location = new System.Drawing.Point(374, 303);
            this.btn_forgotPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_forgotPW.Name = "btn_forgotPW";
            this.btn_forgotPW.Size = new System.Drawing.Size(176, 91);
            this.btn_forgotPW.TabIndex = 2;
            this.btn_forgotPW.Text = "Submit";
            this.btn_forgotPW.UseVisualStyleBackColor = true;
            this.btn_forgotPW.Click += new System.EventHandler(this.btn_forgotPW_Click);
            // 
            // lbl_forgotPW
            // 
            this.lbl_forgotPW.AutoSize = true;
            this.lbl_forgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_forgotPW.Location = new System.Drawing.Point(308, 77);
            this.lbl_forgotPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_forgotPW.Name = "lbl_forgotPW";
            this.lbl_forgotPW.Size = new System.Drawing.Size(618, 29);
            this.lbl_forgotPW.TabIndex = 3;
            this.lbl_forgotPW.Text = "Enter your username to receive your password reset link.";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Back.Location = new System.Drawing.Point(682, 303);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(176, 91);
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
            this.lbl_Error.Location = new System.Drawing.Point(516, 238);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 25);
            this.lbl_Error.TabIndex = 5;
            // 
            // pnl_codeValidator
            // 
            this.pnl_codeValidator.Controls.Add(this.lbl_codeError);
            this.pnl_codeValidator.Controls.Add(this.btn_codeSubmit);
            this.pnl_codeValidator.Controls.Add(this.btn_codeBack);
            this.pnl_codeValidator.Controls.Add(this.txt_code);
            this.pnl_codeValidator.Controls.Add(this.lbl_code);
            this.pnl_codeValidator.Location = new System.Drawing.Point(53, 54);
            this.pnl_codeValidator.Name = "pnl_codeValidator";
            this.pnl_codeValidator.Size = new System.Drawing.Size(140, 82);
            this.pnl_codeValidator.TabIndex = 6;
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
            this.pnl_resetPassword.Location = new System.Drawing.Point(41, 188);
            this.pnl_resetPassword.Name = "pnl_resetPassword";
            this.pnl_resetPassword.Size = new System.Drawing.Size(121, 104);
            this.pnl_resetPassword.TabIndex = 7;
            // 
            // btn_newPasswordSubmit
            // 
            this.btn_newPasswordSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newPasswordSubmit.Location = new System.Drawing.Point(127, 266);
            this.btn_newPasswordSubmit.Name = "btn_newPasswordSubmit";
            this.btn_newPasswordSubmit.Size = new System.Drawing.Size(257, 118);
            this.btn_newPasswordSubmit.TabIndex = 2;
            this.btn_newPasswordSubmit.Text = "Submit";
            this.btn_newPasswordSubmit.UseVisualStyleBackColor = true;
            this.btn_newPasswordSubmit.Click += new System.EventHandler(this.btn_newPasswordSubmit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(521, 266);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(257, 118);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_enterPasswordConfirm
            // 
            this.txt_enterPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enterPasswordConfirm.Location = new System.Drawing.Point(408, 140);
            this.txt_enterPasswordConfirm.Name = "txt_enterPasswordConfirm";
            this.txt_enterPasswordConfirm.Size = new System.Drawing.Size(360, 35);
            this.txt_enterPasswordConfirm.TabIndex = 1;
            // 
            // txt_enterPassword
            // 
            this.txt_enterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_enterPassword.Location = new System.Drawing.Point(408, 54);
            this.txt_enterPassword.Name = "txt_enterPassword";
            this.txt_enterPassword.Size = new System.Drawing.Size(360, 35);
            this.txt_enterPassword.TabIndex = 1;
            // 
            // lbl_enterPasswordConfirm
            // 
            this.lbl_enterPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterPasswordConfirm.Location = new System.Drawing.Point(129, 140);
            this.lbl_enterPasswordConfirm.Name = "lbl_enterPasswordConfirm";
            this.lbl_enterPasswordConfirm.Size = new System.Drawing.Size(255, 52);
            this.lbl_enterPasswordConfirm.TabIndex = 0;
            this.lbl_enterPasswordConfirm.Text = "Enter new password";
            // 
            // lbl_enterPassword
            // 
            this.lbl_enterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterPassword.Location = new System.Drawing.Point(129, 54);
            this.lbl_enterPassword.Name = "lbl_enterPassword";
            this.lbl_enterPassword.Size = new System.Drawing.Size(255, 52);
            this.lbl_enterPassword.TabIndex = 0;
            this.lbl_enterPassword.Text = "Enter new password";
            // 
            // lbl_codeError
            // 
            this.lbl_codeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codeError.ForeColor = System.Drawing.Color.Red;
            this.lbl_codeError.Location = new System.Drawing.Point(344, 235);
            this.lbl_codeError.Name = "lbl_codeError";
            this.lbl_codeError.Size = new System.Drawing.Size(412, 51);
            this.lbl_codeError.TabIndex = 3;
            // 
            // btn_codeSubmit
            // 
            this.btn_codeSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_codeSubmit.Location = new System.Drawing.Point(163, 336);
            this.btn_codeSubmit.Name = "btn_codeSubmit";
            this.btn_codeSubmit.Size = new System.Drawing.Size(253, 102);
            this.btn_codeSubmit.TabIndex = 2;
            this.btn_codeSubmit.Text = "Submit";
            this.btn_codeSubmit.UseVisualStyleBackColor = true;
            this.btn_codeSubmit.Click += new System.EventHandler(this.btn_codeSubmit_Click);
            // 
            // btn_codeBack
            // 
            this.btn_codeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_codeBack.Location = new System.Drawing.Point(635, 334);
            this.btn_codeBack.Name = "btn_codeBack";
            this.btn_codeBack.Size = new System.Drawing.Size(253, 102);
            this.btn_codeBack.TabIndex = 2;
            this.btn_codeBack.Text = "Back";
            this.btn_codeBack.UseVisualStyleBackColor = true;
            this.btn_codeBack.Click += new System.EventHandler(this.btn_codeBack_Click);
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(344, 186);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(412, 35);
            this.txt_code.TabIndex = 1;
            // 
            // lbl_code
            // 
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.Location = new System.Drawing.Point(415, 77);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(300, 37);
            this.lbl_code.TabIndex = 0;
            this.lbl_code.Text = "Please enter reset code";
            // 
            // lbl_newPasswordError
            // 
            this.lbl_newPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lbl_newPasswordError.Location = new System.Drawing.Point(129, 201);
            this.lbl_newPasswordError.Name = "lbl_newPasswordError";
            this.lbl_newPasswordError.Size = new System.Drawing.Size(649, 36);
            this.lbl_newPasswordError.TabIndex = 3;
            // 
            // form_ForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnl_resetPassword);
            this.Controls.Add(this.pnl_codeValidator);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_forgotPW);
            this.Controls.Add(this.btn_forgotPW);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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