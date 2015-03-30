using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeWorkofPrincipleofMicrocomputerManager
{
    public partial class addTeacher : UserControl
    {
        private MySqlConnection conn;

        public addTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID.Text == "" || name.Text == ""|| pass.Text =="")
            {
                MessageBox.Show("     有漏填!     ");
                return;
            }

            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8", LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

            MySqlCommand cmd;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("insert into userinfo(userid,username,password,usertype,classname) values('" + ID.Text + "','" + name.Text + "','"+pass.Text+"','admin','admin')", conn);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("     添加教师成功     ");
                    ID.Text = "";
                    name.Text = "";
                    pass.Text = "";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("     添加失败,ID被使用     ");
                ID.Text = "";
                name.Text = "";
                pass.Text = "";
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }
    }
}
