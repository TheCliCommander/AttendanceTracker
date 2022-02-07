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
    public partial class RemoveEntryForm : Form
    {
        public RemoveEntryForm()
        {
            InitializeComponent();
        }
        public static string REDate;
        public static string REFullName;
        private void btnREmove_Click(object sender, EventArgs e)
        {
            REDate = dateTimePickerRE.Value.ToString("MMM dd, yyyy");
            REFullName = textBoxREFullName.Text;
            DataTable dt = new DataTable();
            string verify = $"SELECT * FROM Employees WHERE DateOfAttendance = '{REDate}' AND FullName = '{REFullName}'";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(verify, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            if (dt.Rows.Count > 0)
            {

                DataTable dt1 = new DataTable();
                string select = $"DELETE FROM Employees WHERE DateOfAttendance = '{REDate}' AND FullName = '{REFullName}';";
                SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
                using (SqlDataAdapter da = new SqlDataAdapter(select, conn1))
                {
                    da.Fill(dt1);
                }
                BindingSource bs1 = new BindingSource();
                bs1.DataSource = dt1;
                PassThru.Events.openChildForm(new REConfirm());
                
            }
            else
            {
                PassThru.Events.openChildForm(new REDeny());
            }
        }
    }
}
