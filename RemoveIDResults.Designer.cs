namespace LearningApp1
{
    partial class RemoveIDResults
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
            this.lblRemIDResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRemIDResults
            // 
            this.lblRemIDResults.AutoSize = true;
            this.lblRemIDResults.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRemIDResults.Location = new System.Drawing.Point(113, 132);
            this.lblRemIDResults.Name = "lblRemIDResults";
            this.lblRemIDResults.Size = new System.Drawing.Size(478, 38);
            this.lblRemIDResults.TabIndex = 0;
            this.lblRemIDResults.Text = "Entry ID {ID} successfully removed!";
            // 
            // RemoveIDResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.lblRemIDResults);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "RemoveIDResults";
            this.Text = "RemoveIDResults";
            this.Load += new System.EventHandler(this.RemoveIDResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRemIDResults;
    }
}