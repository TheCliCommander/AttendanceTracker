namespace LearningApp1
{
    partial class RemoveAll
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
            this.lblRemoveAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRemoveAll
            // 
            this.lblRemoveAll.AutoSize = true;
            this.lblRemoveAll.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRemoveAll.Location = new System.Drawing.Point(142, 136);
            this.lblRemoveAll.Name = "lblRemoveAll";
            this.lblRemoveAll.Size = new System.Drawing.Size(421, 38);
            this.lblRemoveAll.TabIndex = 0;
            this.lblRemoveAll.Text = "All entries successfully erased!";
            // 
            // RemoveAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.lblRemoveAll);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "RemoveAll";
            this.Text = "RemoveAll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRemoveAll;
    }
}