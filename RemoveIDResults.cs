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
    public partial class RemoveIDResults : Form
    {
        public RemoveIDResults()
        {
            InitializeComponent();
        }

        public static string IDNumber;
        private void RemoveIDResults_Load(object sender, EventArgs e)
        {
            lblRemIDResults.Text = $"Entry ID '{RemoveID.IDNumber}' successfully removed!;";
        }
    }
}
