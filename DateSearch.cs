using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningApp1
{
    public partial class DateSearch : Form
    {
        DBAccess dbAccess = new DBAccess();
        Results results = new Results();
        
        
        public static string DSDate;
        public DateSearch()
        {
            InitializeComponent();
        }

       

        public void btnDSSearch_Click(object sender, EventArgs e)
        {
            DSDate = DSdtPicker.Value.ToString("MMM dd yyyy");
            DataTable Employees = new DataTable();
            PassThru.Events.openChildForm(new Results()); 
            

        }




        }
    }
