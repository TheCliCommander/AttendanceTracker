namespace LearningApp1
{
    partial class SDError
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
            this.lblSDErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSDErrorMessage
            // 
            this.lblSDErrorMessage.AutoSize = true;
            this.lblSDErrorMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSDErrorMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSDErrorMessage.Location = new System.Drawing.Point(65, 138);
            this.lblSDErrorMessage.Name = "lblSDErrorMessage";
            this.lblSDErrorMessage.Size = new System.Drawing.Size(564, 38);
            this.lblSDErrorMessage.TabIndex = 0;
            this.lblSDErrorMessage.Text = "No  entries for SDStatus on SDDate exists";
            // 
            // SDError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.lblSDErrorMessage);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "SDError";
            this.Text = "SDError";
            this.Load += new System.EventHandler(this.SDError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSDErrorMessage;
    }
}