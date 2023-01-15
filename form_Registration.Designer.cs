namespace Astect
{
    partial class form_Registration
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
            this.btn_RegistrationBack = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_UserPassword = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_UserPassword = new System.Windows.Forms.TextBox();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_RegistrationBack
            // 
            this.btn_RegistrationBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrationBack.Location = new System.Drawing.Point(817, 511);
            this.btn_RegistrationBack.Name = "btn_RegistrationBack";
            this.btn_RegistrationBack.Size = new System.Drawing.Size(219, 85);
            this.btn_RegistrationBack.TabIndex = 0;
            this.btn_RegistrationBack.Text = "Back";
            this.btn_RegistrationBack.UseVisualStyleBackColor = true;
            this.btn_RegistrationBack.Click += new System.EventHandler(this.btn_RegistrationBack_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(233, 148);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(148, 39);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "Username:";
            // 
            // lbl_UserPassword
            // 
            this.lbl_UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserPassword.Location = new System.Drawing.Point(233, 312);
            this.lbl_UserPassword.Name = "lbl_UserPassword";
            this.lbl_UserPassword.Size = new System.Drawing.Size(148, 39);
            this.lbl_UserPassword.TabIndex = 1;
            this.lbl_UserPassword.Text = "Password:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(437, 152);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(302, 35);
            this.txt_UserName.TabIndex = 2;
            // 
            // txt_UserPassword
            // 
            this.txt_UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserPassword.Location = new System.Drawing.Point(437, 309);
            this.txt_UserPassword.Name = "txt_UserPassword";
            this.txt_UserPassword.PasswordChar = '*';
            this.txt_UserPassword.Size = new System.Drawing.Size(302, 35);
            this.txt_UserPassword.TabIndex = 2;
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.Location = new System.Drawing.Point(207, 511);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(219, 85);
            this.btn_CreateUser.TabIndex = 0;
            this.btn_CreateUser.Text = "Create";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txt_UserPassword);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserPassword);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.btn_RegistrationBack);
            this.Name = "form_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegistrationBack;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_UserPassword;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_UserPassword;
        private System.Windows.Forms.Button btn_CreateUser;
    }
}