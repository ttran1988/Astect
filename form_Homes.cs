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
    public partial class form_Homes : Form
    {
        public form_Homes(string username)
        {
            InitializeComponent();
            lbl_HomeUserName.Text = username;
        }

        Database db = new Database();

        private void btn_TestUserID_Click(object sender, EventArgs e)
        {
            string userID = db.getUserID(form_LogIn.globalUserName);
            MessageBox.Show(userID);
        }

        private void btn_HomeBack_Click(object sender, EventArgs e)
        {
            form_LogIn formLogIn = new form_LogIn();
            formLogIn.Show();
            this.Hide();
        }
    }
}
