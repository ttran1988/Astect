using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astect
{
    public partial class form_Items : Form
    {
        public form_Items()
        {
            InitializeComponent();
        }

        Database db = new Database();

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
 
            pnl_addItem.Location = new Point(16, 96);
            pnl_addItem.Size = new Size(776, 384);
            pnl_addItem.Visible = true;
            txt_itemName.Focus();
        }

        private void btn_CancelItem_Click(object sender, EventArgs e)
        {
            pnl_addItem.Visible = false;
        }

        private void btn_ItemSave_Click(object sender, EventArgs e)
        {
            db.addItem(txt_itemName.Text, txt_itemDesc.Text, txt_itemPrice.Text, Convert.ToInt16(form_Homes.globalHomeID));
            db.getHomeItemTable(dataGridViewItems);
            pnl_addItem.Visible = false;
        }
    }
}
