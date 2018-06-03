using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace Read_World
{
    public partial class frmMain : Form
    {
        

        BooksDataContext db = new BooksDataContext();

        public frmMain()
        {
            InitializeComponent();
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox fab = new frmAboutBox();
            fab.Show();
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void toolSBRead_Click(object sender, EventArgs e)
        {
            this.dGVBooksInfo.DataSource = from p in db.Books select p;
        }

        private void toolSBDelte_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dGVBooksInfo.CurrentCell != null)
                {
                    int n = this.dGVBooksInfo.CurrentCell.RowIndex;

                    string bid = this.dGVBooksInfo.CurrentRow.Cells[0].Value.ToString();

                    Books b = db.Books.Single(p => p.BID == bid);

                    db.Books.DeleteOnSubmit(b);

                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.dGVBooksInfo.DataSource = from p in db.Books select p;
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dGVBooksInfo.CurrentCell != null)
                {
                    int n = this.dGVBooksInfo.CurrentCell.RowIndex;

                    string bid = this.dGVBooksInfo.CurrentRow.Cells[0].Value.ToString();

                    Books b = db.Books.Single(p => p.BID == bid);

                    db.Books.DeleteOnSubmit(b);

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.dGVBooksInfo.DataSource = from p in db.Books select p;
            }
        }


        private string uname;

        public string Uname
        {
            set { uname = value; }
            get { return uname; }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            toolSSlabelDatetime.Text = "。当前时间是："+DateTime.Now.ToString();
            toolSSLUsersStaus.Text = "你好，"+uname;

            this.gBoxBooksInfo.Visible = false;

            this.dGVBooksInfo.DataSource = from p in db.Books select p;

            if (uname != "admin")
            {
                toolSBAdd.Enabled = false;
                toolSBDelte.Enabled = false;
                toolSBUpdate.Enabled = false;
            }
        }

        private void 全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dGVBooksInfo.DataSource = from p in db.Books select p;
        }

        private void toolSBAdd_Click(object sender, EventArgs e)
        {
            this.gBoxBooksInfo.Visible = true;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.FileName != "" && tBBID.Text != "")
                {
                    if (AddInfo(tBBID.Text, openFileDialog1.FileName,tBBName.Text, tBAuthor.Text,dTPBPubdate.Text,tBBPages.Text))
                    {
                        MessageBox.Show("用户信息添加成功");
                    }
                }
                ShowInfo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dGVBooksInfo.DataSource = from p in db.Books select p;
            }
        }

        private void ShowInfo()
        {
            this.dGVBooksInfo.DataSource = from p in db.Books select p;
        }

        private bool AddInfo(object text1 , string strImage, object text2, object text3, object text4, object text5)
        {
            Books b = new Books();

            FileStream FStream = new FileStream(strImage, FileMode.Open, FileAccess.Read);

            BinaryReader BReader = new BinaryReader(FStream);

            byte[] byteImage = BReader.ReadBytes((int)FStream.Length);

            b.BID = (string)text1;
            b.BCover = byteImage;
            b.BName = (string)text2;
            b.BAuthor = (string)text3;
            b.BPubDate = Convert.ToDateTime((string)text4);
            b.BPages = Convert.ToInt32((string)text5);

            db.Books.InsertOnSubmit(b);

            db.SubmitChanges();

            return true;
        }

        private void dGVBooksInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dGVBooksInfo.CurrentRow;

            Books b = new Books();

            if (dgvr != null)
            {
                this.tBBID.Text = dgvr.Cells[0].Value.ToString();
                this.tBBName.Text = dgvr.Cells[2].Value.ToString();
                this.tBAuthor.Text = dgvr.Cells[3].Value.ToString();
                this.dTPBPubdate.Text = dgvr.Cells[4].Value.ToString();
                this.tBBPages.Text = dgvr.Cells[5].Value.ToString();
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            tBBID.Text = "";
            tBBName.Text = "";
            tBBPages.Text = "";
            tBAuthor.Text = "";
        }

        private void toolSBFound_Click(object sender, EventArgs e)
        {
            FoundMain found = new FoundMain();
            this.Hide();
            found.Show();
            this.toolSBFound.Enabled = false;
        }

        private void toolSBUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dgvr = this.dGVBooksInfo.CurrentRow;

                Books b = new Books();

                if (dgvr != null)
                {
                    b.BID = dgvr.Cells[0].Value.ToString();
                    b.BCover = null;
                    b.BName = dgvr.Cells[2].Value.ToString();
                    b.BAuthor = dgvr.Cells[3].Value.ToString();
                    b.BPubDate = Convert.ToDateTime(dgvr.Cells[4].Value.ToString());
                    b.BPages = int.Parse(dgvr.Cells[5].Value.ToString());
                }

                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
            finally
            {
                dGVBooksInfo.DataSource = from p in db.Books select p;
            }
        }

        private void toolSBExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "";
                string saveFileName = "";

                saveFileDialog1.Filter = "Excel文件(*.xls) | *.xls |Microsoft Excel文件(*.xlsx) |*.xlsx";
                saveFileDialog1.Title = "保存学生信息";
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.ShowDialog();

                saveFileName = saveFileDialog1.FileName;

                #region 利用Excel组件导出数据
                if (saveFileName.IndexOf(":") < 0)
                    return;
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("请安装Excel");
                    return;
                }

                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;

                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                //写标题
                for (int i = 0; i < dGVBooksInfo.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dGVBooksInfo.Columns[i].HeaderText;
                }

                //写数值
                for (int r = 0; r < dGVBooksInfo.Rows.Count; r++)
                {
                    for (int i = 0; i < dGVBooksInfo.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = dGVBooksInfo.Rows[r].Cells[i].Value;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }

                //列宽自适应
                worksheet.Columns.EntireColumn.AutoFit();

                MessageBox.Show(fileName + "学生信息保存成功", "提示", MessageBoxButtons.OK);

                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;

                        workbook.SaveCopyAs(saveFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导出文件出错，请再次尝试\n", ex.Message);
                    }
                }
                //xlApp.Quit();

                //强行销毁
                //GC.Collect();
                #endregion
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            //定义可选择的头像文件类型
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png";

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "选择头像";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picBoxBooks.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void dGVBooksInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //数据库连接对象
                SqlConnection sqlcon;

                //数据库桥接器对象
                SqlDataAdapter sqlda;

                //数据集对象
                DataSet myds;

                string strCon = "Data Source=.;Database=ReadWorld;uid=sa;pwd=123456";

                //记录选择的图书编号
                string strID = dGVBooksInfo.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (strID != "")
                {
                    sqlcon = new SqlConnection(strCon);

                    sqlda = new SqlDataAdapter("select * from Books where BID='" + strID + "'", sqlcon);

                    myds = new DataSet();

                    sqlda.Fill(myds);

                    //显示图书编号等字段
                    tBBID.Text = myds.Tables[0].Rows[0][0].ToString();
                    tBBName.Text = myds.Tables[0].Rows[0][2].ToString();
                    tBAuthor.Text = myds.Tables[0].Rows[0][3].ToString();
                    dTPBPubdate.Text = myds.Tables[0].Rows[0][4].ToString();
                    tBBPages.Text = myds.Tables[0].Rows[0][0].ToString();

                    //使用数据库中存储的二进制封面实例化内存数据流
                    if (myds.Tables[0].Rows[0][1] != null)
                    {
                        MemoryStream MStream = new MemoryStream((byte[])myds.Tables[0].Rows[0][1]);

                        //显示图书封面
                        picBoxBooks.Image = Image.FromStream(MStream);
                    }
                    else
                    {
                        //this.picBoxBooks.Image = Image.FromFile(@"img\no-photo-shu.png",true) ; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 重新登录RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.Show();
            this.Close();
        }

        private void excel表格EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "";
                string saveFileName = "";

                saveFileDialog1.Filter = "Excel文件(*.xls) | *.xls |Microsoft Excel文件(*.xlsx) |*.xlsx";
                saveFileDialog1.Title = "保存学生信息";
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.ShowDialog();

                saveFileName = saveFileDialog1.FileName;

                #region 利用Excel组件导出数据
                if (saveFileName.IndexOf(":") < 0)
                    return;
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("请安装Excel");
                    return;
                }

                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;

                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                //写标题
                for (int i = 0; i < dGVBooksInfo.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dGVBooksInfo.Columns[i].HeaderText;
                }

                //写数值
                for (int r = 0; r < dGVBooksInfo.Rows.Count; r++)
                {
                    for (int i = 0; i < dGVBooksInfo.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = dGVBooksInfo.Rows[r].Cells[i].Value;
                    }
                    System.Windows.Forms.Application.DoEvents();
                }

                //列宽自适应
                worksheet.Columns.EntireColumn.AutoFit();

                MessageBox.Show(fileName + "学生信息保存成功", "提示", MessageBoxButtons.OK);

                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;

                        workbook.SaveCopyAs(saveFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("导出文件出错，请再次尝试\n", ex.Message);
                    }
                }
                //xlApp.Quit();

                //强行销毁
                //GC.Collect();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 查询窗口CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoundMain found = new FoundMain();
            this.Hide();
            found.Show();
            this.toolSBFound.Enabled = false;
        }
    }
}
