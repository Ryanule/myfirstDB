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


namespace myfirstDB
{
    public partial class UserForm : Form
    {
        public string myConnString;

        // 数据集与 BindingManager
        private DataSet mySet;
        private BindingManagerBase BM;
        public UserForm()
        {
            InitializeComponent();
            
        }
        public UserForm(string ConnString)
        {
            InitializeComponent();
            
            myConnString = ConnString;
            LoadData();
        }
        // ======================== 数据加载与绑定 =========================

        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(myConnString);
            string sql = "SELECT * FROM 用户信息";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            mySet = new DataSet();
            da.Fill(mySet);

            // 清除旧绑定避免重复
            txt_UserName.DataBindings.Clear();
            txt_UserPWD.DataBindings.Clear();
            txt_UserPower.DataBindings.Clear();
            txt_BZH.DataBindings.Clear();

            // 建立新的数据绑定
            txt_UserName.DataBindings.Add("Text", mySet.Tables[0], "用户名");
            txt_UserPWD.DataBindings.Add("Text", mySet.Tables[0], "密码");
            txt_UserPower.DataBindings.Add("Text", mySet.Tables[0], "权限");
            txt_BZH.DataBindings.Add("Text", mySet.Tables[0], "备注");

            // 创建 BindingManager
            BM = this.BindingContext[mySet.Tables[0]];

            UpdateButtonState();
        }
        // ======================== 公共函数：统一设置按钮状态 =========================

        private void UpdateButtonState()
        {
            btn_First.Enabled = BM.Position > 0;
            btn_Privious.Enabled = BM.Position > 0;

            btn_Last.Enabled = BM.Position < mySet.Tables[0].Rows.Count - 1;
            btn_Next.Enabled = BM.Position < mySet.Tables[0].Rows.Count - 1;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            BM.Position = 0;
            UpdateButtonState();
        }

        private void btn_Privious_Click(object sender, EventArgs e)
        {
            if (BM.Position == 0)
            {
                MessageBox.Show("已经是第一条记录！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BM.Position--;
            UpdateButtonState();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (BM.Position == mySet.Tables[0].Rows.Count - 1)
            {
                MessageBox.Show("已经是最后一条记录！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BM.Position++;
            UpdateButtonState();
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            BM.Position = mySet.Tables[0].Rows.Count - 1;
            UpdateButtonState();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim() == "" ||
                txt_UserPWD.Text.Trim() == "" ||
                txt_UserPower.Text.Trim() == "")
            {
                MessageBox.Show("请先完善用户信息！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = @"UPDATE 用户信息 SET 密码=@pwd, 权限=@power, 备注=@bz 
                           WHERE 用户名=@name";

            using (SqlConnection conn = new SqlConnection(myConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", txt_UserName.Text.Trim());
                cmd.Parameters.AddWithValue("@pwd", txt_UserPWD.Text.Trim());
                cmd.Parameters.AddWithValue("@power", txt_UserPower.Text.Trim());
                cmd.Parameters.AddWithValue("@bz", txt_BZH.Text.Trim());

                try
                {
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();

                    MessageBox.Show(count > 0 ? "更新成功！" : "更新失败！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                }
            }

            LoadData(); // 刷新绑定
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim() == "" ||
                txt_UserPWD.Text.Trim() == "" ||
                txt_UserPower.Text.Trim() == "")
            {
                MessageBox.Show("请输入完整用户信息！");
                return;
            }

            string sql = @"INSERT INTO 用户信息(用户名, 密码, 权限, 备注)
                           VALUES(@name, @pwd, @power, @bz)";

            using (SqlConnection conn = new SqlConnection(myConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", txt_UserName.Text.Trim());
                cmd.Parameters.AddWithValue("@pwd", txt_UserPWD.Text.Trim());
                cmd.Parameters.AddWithValue("@power", txt_UserPower.Text.Trim());
                cmd.Parameters.AddWithValue("@bz", txt_BZH.Text.Trim());

                try
                {
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    MessageBox.Show(count > 0 ? "插入成功！" : "插入失败！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            LoadData(); // 自动刷新
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim() == "")
            {
                MessageBox.Show("请选择要删除的用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "DELETE FROM 用户信息 WHERE 用户名=@name";

            using (SqlConnection conn = new SqlConnection(myConnString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@name", txt_UserName.Text.Trim());

                try
                {
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    MessageBox.Show(count > 0 ? "删除成功！" : "删除失败，用户不存在！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                }
            }

            LoadData(); // 刷新数据绑定
        }
    }
}
