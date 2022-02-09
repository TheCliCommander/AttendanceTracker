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
    public partial class RemoveID : Form
    {
        public RemoveID()
        {
            InitializeComponent();
        }

        public static string IDNumber;
        private void button1_Click(object sender, EventArgs e)
        {

            IDNumber = this.textBoxID.Text;                          
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            DataTable dt = new DataTable();
            string select = $"SELECT * FROM Employees WHERE ID = '{IDNumber}';";
            using (SqlDataAdapter da = new SqlDataAdapter(select, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            if(dt.Rows.Count < 1)
            {
                 PassThru.Events.openChildForm(new RemoveIDError());
                //PassThru.Events.openChildForm(new RemoveIDResults());
            }
            else
            {
                IDNumber = this.textBoxID.Text;
                SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
                DataTable dt1 = new DataTable();
                string select1 = $"DELETE FROM Employees WHERE ID = '{IDNumber}';";
                using (SqlDataAdapter da1 = new SqlDataAdapter(select1, conn1))
                {
                    da1.Fill(dt1);
                }
                BindingSource bs1 = new BindingSource();
                bs1.DataSource = dt1;

                PassThru.Events.openChildForm(new RemoveIDResults());
                //PassThru.Events.openChildForm(new RemoveIDError());
            }
        }
    }
}
