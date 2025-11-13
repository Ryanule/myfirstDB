namespace myfirstDB.Teacher
{
    partial class TeacherInfo_Browse
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
            this.DataGridView_Teacher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Teacher
            // 
            this.DataGridView_Teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Teacher.Location = new System.Drawing.Point(0, 0);
            this.DataGridView_Teacher.Name = "DataGridView_Teacher";
            this.DataGridView_Teacher.RowHeadersWidth = 62;
            this.DataGridView_Teacher.RowTemplate.Height = 30;
            this.DataGridView_Teacher.Size = new System.Drawing.Size(800, 450);
            this.DataGridView_Teacher.TabIndex = 0;
            // 
            // TeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridView_Teacher);
            this.Name = "TeacherInfo";
            this.Text = "教师信息浏览";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Teacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Teacher;
    }
}