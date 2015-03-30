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
    public partial class addClass : UserControl
    {
        private MySqlConnection conn;

        public addClass()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (className.Text == "" || teacherName.Text == "")
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
                cmd = new MySqlCommand("insert into teacherinfo(teacherName,teachClass) values('"+teacherName.Text+"','"+className.Text+"')", conn);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("     添加班级成功     ");
                }
                else if (i == 0)
                {
                    MessageBox.Show("     添加失败     ");
                }
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
