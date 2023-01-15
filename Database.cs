using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Astect
{
    class Database
    {
        string connectionString;
        SqlConnection sqlConnect;
        public Database()
        {
            connectionString = "Server=tcp:astect.database.windows.net,1433;Initial Catalog=Astect;Persist Security Info=False;User ID=systemAccess;Password=Jaxa8233;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
        }

        public Database(string connect)
        {
            this.connectionString = connect;
        }

        public string getConnectionString()
        {
            return this.connectionString;
        }
        public void addHome(string name, string address, string city, string state, string zip, Int16 userId)
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();
            string query = "insert into Homes (HomeName, HomeAddress, HomeCity, HomeState, HomeZip, UserID) values ('" + name + "','" + address + "','" + city + "','" + state + "','" + zip + "'," + userId.ToString() + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
            sqlCommand.ExecuteNonQuery();
        }
        public void addItem(string item, string description, string price, Int16 homeId)
        {
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();
            string query = "insert into Items (ItemName, ItemDescription, ItemPrice, HomeID) values ('" + item + "','" + description + "','" + price + "'," + homeId.ToString() + ")";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
            sqlCommand.ExecuteNonQuery();
        }
         public string getUserID(string username)
        {
            string getUserID = "";
            SqlDataReader dataReader;
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();
            string query = "select UserID from Users WHERE UserName = '" + username + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    getUserID = getUserID + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return getUserID;
        }

        public void getUserHomeTable(DataGridView dgv)
        {
            int userID = Convert.ToInt32(form_LogIn.globalUserID);
            string query = "SELECT HomeID, HomeName, HomeAddress, HomeCity, HomeState, HomeZip FROM Homes WHERE UserID = '" + userID + "'";
            sqlConnect = new SqlConnection(this.connectionString);
            sqlConnect.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnect);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            DataGridView dataGridView = dgv;
            dataGridView.DataSource = ds.Tables[0];
            dataGridView.Columns["HomeID"].Visible = false;
        }

        public void getHomeItemTable(DataGridView dgv)
        {
            int homeID = Convert.ToInt32(form_Homes.globalHomeID);
            string query = "SELECT ItemName, ItemDescription, ItemPrice FROM Items WHERE HomeID = '" + homeID + "'";
            sqlConnect = new SqlConnection(this.connectionString);
            sqlConnect.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnect);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            DataGridView dataGridView = dgv;
            dataGridView.DataSource = ds.Tables[0];
        }

        public void createNewUser(String username, String password, String email)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Users (UserName, Pword, Email) VALUES ('"+username+"','"+password+"','"+email+"')";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<String> getUserNames()
        {
            List<String> usernamesList = new List<String>();


            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserName FROM Users";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
                    sqlConnect.Open();

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        usernamesList.Add(Convert.ToString(dataReader["UserName"]));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return usernamesList;
        }

        public bool getUserTable(string username, string password)
        {
            bool check = false;

            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();

            try
            {
                string query = "SELECT * FROM Users WHERE username = '" + username + "' AND Pword = '" + password + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnect);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    form_LogIn.globalUserName = username;
                    form_Homes homes = new form_Homes();
                    form_LogIn.globalUserID = getUserID(form_LogIn.globalUserName);
                    homes.Show();
                    check = true;
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
            return check;
        }
    }
}
