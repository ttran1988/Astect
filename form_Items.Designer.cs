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
            this.pnl_EditItem = new System.Windows.Forms.Panel();
            this.txtEditSerialNbr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditModelNbr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.txtEditItemPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditItemDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditItemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ItemSave = new System.Windows.Forms.Button();
            this.btn_CancelItem = new System.Windows.Forms.Button();
            this.txt_itemPrice = new System.Windows.Forms.TextBox();
            this.lbl_itemPrice = new System.Windows.Forms.Label();
            this.txt_itemDesc = new System.Windows.Forms.TextBox();
            this.lbl_itemDesc = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.pnl_addItem.SuspendLayout();
            this.pnl_EditItem.SuspendLayout();
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
            this.pnl_addItem.Controls.Add(this.txtSerial);
            this.pnl_addItem.Controls.Add(this.label2);
            this.pnl_addItem.Controls.Add(this.txtModel);
            this.pnl_addItem.Controls.Add(this.label1);
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
            // pnl_EditItem
            // 
            this.pnl_EditItem.Controls.Add(this.txtEditSerialNbr);
            this.pnl_EditItem.Controls.Add(this.label3);
            this.pnl_EditItem.Controls.Add(this.txtEditModelNbr);
            this.pnl_EditItem.Controls.Add(this.label4);
            this.pnl_EditItem.Controls.Add(this.btnEditSave);
            this.pnl_EditItem.Controls.Add(this.btnEditCancel);
            this.pnl_EditItem.Controls.Add(this.txtEditItemPrice);
            this.pnl_EditItem.Controls.Add(this.label5);
            this.pnl_EditItem.Controls.Add(this.txtEditItemDesc);
            this.pnl_EditItem.Controls.Add(this.label6);
            this.pnl_EditItem.Controls.Add(this.txtEditItemName);
            this.pnl_EditItem.Controls.Add(this.label7);
            this.pnl_EditItem.Location = new System.Drawing.Point(12, 101);
            this.pnl_EditItem.Name = "pnl_EditItem";
            this.pnl_EditItem.Size = new System.Drawing.Size(42, 21);
            this.pnl_EditItem.TabIndex = 19;
            this.pnl_EditItem.Visible = false;
            // 
            // txtEditSerialNbr
            // 
            this.txtEditSerialNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSerialNbr.Location = new System.Drawing.Point(156, 196);
            this.txtEditSerialNbr.MaxLength = 15;
            this.txtEditSerialNbr.Name = "txtEditSerialNbr";
            this.txtEditSerialNbr.Size = new System.Drawing.Size(229, 26);
            this.txtEditSerialNbr.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Serial Number:";
            // 
            // txtEditModelNbr
            // 
            this.txtEditModelNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditModelNbr.Location = new System.Drawing.Point(155, 152);
            this.txtEditModelNbr.MaxLength = 15;
            this.txtEditModelNbr.Name = "txtEditModelNbr";
            this.txtEditModelNbr.Size = new System.Drawing.Size(229, 26);
            this.txtEditModelNbr.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Model Number:";
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.Location = new System.Drawing.Point(446, 291);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(97, 33);
            this.btnEditSave.TabIndex = 25;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(573, 291);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(97, 33);
            this.btnEditCancel.TabIndex = 26;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // txtEditItemPrice
            // 
            this.txtEditItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemPrice.Location = new System.Drawing.Point(155, 107);
            this.txtEditItemPrice.MaxLength = 15;
            this.txtEditItemPrice.Name = "txtEditItemPrice";
            this.txtEditItemPrice.Size = new System.Drawing.Size(229, 26);
            this.txtEditItemPrice.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Item Price:";
            // 
            // txtEditItemDesc
            // 
            this.txtEditItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemDesc.Location = new System.Drawing.Point(155, 59);
            this.txtEditItemDesc.MaxLength = 75;
            this.txtEditItemDesc.Name = "txtEditItemDesc";
            this.txtEditItemDesc.Size = new System.Drawing.Size(325, 26);
            this.txtEditItemDesc.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Item Description:";
            // 
            // txtEditItemName
            // 
            this.txtEditItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemName.Location = new System.Drawing.Point(155, 14);
            this.txtEditItemName.MaxLength = 25;
            this.txtEditItemName.Name = "txtEditItemName";
            this.txtEditItemName.Size = new System.Drawing.Size(229, 26);
            this.txtEditItemName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Item Name:";
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(154, 211);
            this.txtSerial.MaxLength = 15;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(229, 26);
            this.txtSerial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Serial Number:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(153, 167);
            this.txtModel.MaxLength = 15;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(229, 26);
            this.txtModel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Model Number:";
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
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(168, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(55, 26);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(645, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 26);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(597, 9);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(115, 26);
            this.btnDeleteAll.TabIndex = 20;
            this.btnDeleteAll.Text = "Delete All Items";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
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
            this.pnl_EditItem.ResumeLayout(false);
            this.pnl_EditItem.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnl_EditItem;
        private System.Windows.Forms.TextBox txtEditSerialNbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditModelNbr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.TextBox txtEditItemPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditItemDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditItemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}