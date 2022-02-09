namespace LearningApp1
{
    partial class RemoveAllConfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Attendance Records Have Been Deleted!";
            // 
            // RemoveAllConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "RemoveAllConfirm";
            this.Text = "RemoveAllConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
    }
}