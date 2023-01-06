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
            // form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_RegistrationBack);
            this.Name = "form_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Registration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RegistrationBack;
    }
}