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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btn_ExportItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.pnl_addItem.SuspendLayout();
            this.pnl_EditItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Home
            // 
            this.lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.Location = new System.Drawing.Point(90, 212);
            this.lbl_Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(364, 49);
            this.lbl_Home.TabIndex = 0;
            this.lbl_Home.Text = "Current Home:";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Tomato;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(18, 580);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(242, 94);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(334, 166);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.RowHeadersWidth = 62;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(848, 360);
            this.dataGridViewItems.TabIndex = 2;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(90, 408);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(314, 49);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "User:";
            // 
            // lbl_HomeName
            // 
            this.lbl_HomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomeName.Location = new System.Drawing.Point(90, 262);
            this.lbl_HomeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HomeName.Name = "lbl_HomeName";
            this.lbl_HomeName.Size = new System.Drawing.Size(363, 49);
            this.lbl_HomeName.TabIndex = 0;
            this.lbl_HomeName.Text = "Home Name";
            // 
            // lbl_CurrentText
            // 
            this.lbl_CurrentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentText.Location = new System.Drawing.Point(90, 358);
            this.lbl_CurrentText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CurrentText.Name = "lbl_CurrentText";
            this.lbl_CurrentText.Size = new System.Drawing.Size(310, 49);
            this.lbl_CurrentText.TabIndex = 0;
            this.lbl_CurrentText.Text = "Current User:";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddItem.Location = new System.Drawing.Point(334, 535);
            this.btn_AddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(142, 55);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "New";
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
            this.pnl_addItem.Location = new System.Drawing.Point(141, 23);
            this.pnl_addItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_addItem.Name = "pnl_addItem";
            this.pnl_addItem.Size = new System.Drawing.Size(83, 68);
            this.pnl_addItem.TabIndex = 6;
            this.pnl_addItem.Visible = false;
            // 
            // txtSerial
            // 
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(320, 325);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerial.MaxLength = 15;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(342, 35);
            this.txtSerial.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Serial Number:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(320, 252);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.MaxLength = 15;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(342, 35);
            this.txtModel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Model Number:";
            // 
            // btn_ItemSave
            // 
            this.btn_ItemSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ItemSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ItemSave.Location = new System.Drawing.Point(666, 471);
            this.btn_ItemSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ItemSave.Name = "btn_ItemSave";
            this.btn_ItemSave.Size = new System.Drawing.Size(146, 51);
            this.btn_ItemSave.TabIndex = 13;
            this.btn_ItemSave.Text = "Save";
            this.btn_ItemSave.UseVisualStyleBackColor = false;
            this.btn_ItemSave.Click += new System.EventHandler(this.btn_ItemSave_Click);
            // 
            // btn_CancelItem
            // 
            this.btn_CancelItem.BackColor = System.Drawing.Color.Tomato;
            this.btn_CancelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelItem.Location = new System.Drawing.Point(856, 471);
            this.btn_CancelItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_CancelItem.Name = "btn_CancelItem";
            this.btn_CancelItem.Size = new System.Drawing.Size(146, 51);
            this.btn_CancelItem.TabIndex = 14;
            this.btn_CancelItem.Text = "Cancel";
            this.btn_CancelItem.UseVisualStyleBackColor = false;
            this.btn_CancelItem.Click += new System.EventHandler(this.btn_CancelItem_Click);
            // 
            // txt_itemPrice
            // 
            this.txt_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemPrice.Location = new System.Drawing.Point(320, 183);
            this.txt_itemPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemPrice.MaxLength = 15;
            this.txt_itemPrice.Name = "txt_itemPrice";
            this.txt_itemPrice.Size = new System.Drawing.Size(342, 35);
            this.txt_itemPrice.TabIndex = 3;
            // 
            // lbl_itemPrice
            // 
            this.lbl_itemPrice.AutoSize = true;
            this.lbl_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemPrice.Location = new System.Drawing.Point(38, 188);
            this.lbl_itemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemPrice.Name = "lbl_itemPrice";
            this.lbl_itemPrice.Size = new System.Drawing.Size(166, 33);
            this.lbl_itemPrice.TabIndex = 12;
            this.lbl_itemPrice.Text = "Item Price:";
            // 
            // txt_itemDesc
            // 
            this.txt_itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemDesc.Location = new System.Drawing.Point(320, 114);
            this.txt_itemDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemDesc.MaxLength = 75;
            this.txt_itemDesc.Name = "txt_itemDesc";
            this.txt_itemDesc.Size = new System.Drawing.Size(486, 35);
            this.txt_itemDesc.TabIndex = 2;
            // 
            // lbl_itemDesc
            // 
            this.lbl_itemDesc.AutoSize = true;
            this.lbl_itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemDesc.Location = new System.Drawing.Point(38, 118);
            this.lbl_itemDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemDesc.Name = "lbl_itemDesc";
            this.lbl_itemDesc.Size = new System.Drawing.Size(252, 33);
            this.lbl_itemDesc.TabIndex = 11;
            this.lbl_itemDesc.Text = "Item Description:";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemName.Location = new System.Drawing.Point(320, 45);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemName.MaxLength = 25;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(342, 35);
            this.txt_itemName.TabIndex = 1;
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(38, 49);
            this.lbl_itemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(176, 33);
            this.lbl_itemName.TabIndex = 7;
            this.lbl_itemName.Text = "Item Name:";
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
            this.pnl_EditItem.Location = new System.Drawing.Point(18, 18);
            this.pnl_EditItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_EditItem.Name = "pnl_EditItem";
            this.pnl_EditItem.Size = new System.Drawing.Size(81, 63);
            this.pnl_EditItem.TabIndex = 19;
            this.pnl_EditItem.Visible = false;
            // 
            // txtEditSerialNbr
            // 
            this.txtEditSerialNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSerialNbr.Location = new System.Drawing.Point(316, 297);
            this.txtEditSerialNbr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditSerialNbr.MaxLength = 15;
            this.txtEditSerialNbr.Name = "txtEditSerialNbr";
            this.txtEditSerialNbr.Size = new System.Drawing.Size(342, 35);
            this.txtEditSerialNbr.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Serial Number:";
            // 
            // txtEditModelNbr
            // 
            this.txtEditModelNbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditModelNbr.Location = new System.Drawing.Point(316, 225);
            this.txtEditModelNbr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditModelNbr.MaxLength = 15;
            this.txtEditModelNbr.Name = "txtEditModelNbr";
            this.txtEditModelNbr.Size = new System.Drawing.Size(342, 35);
            this.txtEditModelNbr.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "Model Number:";
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSave.Location = new System.Drawing.Point(663, 448);
            this.btnEditSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(152, 60);
            this.btnEditSave.TabIndex = 25;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(848, 448);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(152, 60);
            this.btnEditCancel.TabIndex = 26;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // txtEditItemPrice
            // 
            this.txtEditItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemPrice.Location = new System.Drawing.Point(316, 155);
            this.txtEditItemPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditItemPrice.MaxLength = 15;
            this.txtEditItemPrice.Name = "txtEditItemPrice";
            this.txtEditItemPrice.Size = new System.Drawing.Size(342, 35);
            this.txtEditItemPrice.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "Item Price:";
            // 
            // txtEditItemDesc
            // 
            this.txtEditItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemDesc.Location = new System.Drawing.Point(316, 86);
            this.txtEditItemDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditItemDesc.MaxLength = 75;
            this.txtEditItemDesc.Name = "txtEditItemDesc";
            this.txtEditItemDesc.Size = new System.Drawing.Size(486, 35);
            this.txtEditItemDesc.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 33);
            this.label6.TabIndex = 23;
            this.label6.Text = "Item Description:";
            // 
            // txtEditItemName
            // 
            this.txtEditItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditItemName.Location = new System.Drawing.Point(316, 22);
            this.txtEditItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditItemName.MaxLength = 25;
            this.txtEditItemName.Name = "txtEditItemName";
            this.txtEditItemName.Size = new System.Drawing.Size(342, 35);
            this.txtEditItemName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Item Name:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(519, 535);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 55);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(705, 535);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 55);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAll.Location = new System.Drawing.Point(986, 102);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(196, 55);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Delete All Items";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btn_ExportItems
            // 
            this.btn_ExportItems.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ExportItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportItems.ForeColor = System.Drawing.Color.Black;
            this.btn_ExportItems.Location = new System.Drawing.Point(1040, 535);
            this.btn_ExportItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ExportItems.Name = "btn_ExportItems";
            this.btn_ExportItems.Size = new System.Drawing.Size(142, 55);
            this.btn_ExportItems.TabIndex = 3;
            this.btn_ExportItems.Text = "Export";
            this.btn_ExportItems.UseVisualStyleBackColor = false;
            this.btn_ExportItems.Click += new System.EventHandler(this.btn_ExportItems_Click);
            // 
            // form_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnl_addItem);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.pnl_EditItem);
            this.Controls.Add(this.btn_ExportItems);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Home);
            this.Controls.Add(this.lbl_HomeName);
            this.Controls.Add(this.lbl_CurrentText);
            this.Controls.Add(this.lbl_UserName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btn_ExportItems;
    }
}