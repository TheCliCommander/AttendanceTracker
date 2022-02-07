namespace LearningApp1
{
    partial class DisplayAll
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
            this.dataGridViewDA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDA
            // 
            this.dataGridViewDA.AllowUserToAddRows = false;
            this.dataGridViewDA.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewDA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDA.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDA.GridColor = System.Drawing.Color.Snow;
            this.dataGridViewDA.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDA.Name = "dataGridViewDA";
            this.dataGridViewDA.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDA.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDA.RowHeadersWidth = 72;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Snow;
            this.dataGridViewDA.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDA.RowTemplate.Height = 37;
            this.dataGridViewDA.Size = new System.Drawing.Size(706, 334);
            this.dataGridViewDA.TabIndex = 0;
            // 
            // DisplayAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.dataGridViewDA);
            this.Name = "DisplayAll";
            this.Text = "DisplayAll";
            this.Load += new System.EventHandler(this.DisplayAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewDA;
    }
}