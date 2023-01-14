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
    public partial class form_Registration : Form
    {
        public form_Registration()
        {
            InitializeComponent();
        }

        Database db = new Database();
        private void btn_RegistrationBack_Click(object sender, EventArgs e)
        {
            form_LogIn formLogIn = new form_LogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            List<String> usernameList = new List<String>();
            usernameList = db.getUserNames();
            Boolean isUserNameTaken = true;

            if (txt_UserName.Text != "" && txt_UserPassword.Text != "")
            {
                foreach (String per in usernameList)
                {
                    if (txt_UserName.Text == per)
                    {
                        isUserNameTaken = true;
                    }
                    else
                    {
                        isUserNameTaken = false;
                    }
                }
                if (isUserNameTaken == false)
                {
                    string email = txtEmail.Text;
                    Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                    if (regex.IsMatch(email))
                    {
                        db.createNewUser(txt_UserName.Text, txt_UserPassword.Text, email);
                        MessageBox.Show("Account created, please log in");
                        form_LogIn formLogIn = new form_LogIn();
                        formLogIn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        txtEmail.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Username is taken");
                }
            }
            else
            {
                MessageBox.Show("Please enter a user name and password");
            }
        }
    }
}
