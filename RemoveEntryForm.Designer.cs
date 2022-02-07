namespace LearningApp1
{
    partial class RemoveEntryForm
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
            this.lblRemoveInstructions = new System.Windows.Forms.Label();
            this.lblREDate = new System.Windows.Forms.Label();
            this.lblREFullName = new System.Windows.Forms.Label();
            this.dateTimePickerRE = new System.Windows.Forms.DateTimePicker();
            this.textBoxREFullName = new System.Windows.Forms.TextBox();
            this.btnREmove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemoveInstructions
            // 
            this.lblRemoveInstructions.AutoSize = true;
            this.lblRemoveInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRemoveInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblRemoveInstructions.Name = "lblRemoveInstructions";
            this.lblRemoveInstructions.Size = new System.Drawing.Size(703, 30);
            this.lblRemoveInstructions.TabIndex = 0;
            this.lblRemoveInstructions.Text = "Enter Full Name and Date of Attendance for the entry you wish to remove.";
            // 
            // lblREDate
            // 
            this.lblREDate.AutoSize = true;
            this.lblREDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblREDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblREDate.Location = new System.Drawing.Point(81, 93);
            this.lblREDate.Name = "lblREDate";
            this.lblREDate.Size = new System.Drawing.Size(64, 30);
            this.lblREDate.TabIndex = 1;
            this.lblREDate.Text = "Date:";
            // 
            // lblREFullName
            // 
            this.lblREFullName.AutoSize = true;
            this.lblREFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblREFullName.Location = new System.Drawing.Point(81, 161);
            this.lblREFullName.Name = "lblREFullName";
            this.lblREFullName.Size = new System.Drawing.Size(119, 30);
            this.lblREFullName.TabIndex = 1;
            this.lblREFullName.Text = "Full Name:";
            // 
            // dateTimePickerRE
            // 
            this.dateTimePickerRE.CalendarForeColor = System.Drawing.Color.Snow;
            this.dateTimePickerRE.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePickerRE.CalendarTitleBackColor = System.Drawing.Color.Firebrick;
            this.dateTimePickerRE.CalendarTitleForeColor = System.Drawing.Color.Snow;
            this.dateTimePickerRE.Location = new System.Drawing.Point(235, 93);
            this.dateTimePickerRE.Name = "dateTimePickerRE";
            this.dateTimePickerRE.Size = new System.Drawing.Size(350, 35);
            this.dateTimePickerRE.TabIndex = 2;
            // 
            // textBoxREFullName
            // 
            this.textBoxREFullName.Location = new System.Drawing.Point(235, 156);
            this.textBoxREFullName.Name = "textBoxREFullName";
            this.textBoxREFullName.Size = new System.Drawing.Size(350, 35);
            this.textBoxREFullName.TabIndex = 3;
            // 
            // btnREmove
            // 
            this.btnREmove.BackColor = System.Drawing.Color.Firebrick;
            this.btnREmove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnREmove.Location = new System.Drawing.Point(324, 242);
            this.btnREmove.Name = "btnREmove";
            this.btnREmove.Size = new System.Drawing.Size(131, 40);
            this.btnREmove.TabIndex = 4;
            this.btnREmove.Text = "Remove ";
            this.btnREmove.UseVisualStyleBackColor = false;
            this.btnREmove.Click += new System.EventHandler(this.btnREmove_Click);
            // 
            // RemoveEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.btnREmove);
            this.Controls.Add(this.textBoxREFullName);
            this.Controls.Add(this.dateTimePickerRE);
            this.Controls.Add(this.lblREFullName);
            this.Controls.Add(this.lblREDate);
            this.Controls.Add(this.lblRemoveInstructions);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "RemoveEntryForm";
            this.Text = "RemoveEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRemoveInstructions;
        private Label lblREDate;
        private Label lblREFullName;
        private DateTimePicker dateTimePickerRE;
        private TextBox textBoxREFullName;
        private Button btnREmove;
    }
}