using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace myfirstDB.ExcelIO
{
    public partial class ImportExcel : Form
    {
        private string myConnString;
        public ImportExcel()
        {
            InitializeComponent();
        }
        public ImportExcel(string ConnString)
        {
            InitializeComponent();
            myConnString = ConnString;
        }

        public class ExcelIO
        {
            public DataSet GetExcelSet(string ExcelPath, string ExcelTableName)
            {
                string connStr = $"Provider=Microsoft.Ace.OleDb.12.0;Data Source={ExcelPath};Extended Properties='Excel 12.0;HDR=Yes;IMEX=1'";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    string sql = $"SELECT * FROM [{ExcelTableName}]";
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ExcelData");
                    return ds;
                }
            }

            public DataTable GetExcelSheetName(string ExcelPath)
            {
                string connStr = $"Provider=Microsoft.Ace.OleDb.12.0;Data Source={ExcelPath};Extended Properties='Excel 12.0;HDR=Yes;IMEX=1'";
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    return conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                }
            }

            public DataTable GetDBTableName(string connStr)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    return conn.GetSchema("Tables");
                }
            }

            public int InsertData(DataSet mySet, string strConnection, string strTableName)
            {
                int rowsAffected = 0;
                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    conn.Open();
                    string strSQL = $"SELECT * FROM [{strTableName}]";
                    SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da)
                    {
                        QuotePrefix = "[",
                        QuoteSuffix = "]"
                    };

                    DataSet dbSet = new DataSet();
                    da.Fill(dbSet, strTableName);

                    foreach (DataRow dr in mySet.Tables[0].Rows)
                    {
                        DataRow newRow = dbSet.Tables[0].NewRow();
                        newRow.ItemArray = dr.ItemArray;
                        dbSet.Tables[0].Rows.Add(newRow);
                    }

                    rowsAffected = da.Update(dbSet, strTableName);
                    return rowsAffected;
                }
            }
        }


        private void btn_Brow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Filter = "Excel 文件 (*.xls;*.xlsx)|*.xls;*.xlsx",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_ImportExcelName.Text = ofd.FileName.Trim();

                ExcelIO excelIO = new ExcelIO();

                // 填充 Sheet 名称
                DataTable sheets = excelIO.GetExcelSheetName(ofd.FileName);
                com_SheetName.Items.Clear();
                foreach (DataRow row in sheets.Rows)
                {
                    com_SheetName.Items.Add(row["TABLE_NAME"].ToString());
                }
                if (com_SheetName.Items.Count > 0)
                    com_SheetName.SelectedIndex = 0;

                // 填充数据库表名
                DataTable dbTables = excelIO.GetDBTableName(myConnString);
                com_ObjTableName.Items.Clear();
                foreach (DataRow row in dbTables.Rows)
                {
                    com_ObjTableName.Items.Add(row[2].ToString()); // TABLE_NAME 列索引为 2
                }
                if (com_ObjTableName.Items.Count > 0)
                    com_ObjTableName.SelectedIndex = 0;
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelIO excelIO = new ExcelIO();
                DataSet ds = excelIO.GetExcelSet(txt_ImportExcelName.Text.Trim(), com_SheetName.Text.Trim());
                int result = excelIO.InsertData(ds, myConnString, com_ObjTableName.Text.Trim());
                MessageBox.Show(result > 0 ? "导入数据成功！" : "导入的数据为空！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入失败：" + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
