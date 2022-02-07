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
    public partial class StatusSearch : Form
    {
        public StatusSearch()
        {
            InitializeComponent();
        }
        public static string Status;
        StatusResults results = new StatusResults();
        private void btnStatSearch_Click(object sender, EventArgs e)
        {
            Status = textBoxStatus.Text;
            PassThru.Events.openChildForm(results);
        }
    }
}
