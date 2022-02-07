namespace LearningApp1
{
    partial class NSResults
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NSdataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlDataRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NSdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NSdataGridView1
            // 
            this.NSdataGridView1.AllowUserToAddRows = false;
            this.NSdataGridView1.AllowUserToDeleteRows = false;
            this.NSdataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NSdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NSdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.NSdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NSdataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.NSdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NSdataGridView1.GridColor = System.Drawing.Color.Snow;
            this.NSdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.NSdataGridView1.Name = "NSdataGridView1";
            this.NSdataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NSdataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.NSdataGridView1.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            this.NSdataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.NSdataGridView1.RowTemplate.Height = 37;
            this.NSdataGridView1.Size = new System.Drawing.Size(706, 334);
            this.NSdataGridView1.TabIndex = 0;
            // 
            // sqlDataRecordBindingSource
            // 
            this.sqlDataRecordBindingSource.DataSource = typeof(Microsoft.SqlServer.Server.SqlDataRecord);
            // 
            // NSResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.NSdataGridView1);
            this.Name = "NSResults";
            this.Text = "NSResults";
            this.Load += new System.EventHandler(this.NSResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NSdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView NSdataGridView1;
        private BindingSource sqlDataRecordBindingSource;
    }
}