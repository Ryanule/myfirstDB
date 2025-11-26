namespace myfirstDB.ExcelIO
{
    partial class ExportExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.com_ExportTable = new System.Windows.Forms.ComboBox();
            this.txt_SaveExcelPath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // com_ExportTable
            // 
            this.com_ExportTable.FormattingEnabled = true;
            this.com_ExportTable.Location = new System.Drawing.Point(172, 38);
            this.com_ExportTable.Name = "com_ExportTable";
            this.com_ExportTable.Size = new System.Drawing.Size(211, 20);
            this.com_ExportTable.TabIndex = 0;
            // 
            // txt_SaveExcelPath
            // 
            this.txt_SaveExcelPath.Location = new System.Drawing.Point(172, 85);
            this.txt_SaveExcelPath.Name = "txt_SaveExcelPath";
            this.txt_SaveExcelPath.Size = new System.Drawing.Size(211, 21);
            this.txt_SaveExcelPath.TabIndex = 1;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(389, 85);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(51, 21);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "浏览";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(172, 154);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "导出";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(320, 154);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择数据表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "保存路径：";
            // 
            // ExportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txt_SaveExcelPath);
            this.Controls.Add(this.com_ExportTable);
            this.Name = "ExportExcel";
            this.Text = "ExportExcel";
            this.Load += new System.EventHandler(this.ExportExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_ExportTable;
        private System.Windows.Forms.TextBox txt_SaveExcelPath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}