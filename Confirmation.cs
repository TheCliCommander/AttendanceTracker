using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningApp1
{


    public partial class Confirmation : Form
    {

        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblDate.Text = RecordAttendance.Date1;
            lblFullName.Text = RecordAttendance.fName;
            lblStatus.Text = RecordAttendance.Status;
            lblTime.Text = RecordAttendance.Time1;
        }

        private void btnCloseCon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
