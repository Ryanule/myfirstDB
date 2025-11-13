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

        private void menu_View_TeacherInfobyDG_Click(object sender, EventArgs e)
        {
            Teacher.TeacherInfo_Browse myTeaInfoBrowse = new Teacher.TeacherInfo_Browse(myConnString);
            myTeaInfoBrowse.MdiParent = this;
            myTeaInfoBrowse.Show();
        }

        private void menu_TeacherQuery_Click(object sender, EventArgs e)
        {
            Teacher.TeacherInfo_Query myTeaInfoQuery = new TeacherInfo_Query(myConnString);
            myTeaInfoQuery.MdiParent = this;
            myTeaInfoQuery.Show();
        }

        private void menu_TeacherUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
