namespace LearningApp1
{
    partial class DateSearch
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
            this.panelDTPicker = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DSdtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnDSSearch = new System.Windows.Forms.Button();
            this.panelDTPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDTPicker
            // 
            this.panelDTPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDTPicker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelDTPicker.Controls.Add(this.label1);
            this.panelDTPicker.Controls.Add(this.DSdtPicker);
            this.panelDTPicker.Location = new System.Drawing.Point(0, 0);
            this.panelDTPicker.Name = "panelDTPicker";
            this.panelDTPicker.Size = new System.Drawing.Size(706, 398);
            this.panelDTPicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date You Wish to Search";
            // 
            // DSdtPicker
            // 
            this.DSdtPicker.Location = new System.Drawing.Point(192, 91);
            this.DSdtPicker.Name = "DSdtPicker";
            this.DSdtPicker.Size = new System.Drawing.Size(350, 35);
            this.DSdtPicker.TabIndex = 0;
            // 
            // btnDSSearch
            // 
            this.btnDSSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDSSearch.ForeColor = System.Drawing.Color.MistyRose;
            this.btnDSSearch.Location = new System.Drawing.Point(300, 228);
            this.btnDSSearch.Name = "btnDSSearch";
            this.btnDSSearch.Size = new System.Drawing.Size(131, 40);
            this.btnDSSearch.TabIndex = 2;
            this.btnDSSearch.Text = "Search";
            this.btnDSSearch.UseVisualStyleBackColor = false;
            this.btnDSSearch.Click += new System.EventHandler(this.btnDSSearch_Click);
            // 
            // DateSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.btnDSSearch);
            this.Controls.Add(this.panelDTPicker);
            this.MaximumSize = new System.Drawing.Size(730, 398);
            this.MinimumSize = new System.Drawing.Size(730, 398);
            this.Name = "DateSearch";
            this.Text = "NewEntry";
            this.panelDTPicker.ResumeLayout(false);
            this.panelDTPicker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDTPicker;
        private Label label1;
        private DateTimePicker DSdtPicker;
        private Button btnDSSearch;
    }
}