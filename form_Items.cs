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
    public partial class form_Items : Form
    {
        public form_Items()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void form_Items_Load(object sender, EventArgs e)
        {
            db.getHomeItemTable(dataGridViewItems);
            lbl_UserName.Text = form_LogIn.globalUserName;
            lbl_HomeName.Text = form_Homes.globalHomeName;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            form_Homes formHomes = new form_Homes();
            formHomes.Show();
            this.Hide();
        }
    }
}
