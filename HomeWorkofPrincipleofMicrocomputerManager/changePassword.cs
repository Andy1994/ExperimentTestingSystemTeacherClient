using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeWorkofPrincipleofMicrocomputerManager
{
    public partial class changePassword : Form
    {
        private MySqlConnection conn;

        public changePassword()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void oldPassword_Enter(object sender, EventArgs e)
        {
        }

        private void newPassword_Enter(object sender, EventArgs e)
        {
            newPassword.Text = "";
            newPasswordConfirm.Text = "";
            newPassword.PasswordChar = '*';
            newPasswordConfirm.PasswordChar = '*';
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (oldPassword.Text == "" || newPassword.Text == "" || newPasswordConfirm.Text == "")
            {
                MessageBox.Show("     请全部填写!     ");
                return;
            }
            if (newPassword.Text != newPasswordConfirm.Text)
            {
                MessageBox.Show("     两次输入新密码不一样,请确认!     ");
                return;
            }
            if (oldPassword.Text != LoginForm.password)
            {
                MessageBox.Show("     原密码错误,请确认!     ");
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
                cmd = new MySqlCommand("update userinfo set password='"+newPassword.Text+"' where userid='"+LoginForm.userid+"'", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("     密码修改成功,下次登陆使用新密码!     ");
                LoginForm.password = newPassword.Text;
                this.Hide();
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
