namespace LearningApp1
{
    partial class REConfirm
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
            this.lblDateREC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDateREC
            // 
            this.lblDateREC.AutoSize = true;
            this.lblDateREC.ForeColor = System.Drawing.Color.Snow;
            this.lblDateREC.Location = new System.Drawing.Point(161, 132);
            this.lblDateREC.Name = "lblDateREC";
            this.lblDateREC.Size = new System.Drawing.Size(381, 30);
            this.lblDateREC.TabIndex = 0;
            this.lblDateREC.Text = "MMM dd, yyyy FullName Entry Deleted.";
            // 
            // REConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.lblDateREC);
            this.Name = "REConfirm";
            this.Text = "REConfirm";
            this.Load += new System.EventHandler(this.REConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDateREC;
    }
}