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
            this.btnDSSearch = new System.Windows.Forms.Button();
            this.DSdtPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDSSearch
            // 
            this.btnDSSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDSSearch.BackColor = System.Drawing.Color.Firebrick;
            this.btnDSSearch.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btnDSSearch.FlatAppearance.BorderSize = 2;
            this.btnDSSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnDSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDSSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDSSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnDSSearch.Location = new System.Drawing.Point(300, 228);
            this.btnDSSearch.Name = "btnDSSearch";
            this.btnDSSearch.Size = new System.Drawing.Size(131, 40);
            this.btnDSSearch.TabIndex = 2;
            this.btnDSSearch.Text = "Search";
            this.btnDSSearch.UseVisualStyleBackColor = false;
            this.btnDSSearch.Click += new System.EventHandler(this.btnDSSearch_Click);
            // 
            // DSdtPicker
            // 
            this.DSdtPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DSdtPicker.Location = new System.Drawing.Point(184, 117);
            this.DSdtPicker.Name = "DSdtPicker";
            this.DSdtPicker.Size = new System.Drawing.Size(350, 35);
            this.DSdtPicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Date Of Atteneance you wish to search.";
            // 
            // DateSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSdtPicker);
            this.Controls.Add(this.btnDSSearch);
            this.ForeColor = System.Drawing.Color.Snow;
            this.MaximumSize = new System.Drawing.Size(730, 398);
            this.MinimumSize = new System.Drawing.Size(730, 398);
            this.Name = "DateSearch";
            this.Text = "Date Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDSSearch;
        private DateTimePicker DSdtPicker;
        private Label label1;
    }
}