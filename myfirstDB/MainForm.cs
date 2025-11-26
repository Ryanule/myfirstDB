using myfirstDB.ExcelIO;
using myfirstDB.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//引入SQL的连接
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstDB
{
    public partial class MainForm : Form
    {
        private string myConnString;
        private SqlConnection myConn;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string ConnString)
        {
            InitializeComponent();
            myConnString = ConnString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #region 教师信息显示
        private void menu_View_TeacherInfobyDG_Click(object sender, EventArgs e)
        {
            Teacher.TeacherInfo_Browse myTeaInfoBrowse = new Teacher.TeacherInfo_Browse(myConnString);
            myTeaInfoBrowse.MdiParent = this;
            myTeaInfoBrowse.Show();
        }
        #endregion
        #region 教师信息查询
        private void menu_TeacherQuery_Click(object sender, EventArgs e)
        {
            Teacher.TeacherInfo_Query myTeaInfoQuery = new TeacherInfo_Query(myConnString);
            myTeaInfoQuery.MdiParent = this;
            myTeaInfoQuery.Show();
        }
        #endregion
#region 教师信息更新
        private void menu_TeacherUpdate_Click(object sender, EventArgs e)
        {
            Teacher.TeacherInfo_Update myTeaInfoUpdate = new TeacherInfo_Update(myConnString);
            myTeaInfoUpdate.MdiParent = this;
            myTeaInfoUpdate.Show();
        }
        #endregion

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm f = new UserForm(myConnString);
            f.Show();      // 打开子窗口（非模态）            
        }

        private void 导入ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportExcel importForm = new ImportExcel(this.myConnString); // 连接字符串需提前定义
            importForm.MdiParent = this; // 如果使用 MDI
            importForm.Show();
        }

        private void 导出ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportExcel frm = new ExportExcel(myConnString);
            frm.MdiParent = this;  // 若使用 MDI，可以保留
            frm.Show();
        }
    }
}
