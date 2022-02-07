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
    public partial class NSResults : Form
    {
        public NSResults()
        {
            InitializeComponent();
        }
        public static string FName;
        

        private void NSResults_Load(object sender, EventArgs e)
        {
            FName = NameSearch.FName;
            DataTable dt = new DataTable();
            string select = "SELECT * FROM Employees WHERE FullName = @FName;";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(select, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            NSdataGridView1.DataSource = bs;
        }

        private void NSdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FName = NameSearch.FName;
            DataTable dt = new DataTable();
            string select = "SELECT * FROM Employees WHERE FullName = @FName;";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(select, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            NSdataGridView1.DataSource = bs;
        }
    }
}
