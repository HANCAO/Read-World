using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_World
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        

        private void loginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string connstr = "SERVER=.;DATABASE=ReadWorld;Integrated Security=true";

            SqlConnection sqlconn = new SqlConnection(connstr);

            sqlconn.Open();

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "SELECT * FROM Users WHERE UName='" + cBUserName.Text.Trim() + "'";

            SqlDataReader dr = sqlcmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string str = dr["UPassword"].ToString();
                    if (str == dr["UPassword"].ToString())
                    {
                        frmMain fm = new frmMain();
                        fm.Uname = cBUserName.Text;
                        fm.Show();
                        this.Hide();
                    }
                }
            }
            sqlconn.Close();
        }

        private void cBUserName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cBUserName.Text=="admin")
                tBPassword.Text = "password";
            else if(cBUserName.Text=="Amay")
                tBPassword.Text = "123456";
            else if (cBUserName.Text == "JinSiLei")
                tBPassword.Text = "12345";
            else if (cBUserName.Text == "Wangqikai")
                tBPassword.Text = "1234";
            else if (cBUserName.Text == "TianYa")
                tBPassword.Text = "123";
            else if (cBUserName.Text == "HanSiChen")
                tBPassword.Text = "12";
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cBUserName.Text = "";
            tBPassword.Text = "";
        }
    }
}
