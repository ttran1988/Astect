using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Astect
{
    public partial class form_Items : Form
    {
        public static int globalCurrentItemRowID;
        public form_Items()
        {
            InitializeComponent();
        }

        Database db = new Database();
        Email eml= new Email();

        private void form_Items_Load(object sender, EventArgs e)
        {
            db.getHomeItemTable(dataGridViewItems);
            lbl_UserName.Text = form_LogIn.globalUserName;
            lbl_HomeName.Text = form_Homes.globalHomeName;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            form_Homes formHomes = new form_Homes();
            formHomes.Show();
            this.Hide();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            txt_itemName.Text = "";
            txt_itemDesc.Text = "";
            txt_itemPrice.Text = "";
            txtModel.Text = "";
            txtSerial.Text = "";

            btnEdit.Visible = false;
            btnEdit.Enabled = false;
            pnl_EditItem.Visible = false;
            pnl_EditItem.Size = new Size(46, 20);
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Visible = false;
            btnDeleteAll.Enabled = false;
 
            pnl_addItem.Location = new Point(12, 12);
            pnl_addItem.Size = new Size(780, 422);
            pnl_addItem.Visible = true;
            pnl_addItem.BringToFront();
            txt_itemName.Focus();
        }

        private void btn_CancelItem_Click(object sender, EventArgs e)
        {
            pnl_addItem.Visible = false;
            pnl_addItem.Size = new Size(46, 20);
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            btnEdit.Visible = true;
            btnEdit.Enabled = true;
            btnDeleteAll.Visible = true;
            btnDeleteAll.Enabled = true;
        }

        private void btn_ItemSave_Click(object sender, EventArgs e)
        {
            db.addItem(txt_itemName.Text, txt_itemDesc.Text, txt_itemPrice.Text, Convert.ToInt16(form_Homes.globalHomeID), txtModel.Text, txtSerial.Text);
            db.getHomeItemTable(dataGridViewItems);
            pnl_addItem.Size = new Size(46, 20);
            pnl_addItem.Visible = false;
            btnEdit.Visible = true;
            btnEdit.Enabled = true;
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Visible = true;
            btnDeleteAll.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectRowIndex = dataGridViewItems.SelectedCells[0].RowIndex;
            DataGridViewRow selectedItemRow = dataGridViewItems.Rows[selectRowIndex];
            globalCurrentItemRowID = Convert.ToInt32(selectedItemRow.Cells["ItemID"].Value);

            if (globalCurrentItemRowID != 0)
            {
                btn_AddItem.Visible = false;
                btn_AddItem.Enabled = false;
                btnDelete.Visible = false;
                btnDelete.Enabled = false;
                btnDeleteAll.Visible = false;
                btnDeleteAll.Enabled = false;

                txtEditItemName.Text = selectedItemRow.Cells["ItemName"].Value.ToString();
                txtEditItemDesc.Text = selectedItemRow.Cells["ItemDescription"].Value.ToString();
                txtEditItemPrice.Text = selectedItemRow.Cells["ItemPrice"].Value.ToString();
                txtEditModelNbr.Text = selectedItemRow.Cells["ItemModel"].Value.ToString();
                txtEditSerialNbr.Text = selectedItemRow.Cells["ItemSerialNumber"].Value.ToString();
                pnl_EditItem.Location = new Point(12, 12);
                pnl_EditItem.Size = new Size(780, 422);
                pnl_EditItem.Visible = true;
                pnl_EditItem.BringToFront();
                txtEditItemName.Focus();
            }
            else
            {
                MessageBox.Show("Please select a valid row");
            }
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            db.updateItem(txtEditItemName.Text, txtEditItemDesc.Text, txtEditItemPrice.Text, txtEditModelNbr.Text, txtEditSerialNbr.Text,
                globalCurrentItemRowID);
            db.getHomeItemTable(dataGridViewItems);
            pnl_EditItem.Size = new Size(46, 20);
            pnl_EditItem.Visible = false;
            btn_AddItem.Visible = true;
            btn_AddItem.Enabled = true;
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Visible = true;
            btnDeleteAll.Enabled = true;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            pnl_EditItem.Visible = false;
            pnl_EditItem.Size = new Size(46, 20);
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            btn_AddItem.Visible = true;
            btn_AddItem.Enabled = true;
            btnDeleteAll.Visible = true;
            btnDeleteAll.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectRowIndex = dataGridViewItems.SelectedCells[0].RowIndex;
            DataGridViewRow selectedItemRow = dataGridViewItems.Rows[selectRowIndex];

            globalCurrentItemRowID = Convert.ToInt32(selectedItemRow.Cells["ItemID"].Value);

            if (globalCurrentItemRowID != 0)
            {
                DialogResult answer = MessageBox.Show($"Are you sure you want to delete this item?\n\n " +
                $"{selectedItemRow.Cells["ItemName"].Value.ToString()}\n\n", $"Delete {selectedItemRow.Cells["ItemName"].Value.ToString()}",
                MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    db.deleteItem(globalCurrentItemRowID);
                    db.getHomeItemTable(dataGridViewItems);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show($"Are you sure you want to delete all items?", "Delete All?", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                db.deleteAllItems();
                db.getHomeItemTable(dataGridViewItems);
            }
        }

        private void btn_ExportItems_Click(object sender, EventArgs e)
        {
            db.exportToCSV(Convert.ToInt32(form_Homes.globalHomeID));
        }

        private void btn_exportEmail_Click(object sender, EventArgs e)
        {
            //2 steps
            //1-create export file (over-ride)
            db.exportToCSV(Convert.ToInt32(form_Homes.globalHomeID),true);
            //2-email that file
            string saveFile = AppContext.BaseDirectory + @"\HomeExport_" + form_Homes.globalHomeID.ToString() + ".csv";
            string results = db.getUserEmail(lbl_UserName.Text);
            eml.sendFileInEmail(saveFile, results);
            //3-delete file
            //if (File.Exists(saveFile))
            //{
            //    File.Delete(saveFile);
            //}
        }
    }
}
