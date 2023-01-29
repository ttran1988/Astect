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
            this.components = new System.ComponentModel.Container();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_HomeName = new System.Windows.Forms.Label();
            this.lbl_CurrentText = new System.Windows.Forms.Label();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.pnl_addItem = new System.Windows.Forms.Panel();
            this.btn_ItemSave = new System.Windows.Forms.Button();
            this.btn_CancelItem = new System.Windows.Forms.Button();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.txt_itemDesc = new System.Windows.Forms.TextBox();
            this.lbl_itemDesc = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.pnl_addItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Home
            // 
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.Location = new System.Drawing.Point(94, 218);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(257, 46);
            this.lbl_Home.TabIndex = 0;
            this.lbl_Home.Text = "Current Home:";
            this.lbl_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Tomato;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(12, 377);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(161, 61);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(418, 96);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersWidth = 62;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(370, 242);
            this.dataGridViewItems.TabIndex = 2;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(94, 170);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(257, 32);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User:";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_HomeName
            // 
            this.lbl_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeName.Location = new System.Drawing.Point(94, 264);
            this.lbl_HomeName.Name = "lbl_HomeName";
            this.lbl_HomeName.Size = new System.Drawing.Size(257, 32);
            this.lbl_HomeName.TabIndex = 0;
            this.lbl_HomeName.Text = "Home Name";
            this.lbl_HomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CurrentText
            // 
            this.lbl_CurrentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentText.Location = new System.Drawing.Point(94, 138);
            this.lbl_CurrentText.Name = "lbl_CurrentText";
            this.lbl_CurrentText.Size = new System.Drawing.Size(257, 32);
            this.lbl_CurrentText.TabIndex = 0;
            this.lbl_CurrentText.Text = "Current User:";
            this.lbl_CurrentText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddItem.Location = new System.Drawing.Point(418, 344);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(144, 41);
            this.btn_AddItem.TabIndex = 5;
            this.btn_AddItem.Text = "Add Item";
            this.toolTip1.SetToolTip(this.btn_AddItem, "Add Item");
            this.btn_AddItem.UseVisualStyleBackColor = false;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // pnl_addItem
            // 
            this.pnl_addItem.Controls.Add(this.btn_ItemSave);
            this.pnl_addItem.Controls.Add(this.btn_CancelItem);
            this.pnl_addItem.Controls.Add(this.txt_itemPrice);
            this.pnl_addItem.Controls.Add(this.lbl_itemPrice);
            this.pnl_addItem.Controls.Add(this.txt_itemDesc);
            this.pnl_addItem.Controls.Add(this.lbl_itemDesc);
            this.pnl_addItem.Controls.Add(this.txt_itemName);
            this.pnl_addItem.Controls.Add(this.lbl_itemName);
            this.pnl_addItem.Location = new System.Drawing.Point(16, 96);
            this.pnl_addItem.Name = "pnl_addItem";
            this.pnl_addItem.Size = new System.Drawing.Size(45, 26);
            this.pnl_addItem.TabIndex = 6;
            this.pnl_addItem.Visible = false;
            // 
            // btn_ItemSave
            // 
            this.btn_ItemSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ItemSave.Location = new System.Drawing.Point(444, 306);
            this.btn_ItemSave.Name = "btn_ItemSave";
            this.btn_ItemSave.Size = new System.Drawing.Size(97, 33);
            this.btn_ItemSave.TabIndex = 13;
            this.btn_ItemSave.Text = "Save";
            this.btn_ItemSave.UseVisualStyleBackColor = true;
            this.btn_ItemSave.Click += new System.EventHandler(this.btn_ItemSave_Click);
            // 
            // btn_CancelItem
            // 
            this.btn_CancelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelItem.Location = new System.Drawing.Point(571, 306);
            this.btn_CancelItem.Name = "btn_CancelItem";
            this.btn_CancelItem.Size = new System.Drawing.Size(97, 33);
            this.btn_CancelItem.TabIndex = 14;
            this.btn_CancelItem.Text = "Cancel";
            this.btn_CancelItem.UseVisualStyleBackColor = true;
            this.btn_CancelItem.Click += new System.EventHandler(this.btn_CancelItem_Click);
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPrice.Location = new System.Drawing.Point(153, 122);
            this.txt_itemPrice.MaxLength = 15;
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(229, 26);
            this.txt_itemPrice.TabIndex = 3;
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.Location = new System.Drawing.Point(25, 122);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(84, 20);
            this.lbl_itemPrice.TabIndex = 12;
            this.lbl_itemPrice.Text = "Item Price:";
            // 
            // txt_itemDesc
            // 
            this.txt_itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemDesc.Location = new System.Drawing.Point(153, 74);
            this.txt_itemDesc.MaxLength = 75;
            this.txt_itemDesc.Name = "txt_itemDesc";
            this.txt_itemDesc.Size = new System.Drawing.Size(325, 26);
            this.txt_itemDesc.TabIndex = 2;
            // 
            // lbl_itemDesc
            // 
            this.lbl_itemDesc.AutoSize = true;
            this.lbl_itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemDesc.Location = new System.Drawing.Point(25, 77);
            this.lbl_itemDesc.Name = "lbl_itemDesc";
            this.lbl_itemDesc.Size = new System.Drawing.Size(129, 20);
            this.lbl_itemDesc.TabIndex = 11;
            this.lbl_itemDesc.Text = "Item Description:";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(153, 29);
            this.txt_itemName.MaxLength = 25;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(229, 26);
            this.txt_itemName.TabIndex = 1;
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(25, 32);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(91, 20);
            this.lbl_itemName.TabIndex = 7;
            this.lbl_itemName.Text = "Item Name:";
            // 
            // form_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_addItem);
            this.Controls.Add(this.btn_AddItem);
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
            this.pnl_addItem.ResumeLayout(false);
            this.pnl_addItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_HomeName;
        private System.Windows.Forms.Label lbl_CurrentText;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Panel pnl_addItem;
        private System.Windows.Forms.TextBox txt_itemPrice;
        private System.Windows.Forms.Label lbl_itemPrice;
        private System.Windows.Forms.TextBox txt_itemDesc;
        private System.Windows.Forms.Label lbl_itemDesc;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_ItemSave;
        private System.Windows.Forms.Button btn_CancelItem;
    }
}