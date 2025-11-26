namespace myfirstDB.Teacher
{
    partial class TeacherInfo_Query
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TeacherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.com_TeacherProfessor = new System.Windows.Forms.ComboBox();
            this.btn_QuerybyName = new System.Windows.Forms.Button();
            this.btn_QuerybyProfessor = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.DB_TeacherInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DB_TeacherInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入教师姓名";
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(174, 45);
            this.txt_TeacherName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.Size = new System.Drawing.Size(148, 28);
            this.txt_TeacherName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "请选择职称";
            // 
            // com_TeacherProfessor
            // 
            this.com_TeacherProfessor.FormattingEnabled = true;
            this.com_TeacherProfessor.Items.AddRange(new object[] {
            "教授",
            "副教授",
            "讲师",
            "助教",
            "教授级高级工程师",
            "高级工程师",
            "工程师",
            "助理工程师",
            "研究员",
            "副研究院",
            "助理研究员",
            "研究实习员",
            "高级实验师",
            "实验师",
            "助理实验师",
            "实验员"});
            this.com_TeacherProfessor.Location = new System.Drawing.Point(456, 45);
            this.com_TeacherProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.com_TeacherProfessor.Name = "com_TeacherProfessor";
            this.com_TeacherProfessor.Size = new System.Drawing.Size(180, 26);
            this.com_TeacherProfessor.TabIndex = 2;
            // 
            // btn_QuerybyName
            // 
            this.btn_QuerybyName.Location = new System.Drawing.Point(728, 42);
            this.btn_QuerybyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_QuerybyName.Name = "btn_QuerybyName";
            this.btn_QuerybyName.Size = new System.Drawing.Size(112, 34);
            this.btn_QuerybyName.TabIndex = 3;
            this.btn_QuerybyName.Text = "按姓名查询";
            this.btn_QuerybyName.UseVisualStyleBackColor = true;
            this.btn_QuerybyName.Click += new System.EventHandler(this.btn_QuerybyName_Click);
            // 
            // btn_QuerybyProfessor
            // 
            this.btn_QuerybyProfessor.Location = new System.Drawing.Point(892, 42);
            this.btn_QuerybyProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_QuerybyProfessor.Name = "btn_QuerybyProfessor";
            this.btn_QuerybyProfessor.Size = new System.Drawing.Size(112, 34);
            this.btn_QuerybyProfessor.TabIndex = 4;
            this.btn_QuerybyProfessor.Text = "按职称查询";
            this.btn_QuerybyProfessor.UseVisualStyleBackColor = true;
            this.btn_QuerybyProfessor.Click += new System.EventHandler(this.btn_QuerybyProfessor_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1050, 42);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // DB_TeacherInfo
            // 
            this.DB_TeacherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DB_TeacherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_TeacherInfo.Location = new System.Drawing.Point(0, 0);
            this.DB_TeacherInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DB_TeacherInfo.Name = "DB_TeacherInfo";
            this.DB_TeacherInfo.RowHeadersWidth = 62;
            this.DB_TeacherInfo.RowTemplate.Height = 23;
            this.DB_TeacherInfo.Size = new System.Drawing.Size(1200, 572);
            this.DB_TeacherInfo.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_QuerybyProfessor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.txt_TeacherName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_QuerybyName);
            this.panel1.Controls.Add(this.com_TeacherProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 103);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DB_TeacherInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 572);
            this.panel2.TabIndex = 9;
            // 
            // TeacherInfo_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeacherInfo_Query";
            this.Text = "查询教师信息...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DB_TeacherInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TeacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_TeacherProfessor;
        private System.Windows.Forms.Button btn_QuerybyName;
        private System.Windows.Forms.Button btn_QuerybyProfessor;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView DB_TeacherInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}