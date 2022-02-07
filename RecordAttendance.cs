using System.Data.SqlClient;
using System.Data;


namespace LearningApp1
{
    public partial class RecordAttendance : Form
    {
        DBAccess dbAccess = new DBAccess();

        public static string fName;
        public static string Date1;
        public static string Status;
        public static string Time1;
        public RecordAttendance()
        {
            
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fName = txtFullName.Text;
            Date1 = dtPicker.Value.ToString("MMM dd, yyyy");
            Status = txtStatus.Text;
            Time1 = DateTime.Now.ToString("f");

            if (fName.Equals(""))
            {
                MessageBox.Show("Please enter your full name.");
            }
            else if (Status.Equals(""))
            {
                MessageBox.Show("Please enter a valid status: On Time, Late, C/O, Absent");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into Employees(DateOfAttendance,FullName,Status,CurrentTime) values(@Date1, @fName, @Status, @Time1)");

                insertCommand.Parameters.AddWithValue("@Date1", Date1);
                insertCommand.Parameters.AddWithValue("@fName", fName);
                insertCommand.Parameters.AddWithValue("@Status", Status);
                insertCommand.Parameters.AddWithValue("@Time1", Time1);

                int row = dbAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    PassThru.Events.openChildForm(new Confirmation());
                    MessageBox.Show(fName + "'s Attendance Successfully Recorded!");

                }

                this.Hide();
                
            }
        }

    }
}