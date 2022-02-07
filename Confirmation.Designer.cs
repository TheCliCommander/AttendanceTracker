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
   
    public partial class Confirmation : Form
    {

        private Label lblDate;
        private Label lblFullName;
        private Label lblStatus;
        private Label lblTime;
        private Button btnCloseCon;
        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCloseCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(44, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.Location = new System.Drawing.Point(44, 80);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(107, 30);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "FullName";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(44, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 30);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(44, 186);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 30);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // btnCloseCon
            // 
            this.btnCloseCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseCon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseCon.ForeColor = System.Drawing.Color.Black;
            this.btnCloseCon.Location = new System.Drawing.Point(563, 282);
            this.btnCloseCon.Name = "btnCloseCon";
            this.btnCloseCon.Size = new System.Drawing.Size(131, 40);
            this.btnCloseCon.TabIndex = 4;
            this.btnCloseCon.Text = "Close";
            this.btnCloseCon.UseVisualStyleBackColor = true;
            this.btnCloseCon.Click += new System.EventHandler(this.btnCloseCon_Click);
            // 
            // Confirmation
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.btnCloseCon);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblDate);
            this.Name = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
