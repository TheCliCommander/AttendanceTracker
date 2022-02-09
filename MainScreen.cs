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

    public partial class MainScreen : Form
    {


        Confirmation c = new Confirmation();

        public MainScreen()
        {
            InitializeComponent();
            PassThru.Events.openChildFormEvent += PassThrough_openChildFormEvent;


        }

        private void PassThrough_openChildFormEvent(object? sender, Form e)
        {
            openChildForm(e);
        }

        private void cusomizeDesign()
        {
            panelSearchSubMenu.Visible = false;
            //...
        }

        private void hideSubMenu()
        {
            if (panelSearchSubMenu.Visible)
                panelSearchSubMenu.Hide();
        }
        private void hideSubMenu2()
        {
            if (panel2.Visible)
                panel2.Hide();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormMS.Controls.Add(childForm);
            panelChildFormMS.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnNewEntryMS_Click(object sender, EventArgs e)
        {
            openChildForm(new RecordAttendance());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchByMS_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSearchSubMenu);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            hideSubMenu2();
        }

        private void btnDateMS_Click(object sender, EventArgs e)
        {
            openChildForm(new DateSearch());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            openChildForm(new Confirmation());
        }

        private void btnNameMS_Click(object sender, EventArgs e)
        {
            openChildForm(new NameSearch());
        }

        private void btnStatusMS_Click(object sender, EventArgs e)
        {
            openChildForm(new StatusSearch());
        }

        private void btnResetMS_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                var formName = activeForm.GetType().Name;
                switch (formName)
                {
                    case "NameSearch":
                        openChildForm(Activator.CreateInstance<NameSearch>());
                        break;
                    case "DateSearch":
                        openChildForm(Activator.CreateInstance<DateSearch>());
                        break;
                    case "RecordAttendance":
                        openChildForm(Activator.CreateInstance<RecordAttendance>());
                        break;
                    case "StatusSearch":
                        openChildForm(Activator.CreateInstance<StatusSearch>());
                        break;
                    case "StatusDate":
                        openChildForm(Activator.CreateInstance<StatusDate>());
                        break;
                    case "RemoveEntry":
                        openChildForm(Activator.CreateInstance<RemoveEntryForm>());
                        break;
                    case "SDError":
                        openChildForm(Activator.CreateInstance<StatusDate>());
                        break;
                    case "SSError":
                        openChildForm(Activator.CreateInstance<StatusSearch>());
                        break;
                    case "NSError":
                        openChildForm(Activator.CreateInstance<NameSearch>());
                        break;
                    case "DSError":
                        openChildForm(Activator.CreateInstance<DateSearch>());
                        break;
                    case "Confirmation":
                        openChildForm(Activator.CreateInstance<RecordAttendance>());
                        break;
                    case "REConfirm":
                        openChildForm(Activator.CreateInstance<RemoveEntryForm>());
                        break;
                }
            }
        }
      

        

        private void btnMSDisplayAll_Click(object sender, EventArgs e)
        {
            openChildForm(new DisplayAll());
        }


        private void btnStatusDate_Click_1(object sender, EventArgs e)
        {
            openChildForm(new StatusDate());      
        }

        private void btnRemMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btnRemoveID_Click(object sender, EventArgs e)
        {
            
            openChildForm(new RemoveID());
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            openChildForm(new RemoveLast());
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            DataTable dt1 = new DataTable();
            string select1 = "DELETE FROM Employees WHERE 1=1;";
            using (SqlDataAdapter da1 = new SqlDataAdapter(select1, conn1))
            {
                da1.Fill(dt1);
            }
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dt1;
            openChildForm(new RemoveAllConfirm());
        }
        
        private void btnRemoveLast_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-OK1MJMB;Initial Catalog=Roster;Integrated Security=True");
            DataTable dt1 = new DataTable();
            string select1 = "DELETE FROM Employees WHERE ID = (SELECT max(ID) FROM Employees);";
            using (SqlDataAdapter da1 = new SqlDataAdapter(select1, conn1))
            {
                da1.Fill(dt1);
            }
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dt1;
            openChildForm(new RemoveLast());
            
        }
    }
}
