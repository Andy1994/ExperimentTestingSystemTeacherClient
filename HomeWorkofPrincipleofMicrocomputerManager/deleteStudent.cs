using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeWorkofPrincipleofMicrocomputerManager
{
    public partial class deleteStudent : UserControl
    {
        private MySqlConnection conn;

        public deleteStudent()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteID.Text == "" || deleteName.Text == "")
            {
                MessageBox.Show("     有漏填!     ");
                return;
            }

            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8",LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

            MySqlCommand cmd;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("delete from userinfo where userid='"+deleteID.Text+"' and username='"+deleteName.Text+"'", conn);
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("     输入帐号用户名有误,请确认     ");
                    deleteID.Text = "";
                    deleteName.Text = "";
                }
                else if (i == 1)
                {
                    MessageBox.Show("     删除成功!     ");
                    deleteID.Text = "";
                    deleteName.Text = "";
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
