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
    public partial class StatusSearch : Form
    {
        public StatusSearch()
        {
            InitializeComponent();
        }
        public static string Status;
        StatusResults results = new StatusResults();
        SSError SSError = new SSError();
        private void btnStatSearch_Click(object sender, EventArgs e)
        {
            Status = textBoxStatus.Text;
            DataTable dt = new DataTable();
            string select = $"SELECT * FROM Employees WHERE Status = '{Status}';";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(select, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                PassThru.Events.openChildForm(SSError);
            }
            else
            {
                PassThru.Events.openChildForm(results);
            }
        }
    }
}
