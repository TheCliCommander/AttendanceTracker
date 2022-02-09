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
    public partial class SDResults : Form
    {
        public SDResults()
        {
            InitializeComponent();
        }
        public static string SDDate;
        public static string SDStatus;
        private void SDResults_Load(object sender, EventArgs e)
        {


            StatusDate.SDDate = SDDate;
            StatusDate.SDStatus = SDStatus;
            DataTable dt = new DataTable();
            string verify = $"SELECT * FROM Employees WHERE DateOfAttendance = '{SDDate}'AND Status = '{SDStatus}'";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(verify, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            dataGridViewSDResults.DataSource = dt;
        }

    }

}
