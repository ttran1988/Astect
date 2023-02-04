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
    public partial class form_UpdateEmail : Form
    {
        public string userID;
        public string userName;
        Database db = new Database();
        public form_UpdateEmail()
        {
            InitializeComponent();
        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex((@"^[^@]+@[^@]+\.[^@]+$"));
            

            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
            } 
            else if (regex.IsMatch(email))
            {
                try
                {
                    db.updateEmail(txtUserName.Text, email);
                    MessageBox.Show("Your email address has been updated.");
                    form_LogIn formLogIn = new form_LogIn();
                    formLogIn.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid information.");
                    txtUserName.Focus();
                }
                
            } 
            else
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            form_LogIn formLogIn = new form_LogIn();
            formLogIn.Show();
            this.Hide();
        }
    }
}
