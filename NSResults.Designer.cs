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
            this.NSdataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NSdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NSdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NSdataGridView1.GridColor = System.Drawing.Color.Black;
            this.NSdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.NSdataGridView1.Name = "NSdataGridView1";
            this.NSdataGridView1.ReadOnly = true;
            this.NSdataGridView1.RowHeadersWidth = 72;
            this.NSdataGridView1.RowTemplate.Height = 37;
            this.NSdataGridView1.Size = new System.Drawing.Size(706, 334);
            this.NSdataGridView1.TabIndex = 0;
            this.NSdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NSdataGridView1_CellContentClick);
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
            ((System.ComponentModel.ISupportInitialize)(this.NSdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlDataRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView NSdataGridView1;
        private BindingSource sqlDataRecordBindingSource;
    }
}