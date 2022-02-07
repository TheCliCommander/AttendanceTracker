﻿using System;
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
    }
}