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

namespace myfirstDB.ExcelIO
{
    public partial class ExportExcel : Form
    {
        private string myConnString;
        public ExportExcel()
        {
            InitializeComponent();
        }
        public ExportExcel(string ConnString)
        {
            InitializeComponent();
            myConnString = ConnString;
        }


        private void ExportExcel_Load(object sender, EventArgs e)
        {
            try
            {
                ExcelIO myIO = new ExcelIO();

                DataTable tbl = myIO.GetDBTableName(myConnString);

                com_ExportTable.Items.Clear();
                foreach (DataRow row in tbl.Rows)
                {
                    com_ExportTable.Items.Add(row[0].ToString());
                }

                if (com_ExportTable.Items.Count > 0)
                    com_ExportTable.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载数据库表失败：\n" + ex.Message);
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.InitialDirectory = "D:\\";
            saveDlg.Filter = "Excel 97-2003 (*.xls)|*.xls|Excel 工作簿 (*.xlsx)|*.xlsx";
            saveDlg.FilterIndex = 1;
            saveDlg.RestoreDirectory = true;

            try
            {
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    txt_SaveExcelPath.Text = saveDlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件保存路径选择失败：\n" + ex.Message);
            }
        }
        // DataSet 导出到 Excel
       

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SaveExcelPath.Text.Trim() == "")
                {
                    MessageBox.Show("请先选择保存路径！");
                    return;
                }

                ExcelIO myIO = new ExcelIO();
                DataSet ds = GetDataSet(com_ExportTable.Text.Trim());

                if (ds != null)
                {
                    bool ok = myIO.DataSetToExcel(ds, false, txt_SaveExcelPath.Text.Trim());
                    if (ok)
                        MessageBox.Show("数据成功导出到 Excel！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败：\n" + ex.Message);
            }
        }
        private DataSet GetDataSet(string tableName)
        {
            try
            {
                ExcelIO myIO = new ExcelIO();
                return myIO.GetDataSetByTableName(myConnString, tableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取数据集失败：\n" + ex.Message);
                return null;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
