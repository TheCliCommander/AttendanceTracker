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
    public partial class StatusResults : Form
    {
        public StatusResults()
        {
            InitializeComponent();
        }
        public static string Status;
        private void StatusResults_Load(object sender, EventArgs e)
        {
            Status = StatusSearch.Status;
            DataTable dt = new DataTable();
            string select = $"SELECT * FROM Employees WHERE Status = '{Status}';";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(select, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridViewStatus.DataSource = bs;
        }
    }
}
