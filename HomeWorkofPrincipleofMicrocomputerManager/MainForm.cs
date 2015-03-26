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
    public partial class MainForm : Form
    {
        private MySqlConnection conn;
        //private string serverip = LoginForm.serverip;
        int i = 0;
        public MainForm()
        {
            StartPosition = FormStartPosition.CenterScreen;//窗口初始位置为屏幕中间
            InitializeComponent();
            TimeStatus.Text = String.Format("用户ID：{0} 密码：{1} 用户类型：{2} 专业：{3} 登录次数：{4} 点赞数量：{5}", LoginForm.userid, LoginForm.password, LoginForm.usertype, LoginForm.classname, LoginForm.logincount, LoginForm.zancount);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MyInfoButton.Text = LoginForm.username;//按钮Text改成用户名字

            //签到程序，一天只能签到一次
            string today = DateTime.Now.ToString("yyyy-MM-dd");//取得今天日期

            MySqlDataReader reader = null;
            MySqlCommand cmd;

            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false",
                LoginForm.serverip);

            try
            {
                //创建数据库链接
                conn = new MySqlConnection(connStr);
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("select * from loginlog where userid='" + LoginForm.userid + "' AND logindate='" + today + "'", conn);
                //查询结果放到reader中
                reader = cmd.ExecuteReader();
                //当天签过到就不再签到，第一次登陆就签到，并记录日期
                if (reader.HasRows)
                {
                    QianDaoCount.Text = String.Format("签到：{0}次", LoginForm.logincount);
                }
                else
                {
                    reader.Close();
                    LoginForm.logincount++;
                    QianDaoCount.Text = String.Format("签到：{0}次", LoginForm.logincount);
                    //个人信息签到数据更新
                    cmd = new MySqlCommand("update userinfo set logincount="+ LoginForm.logincount +" where userid='" + LoginForm.userid + "'", conn);
                    cmd.ExecuteNonQuery();
                    //签到记录更新
                    cmd = new MySqlCommand("INSERT INTO loginlog (userid, logindate) VALUES ('" + LoginForm.userid + "','" + today + "')", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
        }

        //点击关闭退出程序
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "图片文件|*.jpg|所有文件|*.*";
            openFileDialog1.Filter = "jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png|bmp文件(*.bmp)|*.bmp|ico文件(*.ico)|*.ico";
            openFileDialog1.Title = "打开图片";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetDataObject(Image.FromFile(openFileDialog1.FileName), false);
                richTextBox1.Paste();
            }
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button buttonX = new Button();

            buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            buttonX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            buttonX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            buttonX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            buttonX.Size = new System.Drawing.Size(splitContainer1.SplitterDistance-10, 50);
            buttonX.Location = new System.Drawing.Point(5,55*i+5);
            buttonX.Text = "动态添加";
            splitContainer1.Panel1.Controls.Add(buttonX);
            i++;
        }

        //分界线移动，左边按钮宽度改变
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            foreach (Control con in splitContainer1.Panel1.Controls)
            {
                con.Size = new System.Drawing.Size(splitContainer1.SplitterDistance - 10, 50);
            }
        }
        
        //鼠标经过或者离开按钮边框颜色改变
        private void ButtonPractice_MouseEnter(object sender, EventArgs e)
        {
            ButtonPractice.FlatAppearance.BorderColor = Color.FromArgb(195, 229, 245);
        }

        private void ButtonPractice_MouseLeave(object sender, EventArgs e)
        {
            ButtonPractice.FlatAppearance.BorderColor = Color.FromArgb(250, 250, 250);
        }

        private void ButtonLevel80_MouseEnter(object sender, EventArgs e)
        {
            ButtonLevel80.FlatAppearance.BorderColor = Color.FromArgb(195, 229, 245);
        }

        private void ButtonLevel80_MouseLeave(object sender, EventArgs e)
        {
            ButtonLevel80.FlatAppearance.BorderColor = Color.FromArgb(250, 250, 250);
        }

        private void ButtonLevel95_MouseEnter(object sender, EventArgs e)
        {
            ButtonLevel95.FlatAppearance.BorderColor = Color.FromArgb(195, 229, 245);
        }

        private void ButtonLevel95_MouseLeave(object sender, EventArgs e)
        {
            ButtonLevel95.FlatAppearance.BorderColor = Color.FromArgb(250, 250, 250);
        }

        private void ButtonLevel100_MouseEnter(object sender, EventArgs e)
        {
            ButtonLevel100.FlatAppearance.BorderColor = Color.FromArgb(195, 229, 245);
        }

        private void ButtonLevel100_MouseLeave(object sender, EventArgs e)
        {
            ButtonLevel100.FlatAppearance.BorderColor = Color.FromArgb(250, 250, 250);
        }

        private void ButtonDocument_MouseEnter(object sender, EventArgs e)
        {
            ButtonDocument.FlatAppearance.BorderColor = Color.FromArgb(195, 229, 245);
        }

        private void ButtonDocument_MouseLeave(object sender, EventArgs e)
        {
            ButtonDocument.FlatAppearance.BorderColor = Color.FromArgb(250, 250, 250);
        }
    }
}
