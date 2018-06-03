using System;
using System.Linq;
using System.Windows.Forms;



namespace Read_World
{
    public delegate void FoundData();

    public partial class FoundMain : Form
    {
        //public event FoundData founddata;

        BooksDataContext db = new BooksDataContext();

        public FoundMain()
        {
            InitializeComponent();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            tBKey.Text = "";
            cBIFShow.Text = "";
            frmMain.dGVBooksInfo.DataSource = from p in db.Books select p;
        }

        frmMain frmMain = new frmMain();

        private void FoundMain_Load(object sender, EventArgs e)
        {
            frmMain.Show();
        }

        private void btFound_Click(object sender, EventArgs e)
        {

            try
            {
                string type = this.cBIFShow.SelectedItem.ToString();

                if (type == "" || "".Equals(type))
                {
                    MessageBox.Show("请通过多选框选择查询条件！");
                    return;
                }
                if (tBKey.Text == "" || "".Equals(tBKey))
                {
                    MessageBox.Show("请在文本框内输入查询内容！");
                    return;
                }

                switch (type)
                {
                    case "编号":
                        frmMain.dGVBooksInfo.DataSource = from p in db.Books where p.BID.Contains(this.tBKey.Text) select p;
                        break;
                    case "书名":
                        frmMain.dGVBooksInfo.DataSource = from p in db.Books where p.BName.Contains(this.tBKey.Text) select p;
                        break;
                    case "作者":
                        frmMain.dGVBooksInfo.DataSource = from p in db.Books where p.BAuthor.Contains(this.tBKey.Text) select p;
                        break;
                    case "出版日期":
                        frmMain.dGVBooksInfo.DataSource = from p in db.Books where Convert.ToString(p.BPubDate).Contains(this.tBKey.Text) select p;
                        break;
                    case "页数":
                        frmMain.dGVBooksInfo.DataSource = from p in db.Books where Convert.ToString(p.BPages).Contains(this.tBKey.Text) select p;
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
