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
                }
            }
        }
      

        private void btnRemoveEntry_Click_1(object sender, EventArgs e)
        {
            openChildForm(new RemoveEntryForm());
        }

        private void btnMSDisplayAll_Click(object sender, EventArgs e)
        {
            openChildForm(new DisplayAll());
        }
    }
}
