﻿namespace Astect
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_HomeUserName = new System.Windows.Forms.Label();
            this.btn_SelectHome = new System.Windows.Forms.Button();
            this.btn_HomeBack = new System.Windows.Forms.Button();
            this.dataGridViewHome = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_AddHome = new System.Windows.Forms.Panel();
            this.lbl_HomeName = new System.Windows.Forms.Label();
            this.txt_HomeName = new System.Windows.Forms.TextBox();
            this.btn_CancelHome = new System.Windows.Forms.Button();
            this.btn_HomeSave = new System.Windows.Forms.Button();
            this.txt_HomeAddress = new System.Windows.Forms.TextBox();
            this.lbl_HomeAddress = new System.Windows.Forms.Label();
            this.txt_HomeCity = new System.Windows.Forms.TextBox();
            this.lbl_HomeCity = new System.Windows.Forms.Label();
            this.txt_HomeState = new System.Windows.Forms.TextBox();
            this.lbl_HomeState = new System.Windows.Forms.Label();
            this.txt_HomeZIP = new System.Windows.Forms.TextBox();
            this.lbl_HomeZIP = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHome)).BeginInit();
            this.pnl_AddHome.SuspendLayout();
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
            this.lbl_HomeUserName.Text = "User";
            // 
            // btn_SelectHome
            // 
            this.btn_SelectHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectHome.Location = new System.Drawing.Point(59, 331);
            this.btn_SelectHome.Name = "btn_SelectHome";
            this.btn_SelectHome.Size = new System.Drawing.Size(168, 58);
            this.btn_SelectHome.TabIndex = 1;
            this.btn_SelectHome.Text = "Select";
            this.btn_SelectHome.UseVisualStyleBackColor = true;
            this.btn_SelectHome.Click += new System.EventHandler(this.btn_SelectHome_Click);
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
            this.dataGridViewHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHome.Size = new System.Drawing.Size(614, 244);
            this.dataGridViewHome.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(650, 37);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(23, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "+";
            this.toolTip1.SetToolTip(this.btn_Add, "Add Home");
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl_AddHome
            // 
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
            this.pnl_AddHome.Location = new System.Drawing.Point(47, 361);
            this.pnl_AddHome.Name = "pnl_AddHome";
            this.pnl_AddHome.Size = new System.Drawing.Size(65, 50);
            this.pnl_AddHome.TabIndex = 5;
            this.pnl_AddHome.Visible = false;
            // 
            // lbl_HomeName
            // 
            this.lbl_HomeName.AutoSize = true;
            this.lbl_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeName.Location = new System.Drawing.Point(22, 29);
            this.lbl_HomeName.Name = "lbl_HomeName";
            this.lbl_HomeName.Size = new System.Drawing.Size(102, 20);
            this.lbl_HomeName.TabIndex = 0;
            this.lbl_HomeName.Text = "Home Name:";
            // 
            // txt_HomeName
            // 
            this.txt_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeName.Location = new System.Drawing.Point(150, 26);
            this.txt_HomeName.MaxLength = 25;
            this.txt_HomeName.Name = "txt_HomeName";
            this.txt_HomeName.Size = new System.Drawing.Size(229, 26);
            this.txt_HomeName.TabIndex = 1;
            // 
            // btn_CancelHome
            // 
            this.btn_CancelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelHome.Location = new System.Drawing.Point(529, 329);
            this.btn_CancelHome.Name = "btn_CancelHome";
            this.btn_CancelHome.Size = new System.Drawing.Size(97, 33);
            this.btn_CancelHome.TabIndex = 7;
            this.btn_CancelHome.Text = "Cancel";
            this.btn_CancelHome.UseVisualStyleBackColor = true;
            this.btn_CancelHome.Click += new System.EventHandler(this.btn_CancelHome_Click);
            // 
            // btn_HomeSave
            // 
            this.btn_HomeSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HomeSave.Location = new System.Drawing.Point(402, 329);
            this.btn_HomeSave.Name = "btn_HomeSave";
            this.btn_HomeSave.Size = new System.Drawing.Size(97, 33);
            this.btn_HomeSave.TabIndex = 6;
            this.btn_HomeSave.Text = "Save";
            this.btn_HomeSave.UseVisualStyleBackColor = true;
            this.btn_HomeSave.Click += new System.EventHandler(this.btn_HomeSave_Click);
            // 
            // txt_HomeAddress
            // 
            this.txt_HomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeAddress.Location = new System.Drawing.Point(150, 71);
            this.txt_HomeAddress.MaxLength = 50;
            this.txt_HomeAddress.Name = "txt_HomeAddress";
            this.txt_HomeAddress.Size = new System.Drawing.Size(229, 26);
            this.txt_HomeAddress.TabIndex = 2;
            // 
            // lbl_HomeAddress
            // 
            this.lbl_HomeAddress.AutoSize = true;
            this.lbl_HomeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeAddress.Location = new System.Drawing.Point(22, 74);
            this.lbl_HomeAddress.Name = "lbl_HomeAddress";
            this.lbl_HomeAddress.Size = new System.Drawing.Size(119, 20);
            this.lbl_HomeAddress.TabIndex = 4;
            this.lbl_HomeAddress.Text = "Home Address:";
            // 
            // txt_HomeCity
            // 
            this.txt_HomeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeCity.Location = new System.Drawing.Point(150, 119);
            this.txt_HomeCity.MaxLength = 25;
            this.txt_HomeCity.Name = "txt_HomeCity";
            this.txt_HomeCity.Size = new System.Drawing.Size(229, 26);
            this.txt_HomeCity.TabIndex = 3;
            // 
            // lbl_HomeCity
            // 
            this.lbl_HomeCity.AutoSize = true;
            this.lbl_HomeCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeCity.Location = new System.Drawing.Point(22, 122);
            this.lbl_HomeCity.Name = "lbl_HomeCity";
            this.lbl_HomeCity.Size = new System.Drawing.Size(86, 20);
            this.lbl_HomeCity.TabIndex = 6;
            this.lbl_HomeCity.Text = "Home City:";
            // 
            // txt_HomeState
            // 
            this.txt_HomeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeState.Location = new System.Drawing.Point(150, 168);
            this.txt_HomeState.MaxLength = 2;
            this.txt_HomeState.Name = "txt_HomeState";
            this.txt_HomeState.Size = new System.Drawing.Size(229, 26);
            this.txt_HomeState.TabIndex = 4;
            // 
            // lbl_HomeState
            // 
            this.lbl_HomeState.AutoSize = true;
            this.lbl_HomeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeState.Location = new System.Drawing.Point(22, 171);
            this.lbl_HomeState.Name = "lbl_HomeState";
            this.lbl_HomeState.Size = new System.Drawing.Size(99, 20);
            this.lbl_HomeState.TabIndex = 8;
            this.lbl_HomeState.Text = "Home State:";
            // 
            // txt_HomeZIP
            // 
            this.txt_HomeZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HomeZIP.Location = new System.Drawing.Point(150, 217);
            this.txt_HomeZIP.MaxLength = 10;
            this.txt_HomeZIP.Name = "txt_HomeZIP";
            this.txt_HomeZIP.Size = new System.Drawing.Size(229, 26);
            this.txt_HomeZIP.TabIndex = 5;
            // 
            // lbl_HomeZIP
            // 
            this.lbl_HomeZIP.AutoSize = true;
            this.lbl_HomeZIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeZIP.Location = new System.Drawing.Point(22, 220);
            this.lbl_HomeZIP.Name = "lbl_HomeZIP";
            this.lbl_HomeZIP.Size = new System.Drawing.Size(85, 20);
            this.lbl_HomeZIP.TabIndex = 10;
            this.lbl_HomeZIP.Text = "Home ZIP:";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Tag = "";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // form_Homes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 439);
            this.Controls.Add(this.pnl_AddHome);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridViewHome);
            this.Controls.Add(this.btn_HomeBack);
            this.Controls.Add(this.btn_SelectHome);
            this.Controls.Add(this.lbl_HomeUserName);
            this.Controls.Add(this.lbl_Welcome);
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}