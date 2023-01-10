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
                    db.createNewUser(txt_UserName.Text, txt_UserPassword.Text);
                    MessageBox.Show("Account created, please log in");
                    form_LogIn formLogIn = new form_LogIn();
                    formLogIn.Show();
                    this.Hide();
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
