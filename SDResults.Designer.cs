namespace LearningApp1
{
    partial class SDResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewSDResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSDResults
            // 
            this.dataGridViewSDResults.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewSDResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSDResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSDResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSDResults.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSDResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSDResults.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSDResults.Name = "dataGridViewSDResults";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSDResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSDResults.RowHeadersWidth = 72;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Snow;
            this.dataGridViewSDResults.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSDResults.RowTemplate.Height = 37;
            this.dataGridViewSDResults.Size = new System.Drawing.Size(706, 334);
            this.dataGridViewSDResults.TabIndex = 0;
            // 
            // SDResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.dataGridViewSDResults);
            this.Name = "SDResults";
            this.Text = "SDResults";
            this.Load += new System.EventHandler(this.SDResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewSDResults;
    }
}