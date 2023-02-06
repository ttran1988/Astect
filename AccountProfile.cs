using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astect
{
    public partial class form_AccountProfile : Form
    {
        public form_AccountProfile()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void form_AccountProfile_Load(object sender, EventArgs e)
        {
            lbl_UserNameText.Text = form_LogIn.globalUserName;
            lbl_EmailText.Text = db.getUserEmail(form_LogIn.globalUserName);
            List<String> userInfo = db.getUserInfo(form_LogIn.globalUserName);
            txtbox_FName.Text = userInfo[0].Trim();
            txtbox_LName.Text = userInfo[1].Trim();    
            maskedTextBox_Phone.Text = userInfo[2].Trim(); 
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            form_Homes formHomes = new form_Homes();
            formHomes.Show();
            this.Hide();
        }

        private void btn_EditEmailPnlCancel_Click(object sender, EventArgs e)
        {
           pnl_APChangeEmail.Visible = false;
        }

        private void btn_EditEmailPnlUpdate_Click(object sender, EventArgs e)
        {
            string email = txt_NewEmail.Text;
            Regex regex = new Regex((@"^[^@]+@[^@]+\.[^@]+$"));


            if (txt_NewEmail.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid email address.");
                txt_NewEmail.Focus();
            }
            else if (regex.IsMatch(email))
            {
                try
                {
                    db.updateEmail(form_LogIn.globalUserName, email);
                    MessageBox.Show("Your email address has been updated.");
                    pnl_APChangeEmail.Visible = false;
                    form_AccountProfile ap = new form_AccountProfile();
                    this.Close();
                    ap.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid information.");
                    txt_NewEmail.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
                txt_NewEmail.Focus();
            }
        }

        private void btn_ChangeEmail_Click(object sender, EventArgs e)
        {
            lbl_CurrentEmailText.Text = db.getUserEmail(form_LogIn.globalUserName);

            pnl_APChangeEmail.Location = new Point(12, 12);
            pnl_APChangeEmail.Size = new Size(780, 422);
            pnl_APChangeEmail.Visible = true;
            pnl_APChangeEmail.BringToFront();
            txt_NewEmail.Focus();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            pnl_APChangePassword.Location = new Point(12, 12);
            pnl_APChangePassword.Size = new Size(780, 422);
            pnl_APChangePassword.Visible = true;
            pnl_APChangePassword.BringToFront();
            txt_CurrentPassword.Focus();
        }

        private void btn_APChangePasswordCancel_Click(object sender, EventArgs e)
        {
            pnl_APChangePassword.Visible = false;
        }

        private void btn_UpdatePassword_Click(object sender, EventArgs e)
        {
            if (txt_CurrentPassword.Text == "")
            {
                MessageBox.Show("Please enter your current password");
            }
            else if (txt_NewPassword.Text == "")
            {
                MessageBox.Show("Please enter your new password");
            }
            else
            {
                try
                {
                    if (db.checkUserLogin(form_LogIn.globalUserName, txt_CurrentPassword.Text) == true)
                    {
                        db.updateUserPassword(form_LogIn.globalUserName, txt_NewPassword.Text);
                        MessageBox.Show("Password has been updated");
                        pnl_APChangePassword.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_SaveInfo_Click(object sender, EventArgs e)
        {
            db.updateUserInfo(txtbox_FName.Text, txtbox_LName.Text, maskedTextBox_Phone.Text, form_LogIn.globalUserName);
        }

        private void pnl_APChangeEmail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_APChangePassword_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
