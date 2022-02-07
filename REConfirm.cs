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
    public partial class REConfirm : Form
    {
        public REConfirm()
        {
            InitializeComponent();
        }

        private void REConfirm_Load(object sender, EventArgs e)
        {
            lblDateREC.Text = RemoveEntryForm.REDate + " " + RemoveEntryForm.REFullName + " Entry Removed.";
        }
    }
}
