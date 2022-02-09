namespace LearningApp1
{
    partial class RemoveID
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
            this.lblRIDInstruct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRIDInstruct
            // 
            this.lblRIDInstruct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRIDInstruct.AutoSize = true;
            this.lblRIDInstruct.ForeColor = System.Drawing.Color.Snow;
            this.lblRIDInstruct.Location = new System.Drawing.Point(122, 34);
            this.lblRIDInstruct.Name = "lblRIDInstruct";
            this.lblRIDInstruct.Size = new System.Drawing.Size(455, 30);
            this.lblRIDInstruct.TabIndex = 0;
            this.lblRIDInstruct.Text = "Obtain ID via Display All or other search option.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(91, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter ID of entry you wish to remove then click Remove.";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(291, 142);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(175, 35);
            this.textBoxID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.Snow;
            this.lblID.Location = new System.Drawing.Point(226, 147);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(41, 30);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(313, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRIDInstruct);
            this.Name = "RemoveID";
            this.Text = "RemoveID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRIDInstruct;
        private Label label1;
        private TextBox textBoxID;
        private Label lblID;
        private Button button1;
    }
}