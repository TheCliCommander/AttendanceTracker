namespace LearningApp1
{
    partial class RemoveLast
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
            this.lblRemoveLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRemoveLast
            // 
            this.lblRemoveLast.AutoSize = true;
            this.lblRemoveLast.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRemoveLast.Location = new System.Drawing.Point(133, 132);
            this.lblRemoveLast.Name = "lblRemoveLast";
            this.lblRemoveLast.Size = new System.Drawing.Size(445, 38);
            this.lblRemoveLast.TabIndex = 0;
            this.lblRemoveLast.Text = "Last Entry Successfuly Removed!";
            // 
            // RemoveLast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.lblRemoveLast);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "RemoveLast";
            this.Text = "RemoveLast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRemoveLast;
    }
}