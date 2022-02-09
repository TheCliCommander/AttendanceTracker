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
    public partial class StatusDate : Form
    {
        public StatusDate()
        {
            InitializeComponent();
        }
        public static string SDDate;
        public static string SDStatus;
        SDResults results = new SDResults();
        private void btnSearchSD_Click(object sender, EventArgs e)
        {
            SDDate = dateTimePickerStatusDate.Value.ToString("MMM dd, yyyy");
            SDStatus = textBoxStatusDate.Text;
            DataTable dt = new DataTable();
            string verify = $"SELECT * FROM Employees WHERE DateOfAttendance = '{SDDate}'AND Status = '{SDStatus}'";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(verify, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;

            if (dt.Rows.Count ==0)
            {

                PassThru.Events.openChildForm(new SDError());


            }
            else
            {


                PassThru.Events.openChildForm(results);
            }
           
          
        }
    }
}
