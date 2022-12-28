namespace Astect
{
    partial class form_Homes
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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_HomeUserName = new System.Windows.Forms.Label();
            this.btn_TestUserID = new System.Windows.Forms.Button();
            this.btn_HomeBack = new System.Windows.Forms.Button();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(12, 9);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(100, 23);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // lbl_HomeUserName
            // 
            this.lbl_HomeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeUserName.Location = new System.Drawing.Point(127, 9);
            this.lbl_HomeUserName.Name = "lbl_HomeUserName";
            this.lbl_HomeUserName.Size = new System.Drawing.Size(100, 23);
            this.lbl_HomeUserName.TabIndex = 0;
            this.lbl_HomeUserName.Click += new System.EventHandler(this.lbl_HomeUserName_Click);
            // 
            // btn_TestUserID
            // 
            this.btn_TestUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestUserID.Location = new System.Drawing.Point(59, 331);
            this.btn_TestUserID.Name = "btn_TestUserID";
            this.btn_TestUserID.Size = new System.Drawing.Size(168, 58);
            this.btn_TestUserID.TabIndex = 1;
            this.btn_TestUserID.Text = "Test Get User ID";
            this.btn_TestUserID.UseVisualStyleBackColor = true;
            this.btn_TestUserID.Click += new System.EventHandler(this.btn_TestUserID_Click);
            // 
            // btn_HomeBack
            // 
            this.btn_HomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeBack.Location = new System.Drawing.Point(505, 331);
            this.btn_HomeBack.Name = "btn_HomeBack";
            this.btn_HomeBack.Size = new System.Drawing.Size(168, 58);
            this.btn_HomeBack.TabIndex = 2;
            this.btn_HomeBack.Text = "Back";
            this.btn_HomeBack.UseVisualStyleBackColor = true;
            this.btn_HomeBack.Click += new System.EventHandler(this.btn_HomeBack_Click);
            // 
            // dataGridViewHome
            // 
            this.dataGridViewHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHome.Location = new System.Drawing.Point(59, 66);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.Size = new System.Drawing.Size(614, 244);
            this.dataGridViewHome.TabIndex = 3;
            // 
            // form_Homes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewHome);
            this.Controls.Add(this.btn_HomeBack);
            this.Controls.Add(this.btn_TestUserID);
            this.Controls.Add(this.lbl_HomeUserName);
            this.Controls.Add(this.lbl_Welcome);
            this.Name = "form_Homes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomes";
            this.Load += new System.EventHandler(this.form_Homes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_HomeUserName;
        private System.Windows.Forms.Button btn_TestUserID;
        private System.Windows.Forms.Button btn_HomeBack;
        private System.Windows.Forms.DataGridView dataGridViewHome;
    }
}