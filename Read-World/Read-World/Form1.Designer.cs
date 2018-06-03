namespace Read_World
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.封面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXT文件TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel表格EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.word文档WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.技术手册RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSSLUsersStaus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSBRead = new System.Windows.Forms.ToolStripButton();
            this.toolSBAdd = new System.Windows.Forms.ToolStripButton();
            this.toolSBDelte = new System.Windows.Forms.ToolStripButton();
            this.toolSBUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolSBFound = new System.Windows.Forms.ToolStripButton();
            this.toolSBExcel = new System.Windows.Forms.ToolStripButton();
            this.dGVBooksInfo = new System.Windows.Forms.DataGridView();
            this.gBoxBooksInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dTPBPubdate = new System.Windows.Forms.DateTimePicker();
            this.tBBPages = new System.Windows.Forms.TextBox();
            this.tBAuthor = new System.Windows.Forms.TextBox();
            this.tBBName = new System.Windows.Forms.TextBox();
            this.tBBID = new System.Windows.Forms.TextBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picBoxBooks = new System.Windows.Forms.PictureBox();
            this.toolSSlabelDatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.重新登录RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询窗口CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooksInfo)).BeginInit();
            this.gBoxBooksInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.全部ToolStripMenuItem,
            this.封面ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 全部ToolStripMenuItem
            // 
            this.全部ToolStripMenuItem.Name = "全部ToolStripMenuItem";
            this.全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部ToolStripMenuItem.Text = "全部";
            this.全部ToolStripMenuItem.Click += new System.EventHandler(this.全部ToolStripMenuItem_Click);
            // 
            // 封面ToolStripMenuItem
            // 
            this.封面ToolStripMenuItem.Name = "封面ToolStripMenuItem";
            this.封面ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.封面ToolStripMenuItem.Text = "详细信息";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.视图VToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.窗口WToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1417, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem,
            this.重新登录RToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Enabled = false;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出EToolStripMenuItem.Text = "退出(E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.Enabled = false;
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.Enabled = false;
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出PToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 导出PToolStripMenuItem
            // 
            this.导出PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXT文件TToolStripMenuItem,
            this.excel表格EToolStripMenuItem,
            this.word文档WToolStripMenuItem});
            this.导出PToolStripMenuItem.Name = "导出PToolStripMenuItem";
            this.导出PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导出PToolStripMenuItem.Text = "导出(&P)";
            // 
            // tXT文件TToolStripMenuItem
            // 
            this.tXT文件TToolStripMenuItem.Name = "tXT文件TToolStripMenuItem";
            this.tXT文件TToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tXT文件TToolStripMenuItem.Text = "Txt文本(&T)";
            // 
            // excel表格EToolStripMenuItem
            // 
            this.excel表格EToolStripMenuItem.Name = "excel表格EToolStripMenuItem";
            this.excel表格EToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excel表格EToolStripMenuItem.Text = "Excel表格(&E)";
            this.excel表格EToolStripMenuItem.Click += new System.EventHandler(this.excel表格EToolStripMenuItem_Click);
            // 
            // word文档WToolStripMenuItem
            // 
            this.word文档WToolStripMenuItem.Name = "word文档WToolStripMenuItem";
            this.word文档WToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.word文档WToolStripMenuItem.Text = "Word文档(&W)";
            // 
            // 窗口WToolStripMenuItem
            // 
            this.窗口WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询窗口CToolStripMenuItem});
            this.窗口WToolStripMenuItem.Name = "窗口WToolStripMenuItem";
            this.窗口WToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.窗口WToolStripMenuItem.Text = "窗口(&W)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem,
            this.技术手册RToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // 技术手册RToolStripMenuItem
            // 
            this.技术手册RToolStripMenuItem.Name = "技术手册RToolStripMenuItem";
            this.技术手册RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.技术手册RToolStripMenuItem.Text = "技术手册(&R)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSSLUsersStaus,
            this.toolSSlabelDatetime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1417, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSSLUsersStaus
            // 
            this.toolSSLUsersStaus.Name = "toolSSLUsersStaus";
            this.toolSSLUsersStaus.Size = new System.Drawing.Size(80, 17);
            this.toolSSLUsersStaus.Text = "用户状态信息";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSBRead,
            this.toolSBAdd,
            this.toolSBDelte,
            this.toolSBUpdate,
            this.toolSBFound,
            this.toolSBExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1417, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSBRead
            // 
            this.toolSBRead.Image = ((System.Drawing.Image)(resources.GetObject("toolSBRead.Image")));
            this.toolSBRead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBRead.Name = "toolSBRead";
            this.toolSBRead.Size = new System.Drawing.Size(52, 22);
            this.toolSBRead.Text = "浏览";
            this.toolSBRead.Click += new System.EventHandler(this.toolSBRead_Click);
            // 
            // toolSBAdd
            // 
            this.toolSBAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolSBAdd.Image")));
            this.toolSBAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBAdd.Name = "toolSBAdd";
            this.toolSBAdd.Size = new System.Drawing.Size(52, 22);
            this.toolSBAdd.Text = "添加";
            this.toolSBAdd.Click += new System.EventHandler(this.toolSBAdd_Click);
            // 
            // toolSBDelte
            // 
            this.toolSBDelte.Image = ((System.Drawing.Image)(resources.GetObject("toolSBDelte.Image")));
            this.toolSBDelte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBDelte.Name = "toolSBDelte";
            this.toolSBDelte.Size = new System.Drawing.Size(52, 22);
            this.toolSBDelte.Text = "删除";
            this.toolSBDelte.Click += new System.EventHandler(this.toolSBDelte_Click);
            // 
            // toolSBUpdate
            // 
            this.toolSBUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolSBUpdate.Image")));
            this.toolSBUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBUpdate.Name = "toolSBUpdate";
            this.toolSBUpdate.Size = new System.Drawing.Size(52, 22);
            this.toolSBUpdate.Text = "修改";
            this.toolSBUpdate.Click += new System.EventHandler(this.toolSBUpdate_Click);
            // 
            // toolSBFound
            // 
            this.toolSBFound.Image = ((System.Drawing.Image)(resources.GetObject("toolSBFound.Image")));
            this.toolSBFound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBFound.Name = "toolSBFound";
            this.toolSBFound.Size = new System.Drawing.Size(52, 22);
            this.toolSBFound.Text = "查询";
            this.toolSBFound.Click += new System.EventHandler(this.toolSBFound_Click);
            // 
            // toolSBExcel
            // 
            this.toolSBExcel.Image = ((System.Drawing.Image)(resources.GetObject("toolSBExcel.Image")));
            this.toolSBExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSBExcel.Name = "toolSBExcel";
            this.toolSBExcel.Size = new System.Drawing.Size(52, 22);
            this.toolSBExcel.Text = "导出";
            this.toolSBExcel.Click += new System.EventHandler(this.toolSBExcel_Click);
            // 
            // dGVBooksInfo
            // 
            this.dGVBooksInfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGVBooksInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBooksInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dGVBooksInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dGVBooksInfo.Location = new System.Drawing.Point(0, 52);
            this.dGVBooksInfo.Name = "dGVBooksInfo";
            this.dGVBooksInfo.RowTemplate.Height = 23;
            this.dGVBooksInfo.Size = new System.Drawing.Size(960, 293);
            this.dGVBooksInfo.TabIndex = 4;
            this.dGVBooksInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBooksInfo_CellClick);
            this.dGVBooksInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBooksInfo_CellDoubleClick);
            // 
            // gBoxBooksInfo
            // 
            this.gBoxBooksInfo.Controls.Add(this.pictureBox1);
            this.gBoxBooksInfo.Controls.Add(this.dTPBPubdate);
            this.gBoxBooksInfo.Controls.Add(this.tBBPages);
            this.gBoxBooksInfo.Controls.Add(this.tBAuthor);
            this.gBoxBooksInfo.Controls.Add(this.tBBName);
            this.gBoxBooksInfo.Controls.Add(this.tBBID);
            this.gBoxBooksInfo.Controls.Add(this.btUpload);
            this.gBoxBooksInfo.Controls.Add(this.btClean);
            this.gBoxBooksInfo.Controls.Add(this.btSubmit);
            this.gBoxBooksInfo.Controls.Add(this.label6);
            this.gBoxBooksInfo.Controls.Add(this.label3);
            this.gBoxBooksInfo.Controls.Add(this.label5);
            this.gBoxBooksInfo.Controls.Add(this.label2);
            this.gBoxBooksInfo.Controls.Add(this.label4);
            this.gBoxBooksInfo.Controls.Add(this.label1);
            this.gBoxBooksInfo.Location = new System.Drawing.Point(0, 343);
            this.gBoxBooksInfo.Name = "gBoxBooksInfo";
            this.gBoxBooksInfo.Size = new System.Drawing.Size(960, 279);
            this.gBoxBooksInfo.TabIndex = 5;
            this.gBoxBooksInfo.TabStop = false;
            this.gBoxBooksInfo.Text = "图书信息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 79);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dTPBPubdate
            // 
            this.dTPBPubdate.Location = new System.Drawing.Point(586, 125);
            this.dTPBPubdate.Name = "dTPBPubdate";
            this.dTPBPubdate.Size = new System.Drawing.Size(140, 21);
            this.dTPBPubdate.TabIndex = 3;
            // 
            // tBBPages
            // 
            this.tBBPages.Location = new System.Drawing.Point(269, 122);
            this.tBBPages.Name = "tBBPages";
            this.tBBPages.Size = new System.Drawing.Size(100, 21);
            this.tBBPages.TabIndex = 2;
            // 
            // tBAuthor
            // 
            this.tBAuthor.Location = new System.Drawing.Point(65, 122);
            this.tBAuthor.Name = "tBAuthor";
            this.tBAuthor.Size = new System.Drawing.Size(100, 21);
            this.tBAuthor.TabIndex = 2;
            // 
            // tBBName
            // 
            this.tBBName.Location = new System.Drawing.Point(269, 47);
            this.tBBName.Name = "tBBName";
            this.tBBName.Size = new System.Drawing.Size(100, 21);
            this.tBBName.TabIndex = 2;
            // 
            // tBBID
            // 
            this.tBBID.Location = new System.Drawing.Point(65, 47);
            this.tBBID.Name = "tBBID";
            this.tBBID.Size = new System.Drawing.Size(100, 21);
            this.tBBID.TabIndex = 2;
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(586, 45);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 23);
            this.btUpload.TabIndex = 1;
            this.btUpload.Text = "上传...";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(809, 105);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(139, 42);
            this.btClean.TabIndex = 1;
            this.btClean.Text = "重置";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(809, 45);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(139, 42);
            this.btSubmit.TabIndex = 1;
            this.btSubmit.Text = "提交";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "页数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出版日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "作者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "书名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "图书封面";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // picBoxBooks
            // 
            this.picBoxBooks.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBooks.Image")));
            this.picBoxBooks.Location = new System.Drawing.Point(959, 50);
            this.picBoxBooks.Name = "picBoxBooks";
            this.picBoxBooks.Size = new System.Drawing.Size(458, 572);
            this.picBoxBooks.TabIndex = 6;
            this.picBoxBooks.TabStop = false;
            // 
            // toolSSlabelDatetime
            // 
            this.toolSSlabelDatetime.Name = "toolSSlabelDatetime";
            this.toolSSlabelDatetime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolSSlabelDatetime.RightToLeftAutoMirrorImage = true;
            this.toolSSlabelDatetime.Size = new System.Drawing.Size(56, 17);
            this.toolSSlabelDatetime.Text = "当前时间";
            // 
            // 重新登录RToolStripMenuItem
            // 
            this.重新登录RToolStripMenuItem.Name = "重新登录RToolStripMenuItem";
            this.重新登录RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重新登录RToolStripMenuItem.Text = "重新登录(&R)";
            this.重新登录RToolStripMenuItem.Click += new System.EventHandler(this.重新登录RToolStripMenuItem_Click);
            // 
            // 查询窗口CToolStripMenuItem
            // 
            this.查询窗口CToolStripMenuItem.Name = "查询窗口CToolStripMenuItem";
            this.查询窗口CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查询窗口CToolStripMenuItem.Text = "查询窗口(&C)";
            this.查询窗口CToolStripMenuItem.Click += new System.EventHandler(this.查询窗口CToolStripMenuItem_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BID";
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 192;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BCover";
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "封面";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BName";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "书名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 192;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BAuthor";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "作者";
            this.Column3.Name = "Column3";
            this.Column3.Width = 192;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BPubDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "出版日期";
            this.Column4.Name = "Column4";
            this.Column4.Width = 192;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BPages";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "页数";
            this.Column5.Name = "Column5";
            this.Column5.Width = 192;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1417, 642);
            this.Controls.Add(this.picBoxBooks);
            this.Controls.Add(this.gBoxBooksInfo);
            this.Controls.Add(this.dGVBooksInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "图书信息管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooksInfo)).EndInit();
            this.gBoxBooksInfo.ResumeLayout(false);
            this.gBoxBooksInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXT文件TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel表格EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 技术手册RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem word文档WToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolSSLUsersStaus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSBRead;
        private System.Windows.Forms.ToolStripButton toolSBAdd;
        private System.Windows.Forms.ToolStripButton toolSBDelte;
        private System.Windows.Forms.ToolStripButton toolSBUpdate;
        private System.Windows.Forms.ToolStripButton toolSBFound;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 封面ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gBoxBooksInfo;
        private System.Windows.Forms.DateTimePicker dTPBPubdate;
        private System.Windows.Forms.TextBox tBBPages;
        private System.Windows.Forms.TextBox tBAuthor;
        private System.Windows.Forms.TextBox tBBName;
        private System.Windows.Forms.TextBox tBBID;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btClean;
        public System.Windows.Forms.DataGridView dGVBooksInfo;
        private System.Windows.Forms.ToolStripButton toolSBExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picBoxBooks;
        private System.Windows.Forms.ToolStripStatusLabel toolSSlabelDatetime;
        private System.Windows.Forms.ToolStripMenuItem 重新登录RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询窗口CToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

