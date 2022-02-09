using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearningApp1
{
    public partial class NameSearch : Form
    {
        public NameSearch()
        {
            InitializeComponent();
        }
        NSResults NSResults = new NSResults();
        public static string FName;
        public static string dt;
        private void btnNSSearch_Click(object sender, EventArgs e)
        {
            FName = textBoxFullName.Text;
            DataTable dt = new DataTable();
            string select = $"SELECT * FROM Employees WHERE FullName = '{FName}';";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(select, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            
            if (dt.Rows.Count == 0 )
            {
                PassThru.Events.openChildForm(new NSError());
            }
            else
            {
                PassThru.Events.openChildForm(NSResults);
            }
            
        }
    }
}
