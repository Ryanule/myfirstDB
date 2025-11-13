namespace myfirstDB
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_InformationManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeacherInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_View_TeacherInfobyDG = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeacherQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_TeacherUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_InformationManagement});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(44, 22);
            this.menu_File.Text = "文件";
            // 
            // menu_File_Exit
            // 
            this.menu_File_Exit.Name = "menu_File_Exit";
            this.menu_File_Exit.Size = new System.Drawing.Size(100, 22);
            this.menu_File_Exit.Text = "退出";
            // 
            // menu_InformationManagement
            // 
            this.menu_InformationManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_TeacherInformation,
            this.用户管理ToolStripMenuItem});
            this.menu_InformationManagement.Name = "menu_InformationManagement";
            this.menu_InformationManagement.Size = new System.Drawing.Size(68, 22);
            this.menu_InformationManagement.Text = "信息管理";
            // 
            // menu_TeacherInformation
            // 
            this.menu_TeacherInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_View_TeacherInfobyDG,
            this.menu_TeacherQuery,
            this.menu_TeacherUpdate});
            this.menu_TeacherInformation.Name = "menu_TeacherInformation";
            this.menu_TeacherInformation.Size = new System.Drawing.Size(180, 22);
            this.menu_TeacherInformation.Text = "教师信息";
            // 
            // menu_View_TeacherInfobyDG
            // 
            this.menu_View_TeacherInfobyDG.Name = "menu_View_TeacherInfobyDG";
            this.menu_View_TeacherInfobyDG.Size = new System.Drawing.Size(180, 22);
            this.menu_View_TeacherInfobyDG.Text = "教师信息浏览";
            this.menu_View_TeacherInfobyDG.Click += new System.EventHandler(this.menu_View_TeacherInfobyDG_Click);
            // 
            // menu_TeacherQuery
            // 
            this.menu_TeacherQuery.Name = "menu_TeacherQuery";
            this.menu_TeacherQuery.Size = new System.Drawing.Size(180, 22);
            this.menu_TeacherQuery.Text = "教师信息查询";
            this.menu_TeacherQuery.Click += new System.EventHandler(this.menu_TeacherQuery_Click);
            // 
            // menu_TeacherUpdate
            // 
            this.menu_TeacherUpdate.Name = "menu_TeacherUpdate";
            this.menu_TeacherUpdate.Size = new System.Drawing.Size(180, 22);
            this.menu_TeacherUpdate.Text = "教师信息更新";
            this.menu_TeacherUpdate.Click += new System.EventHandler(this.menu_TeacherUpdate_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "资环学院教学科研管理信息系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem menu_InformationManagement;
        private System.Windows.Forms.ToolStripMenuItem menu_TeacherInformation;
        private System.Windows.Forms.ToolStripMenuItem menu_View_TeacherInfobyDG;
        private System.Windows.Forms.ToolStripMenuItem menu_TeacherQuery;
        private System.Windows.Forms.ToolStripMenuItem menu_TeacherUpdate;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
    }
}