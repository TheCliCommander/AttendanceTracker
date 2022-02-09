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
    public partial class DSError : Form
    {
        public DSError()
        {
            InitializeComponent();
        }

        private void DSError_Load(object sender, EventArgs e)
        {
            label1.Text = $"No entries for '{DateSearch.DSDate}' exist.";
        }
    }
}
