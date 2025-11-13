using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstDB.Teacher
{
    public partial class TeacherInfo_Query : Form
    {
        public string myConnString;
        private SqlConnection myConn;
        public TeacherInfo_Query()
        {
            InitializeComponent();
        }
        public TeacherInfo_Query(string ConnString)
        {
            InitializeComponent();
            myConnString = ConnString;
        }

        private void btn_QuerybyName_Click(object sender, EventArgs e)
        {
            if (this.txt_TeacherName.Text.Trim().Length != 0)
            {
                try
                {
                    myConn = new SqlConnection(myConnString);
                    string mySql = "select * from 教师信息 where 姓名 like '%" +
                        this.txt_TeacherName.Text.Trim() + "%'";
                    myConn.Open();

                    SqlDataAdapter myDA = new SqlDataAdapter(mySql, myConn);
                    DataSet mySet = new DataSet();
                    myDA.Fill(mySet);
                    DataTable myTable = mySet.Tables[0];

                    if (myTable.Rows.Count == 0)
                    {
                        MessageBox.Show("要查询的教师信息不存在，请确保输入的姓名是否正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DB_TeacherInfo.DataSource = null;
                        myConn.Close();
                        return;
                    }
                    this.DB_TeacherInfo.DataSource = myTable;
                    myConn.Close();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myConn.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入要查询的教师姓名");
                return;
            }
        }

        private void btn_QuerybyProfessor_Click(object sender, EventArgs e)
        {
            if (this.com_TeacherProfessor.Text.Trim().Length != 0)
            {
                try
                {
                    myConn = new SqlConnection(myConnString);
                    string mySql = "select * from 教师信息 where 职称 = '" +
                        this.com_TeacherProfessor.SelectedItem.ToString() + "'";
                    myConn.Open();

                    SqlDataAdapter myDA = new SqlDataAdapter(mySql, myConn);
                    DataSet mySet = new DataSet();
                    myDA.Fill(mySet);
                    DataTable myTable = mySet.Tables[0];

                    if (myTable.Rows.Count == 0)
                    {
                        MessageBox.Show("目前暂无教师位于该职称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DB_TeacherInfo.DataSource = null;
                        myConn.Close();
                        return;
                    }
                    this.DB_TeacherInfo.DataSource = myTable;
                    myConn.Close();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    myConn.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入要查询的教师职称");
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
