namespace Astect
{
    partial class form_Items
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
            this.lbl_Home = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_HomeName = new System.Windows.Forms.Label();
            this.lbl_CurrentText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Home
            // 
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.Location = new System.Drawing.Point(12, 9);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(146, 32);
            this.lbl_Home.TabIndex = 0;
            this.lbl_Home.Text = "Current Home:";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(551, 367);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(161, 61);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(84, 107);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(628, 242);
            this.dataGridViewItems.TabIndex = 2;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(147, 61);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(70, 32);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User:";
            // 
            // lbl_HomeName
            // 
            this.lbl_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeName.Location = new System.Drawing.Point(164, 9);
            this.lbl_HomeName.Name = "lbl_HomeName";
            this.lbl_HomeName.Size = new System.Drawing.Size(139, 32);
            this.lbl_HomeName.TabIndex = 0;
            this.lbl_HomeName.Text = "Home Name";
            // 
            // lbl_CurrentText
            // 
            this.lbl_CurrentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentText.Location = new System.Drawing.Point(12, 61);
            this.lbl_CurrentText.Name = "lbl_CurrentText";
            this.lbl_CurrentText.Size = new System.Drawing.Size(129, 32);
            this.lbl_CurrentText.TabIndex = 0;
            this.lbl_CurrentText.Text = "Current User:";
            // 
            // form_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_CurrentText);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_HomeName);
            this.Controls.Add(this.lbl_Home);
            this.Name = "form_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Items";
            this.Load += new System.EventHandler(this.form_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_HomeName;
        private System.Windows.Forms.Label lbl_CurrentText;
    }
}