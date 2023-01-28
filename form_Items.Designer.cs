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
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.Location = new System.Drawing.Point(18, 14);
            this.lbl_Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(219, 49);
            this.lbl_Home.TabIndex = 0;
            this.lbl_Home.Text = "Current Home:";
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(826, 565);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(242, 94);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(126, 165);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersWidth = 62;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(942, 372);
            this.dataGridViewItems.TabIndex = 2;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(220, 94);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(105, 49);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User:";
            // 
            // lbl_HomeName
            // 
            this.lbl_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeName.Location = new System.Drawing.Point(246, 14);
            this.lbl_HomeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeName.Name = "lbl_HomeName";
            this.lbl_HomeName.Size = new System.Drawing.Size(208, 49);
            this.lbl_HomeName.TabIndex = 0;
            this.lbl_HomeName.Text = "Home Name";
            // 
            // lbl_CurrentText
            // 
            this.lbl_CurrentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentText.Location = new System.Drawing.Point(18, 94);
            this.lbl_CurrentText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CurrentText.Name = "lbl_CurrentText";
            this.lbl_CurrentText.Size = new System.Drawing.Size(194, 49);
            this.lbl_CurrentText.TabIndex = 0;
            this.lbl_CurrentText.Text = "Current User:";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AddItem.Location = new System.Drawing.Point(986, 115);
            this.btn_AddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(82, 40);
            this.btn_AddItem.TabIndex = 5;
            this.btn_AddItem.Text = "+";
            this.toolTip1.SetToolTip(this.btn_AddItem, "Add Item");
            this.btn_AddItem.UseVisualStyleBackColor = true;
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
            this.pnl_addItem.Location = new System.Drawing.Point(24, 148);
            this.pnl_addItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_addItem.Name = "pnl_addItem";
            this.pnl_addItem.Size = new System.Drawing.Size(68, 40);
            this.pnl_addItem.TabIndex = 6;
            this.pnl_addItem.Visible = false;
            // 
            // btn_ItemSave
            // 
            this.btn_ItemSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ItemSave.Location = new System.Drawing.Point(666, 471);
            this.btn_ItemSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ItemSave.Name = "btn_ItemSave";
            this.btn_ItemSave.Size = new System.Drawing.Size(146, 51);
            this.btn_ItemSave.TabIndex = 13;
            this.btn_ItemSave.Text = "Save";
            this.btn_ItemSave.UseVisualStyleBackColor = true;
            this.btn_ItemSave.Click += new System.EventHandler(this.btn_ItemSave_Click);
            // 
            // btn_CancelItem
            // 
            this.btn_CancelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelItem.Location = new System.Drawing.Point(856, 471);
            this.btn_CancelItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CancelItem.Name = "btn_CancelItem";
            this.btn_CancelItem.Size = new System.Drawing.Size(146, 51);
            this.btn_CancelItem.TabIndex = 14;
            this.btn_CancelItem.Text = "Cancel";
            this.btn_CancelItem.UseVisualStyleBackColor = true;
            this.btn_CancelItem.Click += new System.EventHandler(this.btn_CancelItem_Click);
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPrice.Location = new System.Drawing.Point(230, 188);
            this.txt_itemPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemPrice.MaxLength = 15;
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(342, 35);
            this.txt_itemPrice.TabIndex = 3;
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.Location = new System.Drawing.Point(38, 188);
            this.lbl_itemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(127, 29);
            this.lbl_itemPrice.TabIndex = 12;
            this.lbl_itemPrice.Text = "Item Price:";
            // 
            // txt_itemDesc
            // 
            this.txt_itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemDesc.Location = new System.Drawing.Point(230, 114);
            this.txt_itemDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemDesc.MaxLength = 75;
            this.txt_itemDesc.Name = "txt_itemDesc";
            this.txt_itemDesc.Size = new System.Drawing.Size(486, 35);
            this.txt_itemDesc.TabIndex = 2;
            // 
            // lbl_itemDesc
            // 
            this.lbl_itemDesc.AutoSize = true;
            this.lbl_itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemDesc.Location = new System.Drawing.Point(38, 118);
            this.lbl_itemDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemDesc.Name = "lbl_itemDesc";
            this.lbl_itemDesc.Size = new System.Drawing.Size(193, 29);
            this.lbl_itemDesc.TabIndex = 11;
            this.lbl_itemDesc.Text = "Item Description:";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(230, 45);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemName.MaxLength = 25;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(342, 35);
            this.txt_itemName.TabIndex = 1;
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(38, 49);
            this.lbl_itemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(136, 29);
            this.lbl_itemName.TabIndex = 7;
            this.lbl_itemName.Text = "Item Name:";
            // 
            // form_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnl_addItem);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_CurrentText);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_HomeName);
            this.Controls.Add(this.lbl_Home);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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