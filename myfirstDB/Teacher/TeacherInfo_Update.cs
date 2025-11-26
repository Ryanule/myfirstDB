using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace myfirstDB.Teacher
{
    public partial class TeacherInfo_Update : Form
    {
#region 自定义全局变量
        private string myConnString;
        private SqlConnection myConn;

        private DataSet mySet;
        private DataTable myTable;
        private SqlDataAdapter myDA;
        #endregion
#region 构造函数
        /// <summary>
        /// 无参构造
        /// </summary>
        public TeacherInfo_Update()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 重载构造函数，传入数据库连接字符串
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        public TeacherInfo_Update(string connString)
        {
            InitializeComponent();
            myConnString = connString;
        }
        #endregion

        private void btn_QuerybyName_Click(object sender, EventArgs e)
        {
            string TeaName = txt_TeacherName.Text.Trim();
            if (TeaName.Length == 0)
            {
                MessageBox.Show("请输入查询姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DB_TeacherInfo.DataSource = null;
                return;
            }
            string strSql = "SELECT * FROM 教师信息 WHERE 姓名 LIKE '%" + TeaName + "%'";
            try
            {
                myConn = new SqlConnection(myConnString);
                myConn.Open();
                //SqlDataAdapter myDA = new SqlDataAdapter(strSql, myConn);
                //DataSet mySet = new DataSet();
                myDA = new SqlDataAdapter(strSql, myConn);
                mySet = new DataSet();
                myDA.Fill(mySet);
                //DataTable myTable = mySet.Tables[0];
                myTable = mySet.Tables[0];
                if (myTable.Rows.Count == 0)
                {
                    MessageBox.Show("没有查询到相关信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DB_TeacherInfo.DataSource = null;
                    myConn.Close();
                    return;
                }
                DB_TeacherInfo.DataSource = myTable;
                myConn.Close();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                myConn.Close();
                return;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(mySet == null)
            {
                MessageBox.Show("请先查询教师信息，然后再点击更新按钮！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(mySet.HasChanges())
            {
                try
                {
                    SqlCommandBuilder myBuilder = new SqlCommandBuilder(myDA);
                    myDA.Update(mySet.Tables[0]);
                    myTable.AcceptChanges();
                    MessageBox.Show("信息更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("没有更新的数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btn_Cance_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
