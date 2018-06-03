namespace Read_World
{
    partial class FoundMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btFound = new System.Windows.Forms.Button();
            this.tBKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBIFShow = new System.Windows.Forms.ComboBox();
            this.btClean = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "关键字";
            // 
            // btFound
            // 
            this.btFound.Location = new System.Drawing.Point(24, 110);
            this.btFound.Name = "btFound";
            this.btFound.Size = new System.Drawing.Size(155, 23);
            this.btFound.TabIndex = 1;
            this.btFound.Text = "查询";
            this.btFound.UseVisualStyleBackColor = true;
            this.btFound.Click += new System.EventHandler(this.btFound_Click);
            // 
            // tBKey
            // 
            this.tBKey.Location = new System.Drawing.Point(69, 54);
            this.tBKey.Name = "tBKey";
            this.tBKey.Size = new System.Drawing.Size(121, 21);
            this.tBKey.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "条件筛选";
            // 
            // cBIFShow
            // 
            this.cBIFShow.FormattingEnabled = true;
            this.cBIFShow.Items.AddRange(new object[] {
            "编号",
            "书名",
            "作者",
            "出版日期",
            "页数"});
            this.cBIFShow.Location = new System.Drawing.Point(69, 13);
            this.cBIFShow.Name = "cBIFShow";
            this.cBIFShow.Size = new System.Drawing.Size(121, 20);
            this.cBIFShow.TabIndex = 5;
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(24, 142);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(155, 23);
            this.btClean.TabIndex = 6;
            this.btClean.Text = "重置";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 138);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "注意：   当条件查询是\'出版日期\'时，关键字格式为\'xxxx-xx-xx\',如\'2011-07-01\'";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(196, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 153);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公告";
            // 
            // FoundMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.cBIFShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBKey);
            this.Controls.Add(this.btFound);
            this.Controls.Add(this.label1);
            this.Name = "FoundMain";
            this.Text = "条件查询";
            this.Load += new System.EventHandler(this.FoundMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFound;
        private System.Windows.Forms.TextBox tBKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBIFShow;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}