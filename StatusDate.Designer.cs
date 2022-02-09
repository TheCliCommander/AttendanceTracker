namespace LearningApp1
{
    partial class StatusDate
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblDateInstructions = new System.Windows.Forms.Label();
            this.dateTimePickerStatusDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxStatusDate = new System.Windows.Forms.TextBox();
            this.btnSearchSD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(106, 118);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(106, 190);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 30);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            // 
            // lblOptions
            // 
            this.lblOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptions.Location = new System.Drawing.Point(106, 21);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(532, 30);
            this.lblOptions.TabIndex = 1;
            this.lblOptions.Text = "Status Options: On Time, Late, C/O, Absent, Excused.";
            // 
            // lblDateInstructions
            // 
            this.lblDateInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateInstructions.AutoSize = true;
            this.lblDateInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateInstructions.Location = new System.Drawing.Point(106, 72);
            this.lblDateInstructions.Name = "lblDateInstructions";
            this.lblDateInstructions.Size = new System.Drawing.Size(525, 30);
            this.lblDateInstructions.TabIndex = 2;
            this.lblDateInstructions.Text = "Use the date for which you wish to know the status.";
            // 
            // dateTimePickerStatusDate
            // 
            this.dateTimePickerStatusDate.Location = new System.Drawing.Point(231, 118);
            this.dateTimePickerStatusDate.Name = "dateTimePickerStatusDate";
            this.dateTimePickerStatusDate.Size = new System.Drawing.Size(350, 35);
            this.dateTimePickerStatusDate.TabIndex = 3;
            // 
            // textBoxStatusDate
            // 
            this.textBoxStatusDate.Location = new System.Drawing.Point(231, 190);
            this.textBoxStatusDate.Name = "textBoxStatusDate";
            this.textBoxStatusDate.Size = new System.Drawing.Size(350, 35);
            this.textBoxStatusDate.TabIndex = 4;
            // 
            // btnSearchSD
            // 
            this.btnSearchSD.BackColor = System.Drawing.Color.Firebrick;
            this.btnSearchSD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnSearchSD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchSD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchSD.Location = new System.Drawing.Point(320, 257);
            this.btnSearchSD.Name = "btnSearchSD";
            this.btnSearchSD.Size = new System.Drawing.Size(131, 40);
            this.btnSearchSD.TabIndex = 5;
            this.btnSearchSD.Text = "Search";
            this.btnSearchSD.UseVisualStyleBackColor = false;
            this.btnSearchSD.Click += new System.EventHandler(this.btnSearchSD_Click);
            // 
            // StatusDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.btnSearchSD);
            this.Controls.Add(this.textBoxStatusDate);
            this.Controls.Add(this.dateTimePickerStatusDate);
            this.Controls.Add(this.lblDateInstructions);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDate);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "StatusDate";
            this.Text = "StatusDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDate;
        private Label lblStatus;
        private Label lblOptions;
        private Label lblDateInstructions;
        private DateTimePicker dateTimePickerStatusDate;
        private TextBox textBoxStatusDate;
        private Button btnSearchSD;
    }
}