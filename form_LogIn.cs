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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                if (db.checkUserLogin(userName,userPassword) == true ) {
                    form_LogIn.globalUserName = userName;
                    form_Homes homes = new form_Homes();
                    form_LogIn.globalUserID = db.getUserID(form_LogIn.globalUserName);
                    homes.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_UserRegistration_Click(object sender, EventArgs e)
        {
            form_Registration register = new form_Registration();
            register.Visible = true;
            this.Hide();
        }

        private void ll_Forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_ForgotPW forgot = new form_ForgotPW();
            forgot.USER_NAME = txt_UserName.Text;
            forgot.Visible = true;
            this.Hide();
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            form_UpdateEmail updateEmail = new form_UpdateEmail();
            updateEmail.userID = globalUserID;
            updateEmail.userName = globalUserName;
            updateEmail.Visible = true;
            this.Hide();
        }
    }
}
