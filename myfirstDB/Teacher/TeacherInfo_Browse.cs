using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//引入SQL的连接

namespace myfirstDB.Teacher
{
    public partial class TeacherInfo_Browse : Form
    {
        public string myConnString;
        private SqlConnection myConn;
        public TeacherInfo_Browse()
        {
            InitializeComponent();
        }
        public TeacherInfo_Browse(string ConnString)
        {
            InitializeComponent();
            myConnString = ConnString;
        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            try
            {
                myConn = new SqlConnection(myConnString);
                string mySQL = "SELECT * FROM 教师信息";
                myConn.Open();
                SqlDataAdapter myDA = new SqlDataAdapter(mySQL, myConn);
                DataSet mySet = new DataSet();
                myDA.Fill(mySet);
                DataTable myTable = mySet.Tables[0];
                this.DataGridView_Teacher.DataSource = myTable;
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("教师信息表访问错误！\n"+ ex.Message);
                myConn.Close();
                return; 
            }
        }
    }
}
