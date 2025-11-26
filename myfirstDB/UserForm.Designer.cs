namespace myfirstDB
{
    partial class UserForm
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_BZH = new System.Windows.Forms.TextBox();
            this.txt_UserPower = new System.Windows.Forms.TextBox();
            this.txt_UserPWD = new System.Windows.Forms.TextBox();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Privious = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(514, 146);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(349, 28);
            this.txt_UserName.TabIndex = 0;
            // 
            // txt_BZH
            // 
            this.txt_BZH.Location = new System.Drawing.Point(514, 316);
            this.txt_BZH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BZH.Name = "txt_BZH";
            this.txt_BZH.Size = new System.Drawing.Size(349, 28);
            this.txt_BZH.TabIndex = 1;
            // 
            // txt_UserPower
            // 
            this.txt_UserPower.Location = new System.Drawing.Point(514, 261);
            this.txt_UserPower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserPower.Name = "txt_UserPower";
            this.txt_UserPower.Size = new System.Drawing.Size(349, 28);
            this.txt_UserPower.TabIndex = 2;
            // 
            // txt_UserPWD
            // 
            this.txt_UserPWD.Location = new System.Drawing.Point(514, 206);
            this.txt_UserPWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UserPWD.Name = "txt_UserPWD";
            this.txt_UserPWD.Size = new System.Drawing.Size(349, 28);
            this.txt_UserPWD.TabIndex = 3;
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(60, 442);
            this.btn_First.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(112, 34);
            this.btn_First.TabIndex = 4;
            this.btn_First.Text = "第一条";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Privious
            // 
            this.btn_Privious.Location = new System.Drawing.Point(208, 442);
            this.btn_Privious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Privious.Name = "btn_Privious";
            this.btn_Privious.Size = new System.Drawing.Size(112, 34);
            this.btn_Privious.TabIndex = 5;
            this.btn_Privious.Text = "上一条";
            this.btn_Privious.UseVisualStyleBackColor = true;
            this.btn_Privious.Click += new System.EventHandler(this.btn_Privious_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(358, 442);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(112, 34);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "下一条";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(514, 442);
            this.btn_Last.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(112, 34);
            this.btn_Last.TabIndex = 7;
            this.btn_Last.Text = "最后一条";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(668, 442);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(112, 34);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(824, 442);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(112, 34);
            this.btn_Insert.TabIndex = 9;
            this.btn_Insert.Text = "插入";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(984, 442);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 34);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "权限";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "密码";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Privious);
            this.Controls.Add(this.btn_First);
            this.Controls.Add(this.txt_UserPWD);
            this.Controls.Add(this.txt_UserPower);
            this.Controls.Add(this.txt_BZH);
            this.Controls.Add(this.txt_UserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserForm";
            this.Text = "用户管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_BZH;
        private System.Windows.Forms.TextBox txt_UserPower;
        private System.Windows.Forms.TextBox txt_UserPWD;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Privious;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}