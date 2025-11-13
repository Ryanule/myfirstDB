using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//引入SQL的连接
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfirstDB
{
    public partial class Loding : Form
    {
        public string ConnString;
        private  SqlConnection myConn;
        public bool IsLogin;

        public Loding()
        {
            InitializeComponent();
            IsLogin = false;
        }

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #region 取消按钮代码
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //this.Close();//关闭对话框
            Application.Exit();//关闭多个对话框
        }
        #endregion
        #region 测试按钮
        private void btn_Text_Click(object sender, EventArgs e)
        {
            if(this.txt_DBServer.Text.Trim().Length!=0 &&
                this.txt_DBName.Text.Trim().Length!=0 &&
                this.txt_DBUser.Text.Trim().Length!=0 &&
                this.txt_DBUserPassword.Text.Trim().Length!=0)
            {
                ConnString = "Server=" + this.txt_DBServer.Text.Trim() +
                    ";Database=" + this.txt_DBName.Text.Trim() +
                    ";User Id=" + this.txt_DBUser.Text.Trim() +
                    ";Password=" + this.txt_DBUserPassword.Text.Trim();
                    tryConnDB(ConnString);
            }
        }
        private void tryConnDB(string ConnString)
        {
            try
            {
                myConn = new SqlConnection(ConnString);
                string strSQL = "SELECT * FROM 用户信息";
                SqlCommand myComm = new SqlCommand(strSQL, myConn);
                myConn.Open();
                SqlDataReader myReader = myComm.ExecuteReader();
                if(myReader!=null)
                {
                    MessageBox.Show("数据库连接成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myConn.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误/n"+ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion
        #region 窗体加载事件
        private void Loding_Load(object sender, EventArgs e)
        {
            this.txt_DBServer.Text = "CHINAMI-0UB312L\\MSSQLSERVER2022";
            this.txt_DBName.Text = "MyDb";
            this.txt_DBUser.Text = "sa";
            this.txt_DBUserPassword.Text = "123456";

            this.txt_UserName.Text = "admin";
            this.txt_UserPassword.Text = "123456";
        }
        #endregion

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (this.txt_DBServer.Text.Trim().Length != 0 &&
                this.txt_DBName.Text.Trim().Length != 0 &&
                this.txt_DBUser.Text.Trim().Length != 0 &&
                this.txt_DBUserPassword.Text.Trim().Length != 0)
            {
                ConnString = "Server=" + this.txt_DBServer.Text.Trim() +
                    ";Database=" + this.txt_DBName.Text.Trim() +
                    ";User Id=" + this.txt_DBUser.Text.Trim() +
                    ";Password=" + this.txt_DBUserPassword.Text.Trim();
                tryConnDB(ConnString);
            }
            myConn = new SqlConnection(ConnString);
            string strSQL = "SELECT * FROM 用户信息 ";
            myConn.Open();
            SqlDataAdapter myDA = new SqlDataAdapter(strSQL, myConn);
            DataSet mySet = new DataSet();
            myDA.Fill(mySet);
            if (mySet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("用户表为空，请添加用户信息！");
                return;
            }
            DataTable myTable = mySet.Tables[0];
            for (int i = 0; i < myTable.Rows.Count; i++)
            {
                DataRow myRow = myTable.Rows[i];
                if (myRow[1].ToString().Trim() == this.txt_UserName.Text.Trim() && myRow[2].ToString().Trim() == this.txt_UserPassword.Text.Trim())
                {
                    IsLogin = true;
                    myConn.Close();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("用户名或密码非法,请核对后再登录!");
            IsLogin = false;
            return;
        }
    }
}
