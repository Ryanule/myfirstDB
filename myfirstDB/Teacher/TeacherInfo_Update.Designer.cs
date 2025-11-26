namespace myfirstDB.Teacher
{
    partial class TeacherInfo_Update
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cance = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_QuerybyName = new System.Windows.Forms.Button();
            this.txt_TeacherName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DB_TeacherInfo = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TeacherInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cance);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_QuerybyName);
            this.panel1.Controls.Add(this.txt_TeacherName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 49);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cance
            // 
            this.btn_Cance.Location = new System.Drawing.Point(447, 11);
            this.btn_Cance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cance.Name = "btn_Cance";
            this.btn_Cance.Size = new System.Drawing.Size(50, 25);
            this.btn_Cance.TabIndex = 4;
            this.btn_Cance.Text = "取消";
            this.btn_Cance.UseVisualStyleBackColor = true;
            this.btn_Cance.Click += new System.EventHandler(this.btn_Cance_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(333, 11);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 25);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "更新教师信息";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_QuerybyName
            // 
            this.btn_QuerybyName.Location = new System.Drawing.Point(230, 11);
            this.btn_QuerybyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QuerybyName.Name = "btn_QuerybyName";
            this.btn_QuerybyName.Size = new System.Drawing.Size(81, 25);
            this.btn_QuerybyName.TabIndex = 2;
            this.btn_QuerybyName.Text = "按姓名查询";
            this.btn_QuerybyName.UseVisualStyleBackColor = true;
            this.btn_QuerybyName.Click += new System.EventHandler(this.btn_QuerybyName_Click);
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(79, 16);
            this.txt_TeacherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.Size = new System.Drawing.Size(118, 21);
            this.txt_TeacherName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师姓名：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DB_TeacherInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 251);
            this.panel2.TabIndex = 1;
            // 
            // DB_TeacherInfo
            // 
            this.DB_TeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB_TeacherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_TeacherInfo.Location = new System.Drawing.Point(0, 0);
            this.DB_TeacherInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DB_TeacherInfo.Name = "DB_TeacherInfo";
            this.DB_TeacherInfo.RowHeadersWidth = 62;
            this.DB_TeacherInfo.RowTemplate.Height = 30;
            this.DB_TeacherInfo.Size = new System.Drawing.Size(533, 251);
            this.DB_TeacherInfo.TabIndex = 0;
            // 
            // TeacherInfo_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeacherInfo_Update";
            this.Text = "更新教师信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DB_TeacherInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TeacherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Cance;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_QuerybyName;
        private System.Windows.Forms.DataGridView DB_TeacherInfo;
    }
}