using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;


namespace myfirstDB.ExcelIO
{
    internal class ExcelIO
    {
        public DataTable GetDBTableName(string ConnString)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                string sql = "SELECT name FROM sys.tables ORDER BY name";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataSet GetDataSetByTableName(string ConnString, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                string sql = $"SELECT * FROM {tableName}";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        // DataSet 导出到 Excel
        public bool DataSetToExcel(DataSet dataSet, bool showExcel, string savePath)
        {
            try
            {
                DataTable table = dataSet.Tables[0];

                if (table.Rows.Count == 0)
                    return false;

                Application excel = new Application();
                Workbook wb = excel.Workbooks.Add(Type.Missing);
                Worksheet ws = (Worksheet)wb.ActiveSheet;

                excel.Visible = showExcel;

                // 写入列名
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = table.Columns[i].ColumnName;
                }

                // 写入内容
                for (int r = 0; r < table.Rows.Count; r++)
                {
                    for (int c = 0; c < table.Columns.Count; c++)
                    {
                        ws.Cells[r + 2, c + 1] = table.Rows[r][c].ToString();
                    }
                }

                // 保存
                wb.SaveAs(savePath);
                wb.Close();
                excel.Quit();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Excel 导出失败：" + ex.Message);
            }
        }
    }
}
