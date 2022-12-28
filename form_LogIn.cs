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

            sqlConnect = new SqlConnection(db.getConnectionString());
            sqlConnect.Open();
            try
            {
                string query = "SELECT * FROM Users WHERE username = '" + txt_UserName.Text + "' AND Pword = '" + txt_UserPassword.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnect);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    userName = txt_UserName.Text;
                    userPassword = txt_UserPassword.Text;
                    form_LogIn.globalUserName = txt_UserName.Text;
                    form_Homes homes = new form_Homes(form_LogIn.globalUserName);
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
            finally
            {
                sqlConnect.Close();
            }
        }
    }
}
