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
    public partial class addStudent : UserControl
    {
        private MySqlConnection conn;

        public addStudent()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "" || nameBox.Text == "" || passBox.Text == "" || classBox.Text == "" || xuhaoBox.Text == "")
            {
                MessageBox.Show("     有漏填!     ");
                return;
            }

            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8",
    LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

            MySqlCommand cmd;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("insert into userinfo(userid,username,password,classname,usertype,logincount,zancount,xuhao) values('" + idBox.Text + "','" + nameBox.Text + "','" + passBox.Text + "','" + classBox.Text + "','student',0,0," + Int32.Parse(xuhaoBox.Text) + ")", conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("     添加成功!     ");
                idBox.Text = "";
                nameBox.Text = "";
                passBox.Text = "";
                classBox.Text = "";
                xuhaoBox.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }
    }
}
