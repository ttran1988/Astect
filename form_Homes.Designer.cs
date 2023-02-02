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
            this.btn_SelectHome = new System.Windows.Forms.Button();
            this.btn_HomeBack = new System.Windows.Forms.Button();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_AddHome = new System.Windows.Forms.Panel();
            this.btn_HomeUpdate = new System.Windows.Forms.Button();
            this.txt_HomeZIP = new System.Windows.Forms.TextBox();
            this.lbl_HomeZIP = new System.Windows.Forms.Label();
            this.txt_HomeState = new System.Windows.Forms.TextBox();
            this.lbl_HomeState = new System.Windows.Forms.Label();
            this.txt_HomeCity = new System.Windows.Forms.TextBox();
            this.lbl_HomeCity = new System.Windows.Forms.Label();
            this.txt_HomeAddress = new System.Windows.Forms.TextBox();
            this.lbl_HomeAddress = new System.Windows.Forms.Label();
            this.btn_HomeSave = new System.Windows.Forms.Button();
            this.btn_CancelHome = new System.Windows.Forms.Button();
            this.txt_HomeName = new System.Windows.Forms.TextBox();
            this.lbl_HomeName = new System.Windows.Forms.Label();
            this.btn_HomeEdit = new System.Windows.Forms.Button();
            this.btn_HomeDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            this.pnl_AddHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(18, 14);
            this.lbl_Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(150, 35);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // lbl_HomeUserName
            // 
            this.lbl_HomeUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeUserName.Location = new System.Drawing.Point(18, 68);
            this.lbl_HomeUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeUserName.Name = "lbl_HomeUserName";
            this.lbl_HomeUserName.Size = new System.Drawing.Size(150, 35);
            this.lbl_HomeUserName.TabIndex = 0;
            this.lbl_HomeUserName.Text = "User";
            // 
            // btn_SelectHome
            // 
            this.btn_SelectHome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_SelectHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectHome.Location = new System.Drawing.Point(340, 535);
            this.btn_SelectHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SelectHome.Name = "btn_SelectHome";
            this.btn_SelectHome.Size = new System.Drawing.Size(142, 55);
            this.btn_SelectHome.TabIndex = 1;
            this.btn_SelectHome.Text = "Select";
            this.btn_SelectHome.UseVisualStyleBackColor = false;
            this.btn_SelectHome.Click += new System.EventHandler(this.btn_SelectHome_Click);
            // 
            // btn_HomeBack
            // 
            this.btn_HomeBack.BackColor = System.Drawing.Color.Tomato;
            this.btn_HomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeBack.Location = new System.Drawing.Point(18, 574);
            this.btn_HomeBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_HomeBack.Name = "btn_HomeBack";
            this.btn_HomeBack.Size = new System.Drawing.Size(242, 94);
            this.btn_HomeBack.TabIndex = 5;
            this.btn_HomeBack.Text = "Back";
            this.btn_HomeBack.UseVisualStyleBackColor = false;
            this.btn_HomeBack.Click += new System.EventHandler(this.btn_HomeBack_Click);
            // 
            // dataGridViewHome
            // 
            this.dataGridViewHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHome.Location = new System.Drawing.Point(340, 151);
            this.dataGridViewHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewHome.Name = "dataGridViewHome";
            this.dataGridViewHome.ReadOnly = true;
            this.dataGridViewHome.RowHeadersWidth = 62;
            this.dataGridViewHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHome.Size = new System.Drawing.Size(838, 375);
            this.dataGridViewHome.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(675, 535);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(142, 55);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "New";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl_AddHome
            // 
            this.pnl_AddHome.Controls.Add(this.btn_HomeUpdate);
            this.pnl_AddHome.Controls.Add(this.txt_HomeZIP);
            this.pnl_AddHome.Controls.Add(this.lbl_HomeZIP);
            this.pnl_AddHome.Controls.Add(this.txt_HomeState);
            this.pnl_AddHome.Controls.Add(this.lbl_HomeState);
            this.pnl_AddHome.Controls.Add(this.txt_HomeCity);
            this.pnl_AddHome.Controls.Add(this.lbl_HomeCity);
            this.pnl_AddHome.Controls.Add(this.txt_HomeAddress);
            this.pnl_AddHome.Controls.Add(this.lbl_HomeAddress);
            this.pnl_AddHome.Controls.Add(this.btn_HomeSave);
            this.pnl_AddHome.Controls.Add(this.btn_CancelHome);
            this.pnl_AddHome.Controls.Add(this.txt_HomeName);
            this.pnl_AddHome.Controls.Add(this.lbl_HomeName);
            this.pnl_AddHome.Location = new System.Drawing.Point(24, 151);
            this.pnl_AddHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_AddHome.Name = "pnl_AddHome";
            this.pnl_AddHome.Size = new System.Drawing.Size(62, 45);
            this.pnl_AddHome.TabIndex = 5;
            this.pnl_AddHome.Visible = false;
            // 
            // btn_HomeUpdate
            // 
            this.btn_HomeUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HomeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeUpdate.Location = new System.Drawing.Point(392, 506);
            this.btn_HomeUpdate.Name = "btn_HomeUpdate";
            this.btn_HomeUpdate.Size = new System.Drawing.Size(142, 55);
            this.btn_HomeUpdate.TabIndex = 6;
            this.btn_HomeUpdate.Text = "Update";
            this.btn_HomeUpdate.UseVisualStyleBackColor = false;
            this.btn_HomeUpdate.Visible = false;
            this.btn_HomeUpdate.Click += new System.EventHandler(this.btn_HomeUpdate_Click);
            // 
            // txt_HomeZIP
            // 
            this.txt_HomeZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeZIP.Location = new System.Drawing.Point(357, 329);
            this.txt_HomeZIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HomeZIP.MaxLength = 10;
            this.txt_HomeZIP.Name = "txt_HomeZIP";
            this.txt_HomeZIP.Size = new System.Drawing.Size(342, 35);
            this.txt_HomeZIP.TabIndex = 5;
            // 
            // lbl_HomeZIP
            // 
            this.lbl_HomeZIP.AutoSize = true;
            this.lbl_HomeZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeZIP.Location = new System.Drawing.Point(33, 338);
            this.lbl_HomeZIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeZIP.Name = "lbl_HomeZIP";
            this.lbl_HomeZIP.Size = new System.Drawing.Size(163, 33);
            this.lbl_HomeZIP.TabIndex = 10;
            this.lbl_HomeZIP.Text = "Home ZIP:";
            // 
            // txt_HomeState
            // 
            this.txt_HomeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeState.Location = new System.Drawing.Point(357, 258);
            this.txt_HomeState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HomeState.MaxLength = 2;
            this.txt_HomeState.Name = "txt_HomeState";
            this.txt_HomeState.Size = new System.Drawing.Size(342, 35);
            this.txt_HomeState.TabIndex = 4;
            // 
            // lbl_HomeState
            // 
            this.lbl_HomeState.AutoSize = true;
            this.lbl_HomeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeState.Location = new System.Drawing.Point(33, 263);
            this.lbl_HomeState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeState.Name = "lbl_HomeState";
            this.lbl_HomeState.Size = new System.Drawing.Size(187, 33);
            this.lbl_HomeState.TabIndex = 8;
            this.lbl_HomeState.Text = "Home State:";
            // 
            // txt_HomeCity
            // 
            this.txt_HomeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeCity.Location = new System.Drawing.Point(357, 183);
            this.txt_HomeCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HomeCity.MaxLength = 25;
            this.txt_HomeCity.Name = "txt_HomeCity";
            this.txt_HomeCity.Size = new System.Drawing.Size(342, 35);
            this.txt_HomeCity.TabIndex = 3;
            // 
            // lbl_HomeCity
            // 
            this.lbl_HomeCity.AutoSize = true;
            this.lbl_HomeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeCity.Location = new System.Drawing.Point(33, 188);
            this.lbl_HomeCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeCity.Name = "lbl_HomeCity";
            this.lbl_HomeCity.Size = new System.Drawing.Size(170, 33);
            this.lbl_HomeCity.TabIndex = 6;
            this.lbl_HomeCity.Text = "Home City:";
            // 
            // txt_HomeAddress
            // 
            this.txt_HomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeAddress.Location = new System.Drawing.Point(357, 109);
            this.txt_HomeAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HomeAddress.MaxLength = 50;
            this.txt_HomeAddress.Name = "txt_HomeAddress";
            this.txt_HomeAddress.Size = new System.Drawing.Size(342, 35);
            this.txt_HomeAddress.TabIndex = 2;
            // 
            // lbl_HomeAddress
            // 
            this.lbl_HomeAddress.AutoSize = true;
            this.lbl_HomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeAddress.Location = new System.Drawing.Point(33, 114);
            this.lbl_HomeAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeAddress.Name = "lbl_HomeAddress";
            this.lbl_HomeAddress.Size = new System.Drawing.Size(229, 33);
            this.lbl_HomeAddress.TabIndex = 4;
            this.lbl_HomeAddress.Text = "Home Address:";
            // 
            // btn_HomeSave
            // 
            this.btn_HomeSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HomeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeSave.Location = new System.Drawing.Point(392, 506);
            this.btn_HomeSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_HomeSave.Name = "btn_HomeSave";
            this.btn_HomeSave.Size = new System.Drawing.Size(146, 51);
            this.btn_HomeSave.TabIndex = 6;
            this.btn_HomeSave.Text = "Save";
            this.btn_HomeSave.UseVisualStyleBackColor = false;
            this.btn_HomeSave.Visible = false;
            this.btn_HomeSave.Click += new System.EventHandler(this.btn_HomeSave_Click);
            // 
            // btn_CancelHome
            // 
            this.btn_CancelHome.BackColor = System.Drawing.Color.Tomato;
            this.btn_CancelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelHome.Location = new System.Drawing.Point(592, 506);
            this.btn_CancelHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CancelHome.Name = "btn_CancelHome";
            this.btn_CancelHome.Size = new System.Drawing.Size(142, 55);
            this.btn_CancelHome.TabIndex = 7;
            this.btn_CancelHome.Text = "Cancel";
            this.btn_CancelHome.UseVisualStyleBackColor = false;
            this.btn_CancelHome.Click += new System.EventHandler(this.btn_CancelHome_Click);
            // 
            // txt_HomeName
            // 
            this.txt_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeName.Location = new System.Drawing.Point(357, 35);
            this.txt_HomeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HomeName.MaxLength = 25;
            this.txt_HomeName.Name = "txt_HomeName";
            this.txt_HomeName.Size = new System.Drawing.Size(342, 35);
            this.txt_HomeName.TabIndex = 1;
            // 
            // lbl_HomeName
            // 
            this.lbl_HomeName.AutoSize = true;
            this.lbl_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeName.Location = new System.Drawing.Point(33, 45);
            this.lbl_HomeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeName.Name = "lbl_HomeName";
            this.lbl_HomeName.Size = new System.Drawing.Size(197, 33);
            this.lbl_HomeName.TabIndex = 0;
            this.lbl_HomeName.Text = "Home Name:";
            // 
            // btn_HomeEdit
            // 
            this.btn_HomeEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HomeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeEdit.Location = new System.Drawing.Point(510, 535);
            this.btn_HomeEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_HomeEdit.Name = "btn_HomeEdit";
            this.btn_HomeEdit.Size = new System.Drawing.Size(142, 55);
            this.btn_HomeEdit.TabIndex = 2;
            this.btn_HomeEdit.Text = "Edit";
            this.btn_HomeEdit.UseVisualStyleBackColor = false;
            this.btn_HomeEdit.Click += new System.EventHandler(this.btn_HomeEdit_Click);
            // 
            // btn_HomeDelete
            // 
            this.btn_HomeDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_HomeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeDelete.Location = new System.Drawing.Point(842, 535);
            this.btn_HomeDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_HomeDelete.Name = "btn_HomeDelete";
            this.btn_HomeDelete.Size = new System.Drawing.Size(142, 55);
            this.btn_HomeDelete.TabIndex = 4;
            this.btn_HomeDelete.Text = "Delete";
            this.btn_HomeDelete.UseVisualStyleBackColor = false;
            this.btn_HomeDelete.Click += new System.EventHandler(this.btn_HomeDelete_Click);
            // 
            // form_Homes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1197, 686);
            this.Controls.Add(this.btn_HomeDelete);
            this.Controls.Add(this.pnl_AddHome);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridViewHome);
            this.Controls.Add(this.btn_HomeBack);
            this.Controls.Add(this.btn_SelectHome);
            this.Controls.Add(this.lbl_HomeUserName);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_HomeEdit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_Homes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomes";
            this.Load += new System.EventHandler(this.form_Homes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).EndInit();
            this.pnl_AddHome.ResumeLayout(false);
            this.pnl_AddHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_HomeUserName;
        private System.Windows.Forms.Button btn_SelectHome;
        private System.Windows.Forms.Button btn_HomeBack;
        private System.Windows.Forms.DataGridView dataGridViewHome;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_HomeEdit;
        private System.Windows.Forms.Button btn_HomeUpdate;
        private System.Windows.Forms.Button btn_HomeDelete;
        private System.Windows.Forms.Panel pnl_AddHome;
        private System.Windows.Forms.Button btn_HomeSave;
        private System.Windows.Forms.Button btn_CancelHome;
        private System.Windows.Forms.TextBox txt_HomeName;
        private System.Windows.Forms.Label lbl_HomeName;
        private System.Windows.Forms.TextBox txt_HomeZIP;
        private System.Windows.Forms.Label lbl_HomeZIP;
        private System.Windows.Forms.TextBox txt_HomeState;
        private System.Windows.Forms.Label lbl_HomeState;
        private System.Windows.Forms.TextBox txt_HomeCity;
        private System.Windows.Forms.Label lbl_HomeCity;
        private System.Windows.Forms.TextBox txt_HomeAddress;
        private System.Windows.Forms.Label lbl_HomeAddress;
    }
}