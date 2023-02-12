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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography;
using Microsoft.SqlServer.Server;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

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
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "AddHome";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HomeName", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.AddWithValue("@HomeAddress", SqlDbType.VarChar).Value = address;
                    cmd.Parameters.AddWithValue("@HomeCity", SqlDbType.VarChar).Value = city;
                    cmd.Parameters.AddWithValue("@HomeState", SqlDbType.Char).Value = state;
                    cmd.Parameters.AddWithValue("@HomeZip", SqlDbType.VarChar).Value = zip;
                    cmd.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = userId;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteItem(int itemID)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "DeleteItem";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemID", SqlDbType.Int).Value = itemID;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteAllItems()
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "resetItems";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void updateHome(string name, string address, string city, string state, string zip, int homeId)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "UpdateHome";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HomeName", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.AddWithValue("@HomeAddress", SqlDbType.VarChar).Value = address;
                    cmd.Parameters.AddWithValue("@HomeCity", SqlDbType.VarChar).Value = city;
                    cmd.Parameters.AddWithValue("@HomeState", SqlDbType.Char).Value = state;
                    cmd.Parameters.AddWithValue("@HomeZip", SqlDbType.VarChar).Value = zip;
                    cmd.Parameters.AddWithValue("@HomeID", SqlDbType.Int).Value = homeId;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteHome(int homeId)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                {
                    string query = "Delete FROM Items WHERE HomeID = '"+homeId+"'; Delete FROM Homes WHERE HomeId = '" + homeId + "'";
                    sqlConnect.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlConnect);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void updateEmail(string userName, string email)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "updateEmail";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = email;
                    cmd.Parameters.AddWithValue("@userName", SqlDbType.Int).Value = userName;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void addItem(string item, string description, string price, int homeId, string modelNbr, string serialnbr)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "AddItem";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemName", SqlDbType.VarChar).Value = item;
                    cmd.Parameters.AddWithValue("@ItemDescription", SqlDbType.VarChar).Value = description;
                    cmd.Parameters.AddWithValue("@ItemPrice", SqlDbType.Money).Value = price;
                    cmd.Parameters.AddWithValue("@HomeID", SqlDbType.Int).Value = homeId;
                    cmd.Parameters.AddWithValue("@Model", SqlDbType.VarChar).Value = modelNbr;
                    cmd.Parameters.AddWithValue("@Serial", SqlDbType.VarChar).Value = serialnbr;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
        public void updateItem(string item, string description, string price, string modelNbr, string serialNbr, int itemID)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "UpdateItem";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemName", SqlDbType.VarChar).Value = item;
                    cmd.Parameters.AddWithValue("@ItemDescription", SqlDbType.VarChar).Value = description;
                    cmd.Parameters.AddWithValue("@ItemPrice", SqlDbType.Money).Value = price;
                    cmd.Parameters.AddWithValue("@ItemModel", SqlDbType.VarChar).Value = modelNbr;
                    cmd.Parameters.AddWithValue("@ItemSerial", SqlDbType.VarChar).Value = serialNbr;
                    cmd.Parameters.AddWithValue("@ItemID", SqlDbType.Int).Value = itemID;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateUserInfo(string fname, string lname, string phone, string username)
        {
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "UpdateUserInfo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fname", SqlDbType.VarChar).Value = fname;
                    cmd.Parameters.AddWithValue("@lname", SqlDbType.VarChar).Value = lname;
                    cmd.Parameters.AddWithValue("@phone", SqlDbType.VarChar).Value = phone;
                    cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar).Value = username;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return getUserID;
        }
        public string getUserEmail(string username)
        {
            //RETURN VALUES
            // '' = invalid username
            // N/A = no email on file
            // {email_addr} = good

            string getUserEmail = "";
            SqlDataReader dataReader;
            sqlConnect = new SqlConnection(connectionString);
            sqlConnect.Open();
            string query = "select ISNULL(Email,'N/A') as Email from Users WHERE UserName = '" + username + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    getUserEmail = getUserEmail + dataReader.GetValue(0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return getUserEmail;
        }
        public void getUserHomeTable(DataGridView dgv)
        {
            int userID = Convert.ToInt32(form_LogIn.globalUserID);
            try
            {
                using (sqlConnect = new SqlConnection(this.connectionString))
                using (SqlCommand sCmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    sCmd.CommandText = "getUserHomeTable";
                    sCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sPrm;
                    sPrm = sCmd.Parameters.Add("@userId", SqlDbType.Int);
                    sPrm.Value = userID;
                    sPrm.Direction = ParameterDirection.Input;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = sCmd;

                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    DataGridView dataGridView = dgv;
                    dataGridView.DataSource = dt;
                    dataGridView.Columns["HomeID"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<String> getUserInfo(String username)
        {
            List<String> UserInfoList = new List<String>();

            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                {
                    string query = "SELECT FName, LName, PhoneNum FROM Users WHERE Username = '" + username + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
                    sqlConnect.Open();

                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        UserInfoList.Add(Convert.ToString(dataReader["FName"]));
                        UserInfoList.Add(Convert.ToString(dataReader["LName"]));
                        UserInfoList.Add(Convert.ToString(dataReader["PhoneNum"]));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return UserInfoList;
        }

        public void getHomeItemTable(DataGridView dgv)
        {
            int homeID = Convert.ToInt32(form_Homes.globalHomeID);
            string query = "SELECT ItemID, ItemName, ItemDescription, CAST(ItemPrice as Numeric(17,2)) ItemPrice, ItemModel, ItemSerialNumber FROM Items WHERE HomeID = '" + homeID + "'";
            sqlConnect = new SqlConnection(this.connectionString);
            sqlConnect.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnect);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            DataGridView dataGridView = dgv;
            dataGridView.DataSource = ds.Tables[0];
            dataGridView.Columns["ItemID"].Visible = false;
        }

        public void createNewUser(String username, String password, String email)
        {
            Random random = new Random();
            int salt = random.Next();

            byte[] passSalt = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed sham = new SHA256Managed();
            byte[] hash = sham.ComputeHash(passSalt);

            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand sqlCommand = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    sqlCommand.CommandText = "insertUser";
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    SqlParameter sPrm;
                    sPrm = sqlCommand.Parameters.Add("@userName", SqlDbType.VarChar, 50);
                    sPrm.Value = username;
                    sPrm.Direction = ParameterDirection.Input;

                    SqlParameter sPrm2;
                    sPrm2 = sqlCommand.Parameters.Add("@pword", SqlDbType.VarChar, 50);
                    sPrm2.Value = Convert.ToBase64String(hash);
                    sPrm2.Direction = ParameterDirection.Input;

                    SqlParameter sPrm3;
                    sPrm3 = sqlCommand.Parameters.Add("@email", SqlDbType.VarChar);
                    sPrm3.Value = email;
                    sPrm3.Direction = ParameterDirection.Input;

                    SqlParameter sPrm4;
                    sPrm4 = sqlCommand.Parameters.Add("@salt", SqlDbType.VarChar, 25);
                    sPrm4.Value = salt;
                    sPrm4.Direction = ParameterDirection.Input;

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

        public bool checkUserLogin(string username, string password)
        {
            bool login = false;
            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                sqlConnect.Open();
                cmd.CommandText = "CheckUserLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = username;
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        string passHash = reader.GetString(2);
                        string salt = reader.GetString(4);

                        byte[] passSalt = Encoding.UTF8.GetBytes(password + salt);
                        SHA256Managed sham = new SHA256Managed();
                        byte[] hash = sham.ComputeHash(passSalt);

                        if (Convert.ToBase64String(hash) == passHash)
                        {
                            login = true;
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
        return login;
        }
        public void updateUserPassword(string username, string password)
        {
            Random random = new Random();
            int salt = random.Next();

            byte[] passSalt = Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed sham = new SHA256Managed();
            byte[] hash = sham.ComputeHash(passSalt);

            try
            {
                using (sqlConnect = new SqlConnection(connectionString))
                using (SqlCommand cmd = sqlConnect.CreateCommand())
                {
                    sqlConnect.Open();
                    cmd.CommandText = "UpdateUserPassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Convert.ToBase64String(hash);
                    cmd.Parameters.AddWithValue("@Salt", SqlDbType.VarChar).Value = salt;
                    cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = username;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void exportToCSV(int homeID, bool bOverride = false)
        {
            /*bOverride: is used to allow the system to generate a file name instead of a user selected file name.
             * bFile: is used to indicate whether a file name has been selected and the query can run.
             * 
             * */
            try
            {
                bool bFile = false;
                string saveFile = "";
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Name Your File";
                save.Filter = "CSV Files (*.csv)|*.csv";
                if (bOverride)
                {
                    //generate a system file-name
                    saveFile = AppContext.BaseDirectory + @"\HomeExport_" + homeID.ToString() + ".csv";
                    if(File.Exists(saveFile))
                    {
                        File.Delete(saveFile);
                    }
                    bFile = true;
                }
                else
                {
                    //get the user file-name
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        saveFile = save.FileName;
                        bFile = true;
                    }
                }

                if (bFile)
                {
                    using (sqlConnect = new SqlConnection(connectionString))
                    {
                        string homeQuery = "select * from homes where homeID = '" + homeID + "'";
                        SqlCommand cm = new SqlCommand(homeQuery, sqlConnect);
                        sqlConnect.Open();
                        SqlDataReader homeReader = cm.ExecuteReader();

                        StreamWriter csvFile = new StreamWriter(File.Create(saveFile));

                        while (homeReader.Read())
                        {
                            csvFile.WriteLine(String.Format("{0},{1},{2},{3},{4}",
                                homeReader[1], homeReader[2], homeReader[3], homeReader[4], homeReader[5]));
                        }
                        
                        homeReader.Close();

                        string itemQuery = "select * from items where homeID = '" + homeID + "'";
                        SqlCommand cmd = new SqlCommand(itemQuery, sqlConnect);
                        
                        SqlDataReader itemReader = cmd.ExecuteReader();

                        csvFile.WriteLine("");

                        csvFile.WriteLine(String.Format("{0},{1},{2},{3},{4}",
                                itemReader.GetName(1), itemReader.GetName(2), itemReader.GetName(3),
                                itemReader.GetName(5), itemReader.GetName(6)));

                        csvFile.WriteLine("");

                        while (itemReader.Read())
                        {
                            csvFile.WriteLine(String.Format("{0},{1},{2}," +
                                "{3},{4}",
                                itemReader[1], itemReader[2], itemReader[3],
                                itemReader[5], itemReader[6]));
                        }
                        csvFile.Dispose();
                        MessageBox.Show("Export successful");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
