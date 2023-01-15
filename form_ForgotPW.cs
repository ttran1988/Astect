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
    }
}
