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
    public partial class form_ForgotPW : Form
    {
        public string USER_NAME { get; set; }
        Database db = new Database();
        Email email = new Email();
        public form_ForgotPW()
        {
            InitializeComponent();
        }

        private void btn_forgotPW_Click(object sender, EventArgs e)
        {
            //TODO
            //1 - verify the username exists in the database = DONE
            //2 - verify that an email exists for the username = DONE
            //3 - send an email recovery link to the email address
            lbl_Error.Text = "";
            string results = db.getUserEmail(txt_Username.Text);
            //RETURN VALUES
            // '' = invalid username
            // N/A = no email on file
            // {email_addr} = good
            switch (results)
            {
                case "":
                    lbl_Error.Text = "Invalid Username";
                    break;
                case "N/A":
                    lbl_Error.Text = "No email address on file";
                    break;
                default:
                    //results = {email_addr}
                    //TODO - Send the email recovery link
                    email.sendPasswordResetCode(results);
                    USER_NAME = txt_Username.Text;
                    txt_code.Text = "";
                    pnl_codeValidator.Location = new Point(47, 37);
                    pnl_codeValidator.Size = new Size(780, 422);
                    pnl_codeValidator.Visible = true;
                    txt_code.Focus();
                    break;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            form_LogIn formLogIn = new form_LogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void form_ForgotPW_Load(object sender, EventArgs e)
        {
            txt_Username.Text = USER_NAME;
        }

        private void btn_codeBack_Click(object sender, EventArgs e)
        {
            pnl_codeValidator.Visible = false;
        }

        private void btn_codeSubmit_Click(object sender, EventArgs e)
        {
            lbl_codeError.Text = "";

            string results = txt_code.Text;

            switch (results)
            {
                case "":
                    lbl_codeError.Text = "Please enter reset code";
                    break;
                case "N/A":
                    lbl_codeError.Text = "Invalid code";
                    break;
                default:
                    if (email.isPasswordResetCodeValid(txt_code.Text) == true)
                    {
                        pnl_codeValidator.Visible = false;
                        pnl_resetPassword.Location = new Point(47, 37);
                        pnl_resetPassword.Size = new Size(780, 422);
                        pnl_resetPassword.Visible = true;
                    }
                    else
                    {
                        lbl_codeError.Text = "Invalid code";
                    }
                    break;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            form_LogIn formLogIn = new form_LogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void btn_newPasswordSubmit_Click(object sender, EventArgs e)
        {
            lbl_newPasswordError.Text = "";
            
            if (txt_enterPassword.Text == "" || txt_enterPasswordConfirm.Text == "")
            {
                lbl_newPasswordError.Text = "Please enter password in both fields";
            }
            else if (!txt_enterPassword.Text.Equals(txt_enterPasswordConfirm.Text))
            {
                lbl_newPasswordError.Text = "Please make sure password is enter correctly in both field";
            }
            else
            {
                db.updateUserPassword(USER_NAME, txt_enterPassword.Text);
                MessageBox.Show("Your password has been updated, please log in with your new password");
                form_LogIn formLogIn = new form_LogIn();
                formLogIn.Show();
                this.Hide();
            }
        }
    }
}
