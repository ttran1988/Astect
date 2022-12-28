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
    public partial class form_LogIn : Form
    {
        public form_LogIn()
        {
            InitializeComponent();
        }

        public static string globalUserName = "";
        public static string globalUserID = "";

        SqlConnection sqlConnect = new SqlConnection();
        Database db = new Database();

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            string userName, userPassword;

            userName = txt_UserName.Text;
            userPassword = txt_UserPassword.Text;

            try
            {
                //db.getUserTable(userName, userPassword);
                if (db.getUserTable(userName,userPassword) == true ) {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
