namespace LearningApp1
{
    partial class StatusSearch
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
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.btnStatSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOptions
            // 
            this.lblOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOptions.Location = new System.Drawing.Point(121, 39);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(532, 30);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.Text = "Status Options: On Time, Late, C/O, Absent, Excused.";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(121, 129);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 30);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStatus.Location = new System.Drawing.Point(206, 129);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(418, 35);
            this.textBoxStatus.TabIndex = 2;
            // 
            // btnStatSearch
            // 
            this.btnStatSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStatSearch.BackColor = System.Drawing.Color.Firebrick;
            this.btnStatSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnStatSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStatSearch.Location = new System.Drawing.Point(320, 224);
            this.btnStatSearch.Name = "btnStatSearch";
            this.btnStatSearch.Size = new System.Drawing.Size(131, 40);
            this.btnStatSearch.TabIndex = 3;
            this.btnStatSearch.Text = "Search";
            this.btnStatSearch.UseVisualStyleBackColor = false;
            this.btnStatSearch.Click += new System.EventHandler(this.btnStatSearch_Click);
            // 
            // StatusSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.btnStatSearch);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOptions);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "StatusSearch";
            this.Text = "StatusSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOptions;
        private Label lblStatus;
        private TextBox textBoxStatus;
        private Button btnStatSearch;
    }
}