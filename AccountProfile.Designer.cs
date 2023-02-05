namespace Astect
{
    partial class form_AccountProfile
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
            this.lbl_UserEmail = new System.Windows.Forms.Label();
            this.lbl_UserNameText = new System.Windows.Forms.Label();
            this.lbl_EmailText = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ChangeEmail = new System.Windows.Forms.Button();
            this.pnl_APChangeEmail = new System.Windows.Forms.Panel();
            this.btn_EditEmailPnlUpdate = new System.Windows.Forms.Button();
            this.btn_EditEmailPnlCancel = new System.Windows.Forms.Button();
            this.txt_NewEmail = new System.Windows.Forms.TextBox();
            this.lbl_CurrentEmailText = new System.Windows.Forms.Label();
            this.lbl_NewEmail = new System.Windows.Forms.Label();
            this.lbl_CurrentEmail = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.pnl_APChangePassword = new System.Windows.Forms.Panel();
            this.btn_APChangePasswordCancel = new System.Windows.Forms.Button();
            this.lbl_EnterCurrentPassword = new System.Windows.Forms.Label();
            this.txt_CurrentPassword = new System.Windows.Forms.TextBox();
            this.lbl_EnterNewPassword = new System.Windows.Forms.Label();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.btn_UpdatePassword = new System.Windows.Forms.Button();
            this.pnl_APChangeEmail.SuspendLayout();
            this.pnl_APChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(403, 178);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(141, 29);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User Name:";
            // 
            // lbl_UserEmail
            // 
            this.lbl_UserEmail.AutoSize = true;
            this.lbl_UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserEmail.Location = new System.Drawing.Point(464, 272);
            this.lbl_UserEmail.Name = "lbl_UserEmail";
            this.lbl_UserEmail.Size = new System.Drawing.Size(80, 29);
            this.lbl_UserEmail.TabIndex = 0;
            this.lbl_UserEmail.Text = "Email:";
            // 
            // lbl_UserNameText
            // 
            this.lbl_UserNameText.AutoSize = true;
            this.lbl_UserNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserNameText.Location = new System.Drawing.Point(633, 178);
            this.lbl_UserNameText.Name = "lbl_UserNameText";
            this.lbl_UserNameText.Size = new System.Drawing.Size(188, 29);
            this.lbl_UserNameText.TabIndex = 0;
            this.lbl_UserNameText.Text = "User Name Text";
            // 
            // lbl_EmailText
            // 
            this.lbl_EmailText.AutoSize = true;
            this.lbl_EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailText.Location = new System.Drawing.Point(633, 272);
            this.lbl_EmailText.Name = "lbl_EmailText";
            this.lbl_EmailText.Size = new System.Drawing.Size(127, 29);
            this.lbl_EmailText.TabIndex = 0;
            this.lbl_EmailText.Text = "Email Text";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(894, 530);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(151, 61);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_ChangeEmail
            // 
            this.btn_ChangeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeEmail.Location = new System.Drawing.Point(202, 530);
            this.btn_ChangeEmail.Name = "btn_ChangeEmail";
            this.btn_ChangeEmail.Size = new System.Drawing.Size(175, 61);
            this.btn_ChangeEmail.TabIndex = 1;
            this.btn_ChangeEmail.Text = "Change Email";
            this.btn_ChangeEmail.UseVisualStyleBackColor = true;
            this.btn_ChangeEmail.Click += new System.EventHandler(this.btn_ChangeEmail_Click);
            // 
            // pnl_APChangeEmail
            // 
            this.pnl_APChangeEmail.Controls.Add(this.btn_EditEmailPnlUpdate);
            this.pnl_APChangeEmail.Controls.Add(this.btn_EditEmailPnlCancel);
            this.pnl_APChangeEmail.Controls.Add(this.txt_NewEmail);
            this.pnl_APChangeEmail.Controls.Add(this.lbl_CurrentEmailText);
            this.pnl_APChangeEmail.Controls.Add(this.lbl_NewEmail);
            this.pnl_APChangeEmail.Controls.Add(this.lbl_CurrentEmail);
            this.pnl_APChangeEmail.Location = new System.Drawing.Point(117, 98);
            this.pnl_APChangeEmail.Name = "pnl_APChangeEmail";
            this.pnl_APChangeEmail.Size = new System.Drawing.Size(200, 100);
            this.pnl_APChangeEmail.TabIndex = 2;
            this.pnl_APChangeEmail.Visible = false;
            // 
            // btn_EditEmailPnlUpdate
            // 
            this.btn_EditEmailPnlUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditEmailPnlUpdate.Location = new System.Drawing.Point(255, 530);
            this.btn_EditEmailPnlUpdate.Name = "btn_EditEmailPnlUpdate";
            this.btn_EditEmailPnlUpdate.Size = new System.Drawing.Size(154, 61);
            this.btn_EditEmailPnlUpdate.TabIndex = 2;
            this.btn_EditEmailPnlUpdate.Text = "Update";
            this.btn_EditEmailPnlUpdate.UseVisualStyleBackColor = true;
            this.btn_EditEmailPnlUpdate.Click += new System.EventHandler(this.btn_EditEmailPnlUpdate_Click);
            // 
            // btn_EditEmailPnlCancel
            // 
            this.btn_EditEmailPnlCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditEmailPnlCancel.Location = new System.Drawing.Point(809, 530);
            this.btn_EditEmailPnlCancel.Name = "btn_EditEmailPnlCancel";
            this.btn_EditEmailPnlCancel.Size = new System.Drawing.Size(154, 61);
            this.btn_EditEmailPnlCancel.TabIndex = 3;
            this.btn_EditEmailPnlCancel.Text = "Cancel";
            this.btn_EditEmailPnlCancel.UseVisualStyleBackColor = true;
            this.btn_EditEmailPnlCancel.Click += new System.EventHandler(this.btn_EditEmailPnlCancel_Click);
            // 
            // txt_NewEmail
            // 
            this.txt_NewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewEmail.Location = new System.Drawing.Point(555, 266);
            this.txt_NewEmail.Name = "txt_NewEmail";
            this.txt_NewEmail.Size = new System.Drawing.Size(314, 35);
            this.txt_NewEmail.TabIndex = 1;
            // 
            // lbl_CurrentEmailText
            // 
            this.lbl_CurrentEmailText.AutoSize = true;
            this.lbl_CurrentEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentEmailText.Location = new System.Drawing.Point(550, 162);
            this.lbl_CurrentEmailText.Name = "lbl_CurrentEmailText";
            this.lbl_CurrentEmailText.Size = new System.Drawing.Size(212, 29);
            this.lbl_CurrentEmailText.TabIndex = 0;
            this.lbl_CurrentEmailText.Text = "Current Email Text";
            // 
            // lbl_NewEmail
            // 
            this.lbl_NewEmail.AutoSize = true;
            this.lbl_NewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewEmail.Location = new System.Drawing.Point(305, 272);
            this.lbl_NewEmail.Name = "lbl_NewEmail";
            this.lbl_NewEmail.Size = new System.Drawing.Size(136, 29);
            this.lbl_NewEmail.TabIndex = 0;
            this.lbl_NewEmail.Text = "New Email:";
            // 
            // lbl_CurrentEmail
            // 
            this.lbl_CurrentEmail.AutoSize = true;
            this.lbl_CurrentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentEmail.Location = new System.Drawing.Point(305, 162);
            this.lbl_CurrentEmail.Name = "lbl_CurrentEmail";
            this.lbl_CurrentEmail.Size = new System.Drawing.Size(165, 29);
            this.lbl_CurrentEmail.TabIndex = 0;
            this.lbl_CurrentEmail.Text = "Current Email:";
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangePassword.Location = new System.Drawing.Point(497, 530);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(263, 61);
            this.btn_ChangePassword.TabIndex = 1;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // pnl_APChangePassword
            // 
            this.pnl_APChangePassword.Controls.Add(this.txt_NewPassword);
            this.pnl_APChangePassword.Controls.Add(this.txt_CurrentPassword);
            this.pnl_APChangePassword.Controls.Add(this.lbl_EnterNewPassword);
            this.pnl_APChangePassword.Controls.Add(this.lbl_EnterCurrentPassword);
            this.pnl_APChangePassword.Controls.Add(this.btn_UpdatePassword);
            this.pnl_APChangePassword.Controls.Add(this.btn_APChangePasswordCancel);
            this.pnl_APChangePassword.Location = new System.Drawing.Point(117, 260);
            this.pnl_APChangePassword.Name = "pnl_APChangePassword";
            this.pnl_APChangePassword.Size = new System.Drawing.Size(200, 100);
            this.pnl_APChangePassword.TabIndex = 3;
            this.pnl_APChangePassword.Visible = false;
            // 
            // btn_APChangePasswordCancel
            // 
            this.btn_APChangePasswordCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_APChangePasswordCancel.Location = new System.Drawing.Point(793, 520);
            this.btn_APChangePasswordCancel.Name = "btn_APChangePasswordCancel";
            this.btn_APChangePasswordCancel.Size = new System.Drawing.Size(173, 61);
            this.btn_APChangePasswordCancel.TabIndex = 4;
            this.btn_APChangePasswordCancel.Text = "Cancel";
            this.btn_APChangePasswordCancel.UseVisualStyleBackColor = true;
            this.btn_APChangePasswordCancel.Click += new System.EventHandler(this.btn_APChangePasswordCancel_Click);
            // 
            // lbl_EnterCurrentPassword
            // 
            this.lbl_EnterCurrentPassword.AutoSize = true;
            this.lbl_EnterCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterCurrentPassword.Location = new System.Drawing.Point(270, 185);
            this.lbl_EnterCurrentPassword.Name = "lbl_EnterCurrentPassword";
            this.lbl_EnterCurrentPassword.Size = new System.Drawing.Size(274, 29);
            this.lbl_EnterCurrentPassword.TabIndex = 1;
            this.lbl_EnterCurrentPassword.Text = "Enter Current Password:";
            // 
            // txt_CurrentPassword
            // 
            this.txt_CurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentPassword.Location = new System.Drawing.Point(602, 182);
            this.txt_CurrentPassword.Name = "txt_CurrentPassword";
            this.txt_CurrentPassword.Size = new System.Drawing.Size(384, 35);
            this.txt_CurrentPassword.TabIndex = 1;
            // 
            // lbl_EnterNewPassword
            // 
            this.lbl_EnterNewPassword.AutoSize = true;
            this.lbl_EnterNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterNewPassword.Location = new System.Drawing.Point(270, 301);
            this.lbl_EnterNewPassword.Name = "lbl_EnterNewPassword";
            this.lbl_EnterNewPassword.Size = new System.Drawing.Size(245, 29);
            this.lbl_EnterNewPassword.TabIndex = 1;
            this.lbl_EnterNewPassword.Text = "Enter New Password:";
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPassword.Location = new System.Drawing.Point(602, 292);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(384, 35);
            this.txt_NewPassword.TabIndex = 2;
            // 
            // btn_UpdatePassword
            // 
            this.btn_UpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdatePassword.Location = new System.Drawing.Point(275, 520);
            this.btn_UpdatePassword.Name = "btn_UpdatePassword";
            this.btn_UpdatePassword.Size = new System.Drawing.Size(173, 61);
            this.btn_UpdatePassword.TabIndex = 3;
            this.btn_UpdatePassword.Text = "Update";
            this.btn_UpdatePassword.UseVisualStyleBackColor = true;
            this.btn_UpdatePassword.Click += new System.EventHandler(this.btn_UpdatePassword_Click);
            // 
            // form_AccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnl_APChangePassword);
            this.Controls.Add(this.pnl_APChangeEmail);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.btn_ChangeEmail);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_EmailText);
            this.Controls.Add(this.lbl_UserEmail);
            this.Controls.Add(this.lbl_UserNameText);
            this.Controls.Add(this.lbl_UserName);
            this.Name = "form_AccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Profile";
            this.Load += new System.EventHandler(this.form_AccountProfile_Load);
            this.pnl_APChangeEmail.ResumeLayout(false);
            this.pnl_APChangeEmail.PerformLayout();
            this.pnl_APChangePassword.ResumeLayout(false);
            this.pnl_APChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_UserEmail;
        private System.Windows.Forms.Label lbl_UserNameText;
        private System.Windows.Forms.Label lbl_EmailText;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ChangeEmail;
        private System.Windows.Forms.Panel pnl_APChangeEmail;
        private System.Windows.Forms.Label lbl_CurrentEmailText;
        private System.Windows.Forms.Label lbl_CurrentEmail;
        private System.Windows.Forms.Button btn_EditEmailPnlCancel;
        private System.Windows.Forms.TextBox txt_NewEmail;
        private System.Windows.Forms.Label lbl_NewEmail;
        private System.Windows.Forms.Button btn_EditEmailPnlUpdate;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Panel pnl_APChangePassword;
        private System.Windows.Forms.Button btn_APChangePasswordCancel;
        private System.Windows.Forms.TextBox txt_CurrentPassword;
        private System.Windows.Forms.Label lbl_EnterCurrentPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.Label lbl_EnterNewPassword;
        private System.Windows.Forms.Button btn_UpdatePassword;
    }
}