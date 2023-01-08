
namespace IT488NewUser
{
    partial class Form1
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
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.NewUserID = new System.Windows.Forms.Label();
            this.FirstNameInput = new System.Windows.Forms.TextBox();
            this.LastNameInput = new System.Windows.Forms.TextBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.PhoneNumberInput = new System.Windows.Forms.TextBox();
            this.NewUserIDInput = new System.Windows.Forms.TextBox();
            this.SubmitInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Location = new System.Drawing.Point(315, 52);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(152, 20);
            this.WelcomeMessage.TabIndex = 0;
            this.WelcomeMessage.Text = "Welcome New User!";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(100, 135);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(90, 20);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(100, 189);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(90, 20);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(100, 241);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(52, 20);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email:";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(100, 289);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.PhoneNumber.TabIndex = 4;
            this.PhoneNumber.Text = "Phone Number:";
            // 
            // NewUserID
            // 
            this.NewUserID.AutoSize = true;
            this.NewUserID.Location = new System.Drawing.Point(100, 339);
            this.NewUserID.Name = "NewUserID";
            this.NewUserID.Size = new System.Drawing.Size(103, 20);
            this.NewUserID.TabIndex = 5;
            this.NewUserID.Text = "New User ID:";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(344, 135);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(230, 26);
            this.FirstNameInput.TabIndex = 6;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(344, 189);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(230, 26);
            this.LastNameInput.TabIndex = 7;
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(344, 241);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(230, 26);
            this.EmailInput.TabIndex = 8;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.Location = new System.Drawing.Point(344, 289);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(230, 26);
            this.PhoneNumberInput.TabIndex = 11;
            // 
            // NewUserIDInput
            // 
            this.NewUserIDInput.Location = new System.Drawing.Point(344, 339);
            this.NewUserIDInput.Name = "NewUserIDInput";
            this.NewUserIDInput.Size = new System.Drawing.Size(230, 26);
            this.NewUserIDInput.TabIndex = 12;
            // 
            // SubmitInfo
            // 
            this.SubmitInfo.Location = new System.Drawing.Point(457, 393);
            this.SubmitInfo.Name = "SubmitInfo";
            this.SubmitInfo.Size = new System.Drawing.Size(117, 45);
            this.SubmitInfo.TabIndex = 13;
            this.SubmitInfo.Text = "Submit";
            this.SubmitInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitInfo);
            this.Controls.Add(this.NewUserIDInput);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.NewUserID);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.WelcomeMessage);
            this.Name = "Form1";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label NewUserID;
        private System.Windows.Forms.TextBox FirstNameInput;
        private System.Windows.Forms.TextBox LastNameInput;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.TextBox PhoneNumberInput;
        private System.Windows.Forms.TextBox NewUserIDInput;
        private System.Windows.Forms.Button SubmitInfo;
    }
}

