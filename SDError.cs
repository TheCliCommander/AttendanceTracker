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
    public partial class SDError : Form
    {
        public SDError()
        {
            InitializeComponent();
        }
        private void SDError_Load(object sender, EventArgs e)
        {
            lblSDErrorMessage.Text = $"No entries for '{StatusDate.SDStatus}' on '{StatusDate.SDDate}' exist.";
        }
    }
}
