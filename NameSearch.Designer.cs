namespace LearningApp1
{
    partial class NameSearch
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
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.btnNSSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(235, 97);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(329, 35);
            this.textBoxFullName.TabIndex = 0;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(102, 97);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(112, 30);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "Full Name:";
            // 
            // btnNSSearch
            // 
            this.btnNSSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnNSSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNSSearch.Location = new System.Drawing.Point(325, 201);
            this.btnNSSearch.Name = "btnNSSearch";
            this.btnNSSearch.Size = new System.Drawing.Size(131, 40);
            this.btnNSSearch.TabIndex = 2;
            this.btnNSSearch.Text = "Search";
            this.btnNSSearch.UseVisualStyleBackColor = true;
            this.btnNSSearch.Click += new System.EventHandler(this.btnNSSearch_Click);
            // 
            // NameSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.btnNSSearch);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.textBoxFullName);
            this.Name = "NameSearch";
            this.Text = "NameSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFullName;
        private Label lblFName;
        private Button btnNSSearch;
    }
}