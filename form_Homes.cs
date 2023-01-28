using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astect
{
    public partial class form_Homes : Form
    {
        public form_Homes()
        {
            InitializeComponent();
        }

        public static string globalHomeName = "";
        public static string globalHomeID = "";
        public static int globalCurrentHomeRowID;
        Database db = new Database();

        private void btn_HomeBack_Click(object sender, EventArgs e)
        {
            form_LogIn formLogIn = new form_LogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void form_Homes_Load(object sender, EventArgs e)
        {
            db.getUserHomeTable(dataGridViewHome);
            lbl_HomeUserName.Text = form_LogIn.globalUserName;
        }

        private void btn_SelectHome_Click(object sender, EventArgs e)
        {
            int selectRowIndex = dataGridViewHome.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewHome.Rows[selectRowIndex];
            globalHomeID = Convert.ToString(selectedRow.Cells["HomeID"].Value);
            globalHomeName = Convert.ToString(selectedRow.Cells["HomeName"].Value);
            form_Items formItems = new form_Items();
            formItems.Show();
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txt_HomeName.Text = "";
            txt_HomeAddress.Text = "";
            txt_HomeCity.Text = "";
            txt_HomeState.Text = "";
            txt_HomeZIP.Text = "";

            pnl_AddHome.Location = new Point(47, 37);
            pnl_AddHome.Size = new Size(643, 374);
            btn_HomeSave.Visible = true;
            pnl_AddHome.Visible = true;
            txt_HomeName.Focus();
        }

        private void btn_CancelHome_Click(object sender, EventArgs e)
        {
            pnl_AddHome.Visible = false;
        }

        private void btn_HomeSave_Click(object sender, EventArgs e)
        {
            if (txt_HomeName.Text != "")
            {
                db.addHome(txt_HomeName.Text, txt_HomeAddress.Text, txt_HomeCity.Text, txt_HomeState.Text, txt_HomeZIP.Text, Convert.ToInt16(form_LogIn.globalUserID));
                db.getUserHomeTable(dataGridViewHome);
                pnl_AddHome.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter home name");
            }
 
        }

        private void btn_HomeEdit_Click(object sender, EventArgs e)
        {
            int selectRowIndex = dataGridViewHome.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewHome.Rows[selectRowIndex];

            globalCurrentHomeRowID = Convert.ToInt32(selectedRow.Cells["HomeID"].Value);
            txt_HomeName.Text = Convert.ToString(selectedRow.Cells["HomeName"].Value);
            txt_HomeAddress.Text = Convert.ToString(selectedRow.Cells["HomeAddress"].Value);
            txt_HomeCity.Text = Convert.ToString(selectedRow.Cells["HomeCity"].Value);
            txt_HomeState.Text = Convert.ToString(selectedRow.Cells["HomeState"].Value);
            txt_HomeZIP.Text = Convert.ToString(selectedRow.Cells["HomeZip"].Value);

            pnl_AddHome.Location = new Point(47, 37);
            pnl_AddHome.Size = new Size(643, 374);
            btn_HomeUpdate.Visible = true;
            pnl_AddHome.Visible = true;
            txt_HomeName.Focus();
        }

        private void btn_HomeUpdate_Click(object sender, EventArgs e)
        {
            if (txt_HomeName.Text != "")
            {
                db.updateHome(txt_HomeName.Text, txt_HomeAddress.Text, txt_HomeCity.Text, txt_HomeState.Text, txt_HomeZIP.Text, globalCurrentHomeRowID);
                db.getUserHomeTable(dataGridViewHome);
                pnl_AddHome.Visible = false;
            }
            else
            {
                MessageBox.Show("Please enter home name");
            }
        }

        private void btn_HomeDelete_Click(object sender, EventArgs e)
        {
            int selectRowIndex = dataGridViewHome.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewHome.Rows[selectRowIndex];
            globalCurrentHomeRowID = Convert.ToInt32(selectedRow.Cells["HomeID"].Value);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this home?", "Delete Home", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                db.deleteHome(globalCurrentHomeRowID);
                db.getUserHomeTable(dataGridViewHome);
            }
        }
    }
}
