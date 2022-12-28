using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astect
{
    class Database
    {
        string connectionString;
        SqlConnection sqlConnect;
        public Database()
        {
            connectionString = "Server=tcp:astect.database.windows.net,1433;Initial Catalog=Astect;Persist Security Info=False;User ID=thanhAstect;Password=Huya6044;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
        }

        public Database(string connect)
        {
            this.connectionString = connect;
        }

        public string getConnectionString()
        {
            return this.connectionString;
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
    }
}
