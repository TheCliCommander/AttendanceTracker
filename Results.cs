using System.Data;
using System.Data.SqlClient;
namespace LearningApp1
{
    public partial class Results : Form
    {
        DBAccess dbAccess = new DBAccess();
        DataTable Employees = new DataTable();
        public static string DSDate;
        public Results()
        {
            InitializeComponent();
        }




        private void Results_Load(object sender, EventArgs e)
        {
            DSDate = DateSearch.DSDate;
            DataTable dt = new DataTable();
            string select = $"SELECT * FROM Employees WHERE DateOfAttendance = '{DSDate}'";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            using (SqlDataAdapter da = new SqlDataAdapter(select, conn))
            {
                da.Fill(dt);
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView2.DataSource = bs;
            
            
            //dbAccess.createConn();
            //SqlCommand comm = new SqlCommand("SELECT FullName FROM Employees WHERE DateOfAttendance = @DSDate");
            //comm.CommandType = CommandType.Text;
            //SqlDataReader rdr = comm.ExecuteReader();
            //dbAccess.closeConn();
        }

        
    }
}
