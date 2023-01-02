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
            pnl_AddHome.Visible = true;
            txt_HomeName.Focus();
        }

        private void btn_CancelHome_Click(object sender, EventArgs e)
        {
            pnl_AddHome.Visible = false;
        }

        private void btn_HomeSave_Click(object sender, EventArgs e)
        {
            db.addHome(txt_HomeName.Text, txt_HomeAddress.Text, txt_HomeCity.Text, txt_HomeState.Text, txt_HomeZIP.Text, Convert.ToInt16(form_LogIn.globalUserID));

            db.getUserHomeTable(dataGridViewHome);

            pnl_AddHome.Visible = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
