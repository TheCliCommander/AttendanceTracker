namespace LearningApp1
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelSideMenuMS = new System.Windows.Forms.Panel();
            this.panelSearchSubMenu = new System.Windows.Forms.Panel();
            this.btnStatusMS = new System.Windows.Forms.Button();
            this.btnNameMS = new System.Windows.Forms.Button();
            this.btnDateMS = new System.Windows.Forms.Button();
            this.btnSearchByMS = new System.Windows.Forms.Button();
            this.btnNewEntryMS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCrudBox = new System.Windows.Forms.Panel();
            this.btnPrintMS = new System.Windows.Forms.Button();
            this.btnCloseMS = new System.Windows.Forms.Button();
            this.btnResetMS = new System.Windows.Forms.Button();
            this.panelChildFormMS = new System.Windows.Forms.Panel();
            this.panelSideMenuMS.SuspendLayout();
            this.panelSearchSubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCrudBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenuMS
            // 
            this.panelSideMenuMS.AutoScroll = true;
            this.panelSideMenuMS.BackColor = System.Drawing.Color.Black;
            this.panelSideMenuMS.Controls.Add(this.panelSearchSubMenu);
            this.panelSideMenuMS.Controls.Add(this.btnSearchByMS);
            this.panelSideMenuMS.Controls.Add(this.btnNewEntryMS);
            this.panelSideMenuMS.Controls.Add(this.panel1);
            this.panelSideMenuMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenuMS.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenuMS.Name = "panelSideMenuMS";
            this.panelSideMenuMS.Size = new System.Drawing.Size(194, 496);
            this.panelSideMenuMS.TabIndex = 0;
            // 
            // panelSearchSubMenu
            // 
            this.panelSearchSubMenu.BackColor = System.Drawing.Color.Firebrick;
            this.panelSearchSubMenu.Controls.Add(this.btnStatusMS);
            this.panelSearchSubMenu.Controls.Add(this.btnNameMS);
            this.panelSearchSubMenu.Controls.Add(this.btnDateMS);
            this.panelSearchSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchSubMenu.Location = new System.Drawing.Point(0, 170);
            this.panelSearchSubMenu.Name = "panelSearchSubMenu";
            this.panelSearchSubMenu.Size = new System.Drawing.Size(194, 139);
            this.panelSearchSubMenu.TabIndex = 6;
            // 
            // btnStatusMS
            // 
            this.btnStatusMS.BackColor = System.Drawing.Color.Firebrick;
            this.btnStatusMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatusMS.FlatAppearance.BorderSize = 0;
            this.btnStatusMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnStatusMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatusMS.ForeColor = System.Drawing.Color.Snow;
            this.btnStatusMS.Location = new System.Drawing.Point(0, 80);
            this.btnStatusMS.Name = "btnStatusMS";
            this.btnStatusMS.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStatusMS.Size = new System.Drawing.Size(194, 40);
            this.btnStatusMS.TabIndex = 2;
            this.btnStatusMS.Text = "Status";
            this.btnStatusMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatusMS.UseVisualStyleBackColor = false;
            this.btnStatusMS.Click += new System.EventHandler(this.btnStatusMS_Click);
            // 
            // btnNameMS
            // 
            this.btnNameMS.BackColor = System.Drawing.Color.Firebrick;
            this.btnNameMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNameMS.FlatAppearance.BorderSize = 0;
            this.btnNameMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnNameMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNameMS.ForeColor = System.Drawing.Color.Snow;
            this.btnNameMS.Location = new System.Drawing.Point(0, 40);
            this.btnNameMS.Name = "btnNameMS";
            this.btnNameMS.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNameMS.Size = new System.Drawing.Size(194, 40);
            this.btnNameMS.TabIndex = 1;
            this.btnNameMS.Text = "Name";
            this.btnNameMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameMS.UseVisualStyleBackColor = false;
            this.btnNameMS.Click += new System.EventHandler(this.btnNameMS_Click);
            // 
            // btnDateMS
            // 
            this.btnDateMS.BackColor = System.Drawing.Color.Firebrick;
            this.btnDateMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDateMS.FlatAppearance.BorderSize = 0;
            this.btnDateMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnDateMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDateMS.ForeColor = System.Drawing.Color.Snow;
            this.btnDateMS.Location = new System.Drawing.Point(0, 0);
            this.btnDateMS.Name = "btnDateMS";
            this.btnDateMS.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDateMS.Size = new System.Drawing.Size(194, 40);
            this.btnDateMS.TabIndex = 0;
            this.btnDateMS.Text = "Date";
            this.btnDateMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateMS.UseVisualStyleBackColor = false;
            this.btnDateMS.Click += new System.EventHandler(this.btnDateMS_Click);
            // 
            // btnSearchByMS
            // 
            this.btnSearchByMS.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearchByMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchByMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSearchByMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchByMS.ForeColor = System.Drawing.Color.Snow;
            this.btnSearchByMS.Location = new System.Drawing.Point(0, 130);
            this.btnSearchByMS.Name = "btnSearchByMS";
            this.btnSearchByMS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearchByMS.Size = new System.Drawing.Size(194, 40);
            this.btnSearchByMS.TabIndex = 4;
            this.btnSearchByMS.Text = "Search By:";
            this.btnSearchByMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchByMS.UseVisualStyleBackColor = false;
            this.btnSearchByMS.Click += new System.EventHandler(this.btnSearchByMS_Click);
            // 
            // btnNewEntryMS
            // 
            this.btnNewEntryMS.BackColor = System.Drawing.Color.Firebrick;
            this.btnNewEntryMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEntryMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnNewEntryMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntryMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewEntryMS.ForeColor = System.Drawing.Color.Snow;
            this.btnNewEntryMS.Location = new System.Drawing.Point(0, 90);
            this.btnNewEntryMS.Name = "btnNewEntryMS";
            this.btnNewEntryMS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNewEntryMS.Size = new System.Drawing.Size(194, 40);
            this.btnNewEntryMS.TabIndex = 5;
            this.btnNewEntryMS.Text = "New Entry";
            this.btnNewEntryMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEntryMS.UseVisualStyleBackColor = false;
            this.btnNewEntryMS.Click += new System.EventHandler(this.btnNewEntryMS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 90);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCrudBox
            // 
            this.panelCrudBox.BackColor = System.Drawing.Color.Black;
            this.panelCrudBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCrudBox.Controls.Add(this.btnPrintMS);
            this.panelCrudBox.Controls.Add(this.btnCloseMS);
            this.panelCrudBox.Controls.Add(this.btnResetMS);
            this.panelCrudBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCrudBox.Location = new System.Drawing.Point(194, 398);
            this.panelCrudBox.Name = "panelCrudBox";
            this.panelCrudBox.Size = new System.Drawing.Size(730, 98);
            this.panelCrudBox.TabIndex = 1;
            // 
            // btnPrintMS
            // 
            this.btnPrintMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintMS.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnPrintMS.FlatAppearance.BorderSize = 2;
            this.btnPrintMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnPrintMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintMS.ForeColor = System.Drawing.Color.Snow;
            this.btnPrintMS.Location = new System.Drawing.Point(13, 31);
            this.btnPrintMS.Name = "btnPrintMS";
            this.btnPrintMS.Size = new System.Drawing.Size(131, 40);
            this.btnPrintMS.TabIndex = 1;
            this.btnPrintMS.Text = "Print";
            this.btnPrintMS.UseVisualStyleBackColor = true;
            // 
            // btnCloseMS
            // 
            this.btnCloseMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMS.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnCloseMS.FlatAppearance.BorderSize = 2;
            this.btnCloseMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCloseMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseMS.ForeColor = System.Drawing.Color.Snow;
            this.btnCloseMS.Location = new System.Drawing.Point(576, 31);
            this.btnCloseMS.Name = "btnCloseMS";
            this.btnCloseMS.Size = new System.Drawing.Size(131, 40);
            this.btnCloseMS.TabIndex = 0;
            this.btnCloseMS.Text = "Close";
            this.btnCloseMS.UseVisualStyleBackColor = true;
            this.btnCloseMS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetMS
            // 
            this.btnResetMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetMS.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnResetMS.FlatAppearance.BorderSize = 2;
            this.btnResetMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnResetMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetMS.ForeColor = System.Drawing.Color.Snow;
            this.btnResetMS.Location = new System.Drawing.Point(294, 31);
            this.btnResetMS.Name = "btnResetMS";
            this.btnResetMS.Size = new System.Drawing.Size(131, 40);
            this.btnResetMS.TabIndex = 0;
            this.btnResetMS.Text = "Reset";
            this.btnResetMS.UseVisualStyleBackColor = true;
            this.btnResetMS.Click += new System.EventHandler(this.btnResetMS_Click);
            // 
            // panelChildFormMS
            // 
            this.panelChildFormMS.BackColor = System.Drawing.Color.Snow;
            this.panelChildFormMS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChildFormMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormMS.ForeColor = System.Drawing.Color.MistyRose;
            this.panelChildFormMS.Location = new System.Drawing.Point(194, 0);
            this.panelChildFormMS.Name = "panelChildFormMS";
            this.panelChildFormMS.Size = new System.Drawing.Size(730, 398);
            this.panelChildFormMS.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(924, 496);
            this.Controls.Add(this.panelChildFormMS);
            this.Controls.Add(this.panelCrudBox);
            this.Controls.Add(this.panelSideMenuMS);
            this.ForeColor = System.Drawing.Color.Coral;
            this.MinimumSize = new System.Drawing.Size(948, 560);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panelSideMenuMS.ResumeLayout(false);
            this.panelSearchSubMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCrudBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenuMS;
        private Button btnNewEntryMS;
        private Button btnSearchByMS;
        private Panel panel1;
        private Button btnStatusMS;
        private Button btnNameMS;
        private Button btnDateMS;
        private Panel panelCrudBox;
        private Button btnPrintMS;
        private Button btnCloseMS;
        private Button btnResetMS;
        private Panel panelChildFormMS;
        private Panel panelSearchSubMenu;
        private PictureBox pictureBox1;
    }
}