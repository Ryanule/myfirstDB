namespace myfirstDB.ExcelIO
{
    partial class ImportExcel
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
            this.txt_ImportExcelName = new System.Windows.Forms.TextBox();
            this.com_SheetName = new System.Windows.Forms.ComboBox();
            this.com_ObjTableName = new System.Windows.Forms.ComboBox();
            this.btn_Brow = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ImportExcelName
            // 
            this.txt_ImportExcelName.Location = new System.Drawing.Point(194, 34);
            this.txt_ImportExcelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ImportExcelName.Name = "txt_ImportExcelName";
            this.txt_ImportExcelName.Size = new System.Drawing.Size(396, 28);
            this.txt_ImportExcelName.TabIndex = 0;
            // 
            // com_SheetName
            // 
            this.com_SheetName.FormattingEnabled = true;
            this.com_SheetName.Location = new System.Drawing.Point(194, 94);
            this.com_SheetName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.com_SheetName.Name = "com_SheetName";
            this.com_SheetName.Size = new System.Drawing.Size(396, 26);
            this.com_SheetName.TabIndex = 1;
            // 
            // com_ObjTableName
            // 
            this.com_ObjTableName.FormattingEnabled = true;
            this.com_ObjTableName.Location = new System.Drawing.Point(194, 153);
            this.com_ObjTableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.com_ObjTableName.Name = "com_ObjTableName";
            this.com_ObjTableName.Size = new System.Drawing.Size(396, 26);
            this.com_ObjTableName.TabIndex = 2;
            // 
            // btn_Brow
            // 
            this.btn_Brow.Location = new System.Drawing.Point(690, 30);
            this.btn_Brow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Brow.Name = "btn_Brow";
            this.btn_Brow.Size = new System.Drawing.Size(112, 34);
            this.btn_Brow.TabIndex = 3;
            this.btn_Brow.Text = "浏览";
            this.btn_Brow.UseVisualStyleBackColor = true;
            this.btn_Brow.Click += new System.EventHandler(this.btn_Brow_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(426, 243);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(112, 34);
            this.btn_Import.TabIndex = 4;
            this.btn_Import.Text = "导入";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(645, 243);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 34);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "关闭";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "待导入的文件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "导入的表格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "目标表格";
            // 
            // ImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Brow);
            this.Controls.Add(this.com_ObjTableName);
            this.Controls.Add(this.com_SheetName);
            this.Controls.Add(this.txt_ImportExcelName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImportExcel";
            this.Text = "ImportExcel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ImportExcelName;
        private System.Windows.Forms.ComboBox com_SheetName;
        private System.Windows.Forms.ComboBox com_ObjTableName;
        private System.Windows.Forms.Button btn_Brow;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}