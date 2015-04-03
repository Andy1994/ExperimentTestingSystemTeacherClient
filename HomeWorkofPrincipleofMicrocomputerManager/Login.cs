using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeWorkofPrincipleofMicrocomputerManager
{
    public partial class LoginForm : Form
    {
        private MySqlConnection conn;
        //private MySqlDataAdapter da;
        MySqlCommand cmd;
        public static string serverip = "127.0.0.1";//服务器IP地址
        public static bool isChangeIP = false;//记录IP地址改变
        public static string userid;//用户名
        public static string username;//用户姓名
        public static string password;//密码
        public static string usertype;//用户类型
        public static string classname;//专业
        public static int logincount;//登录次数
        public static int zancount;//点赞次数
        
        public LoginForm()
        {
            StartPosition = FormStartPosition.CenterScreen;//窗口初始位置为屏幕中间
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //设置随机背景图片
            Random rd = new Random();
            int i = rd.Next(1, 10000)%3;
            switch(i)
            {
                case 0: LoginBgi.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.Title2; break;
                case 1: LoginBgi.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.Title3; break;
                case 2: LoginBgi.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.Title4; break;
            }
        }

        //登陆按钮
        private void Login_Click(object sender, EventArgs e)
        {
            string userid2 = IdTextBox.Text;
            string password2 = PassWordTextBox.Text;
            MySqlDataReader reader = null;
            int i = 0;//判断用户名或者密码是否错误

            if (userid2 == "" || password2 == "")
            {
                ErrorsLabel.Text = "用户名或密码不能为空";
            }
            else 
            {
                string connStr = "server=" + serverip + ";user id=root; password=; database=wjylsystem; pooling=false";

                try
                {
                    //创建数据库链接
                    conn = new MySqlConnection(connStr);
                    conn.Open();
                    //数据库查询代码
                    cmd = new MySqlCommand("select * from userinfo where userid='" + userid2 + "' AND password='" + password2 + "'", conn);
                    //查询结果放到reader中
                    reader = cmd.ExecuteReader();
                    //读取reader内容
                    while (reader.Read())
                    {
                        i++;
                        userid = reader.GetString(0);
                        username = reader.GetString(1);
                        password = reader.GetString(2);
                        usertype = reader.GetString(3);
                        classname = reader.GetString(4);
                        logincount = reader.GetInt16(5);
                        zancount = reader.GetInt16(6);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("     服务器连接错误     ");
                    //MessageBox.Show("Error connecting to the server: " + ex.Message);
                }
                finally
                {
                    if (reader != null) reader.Close();
                    if (conn != null)conn.Close();
                    if (i == 0) ErrorsLabel.Text = "用户名或密码错误";
                    else
                    {
                        if (usertype != "admin")
                        {
                            MessageBox.Show("请用管理员帐号登录本客户端");
                            Application.Exit();
                        }
                        else
                        {
                            MainForm mainform = new MainForm();
                            //mainform.WindowState = FormWindowState.Maximized;//设置窗口最大化
                            mainform.Show();
                            this.Hide();                                                                                             
                        }
                    }
                }
            }
        }

        //右上角退出按钮
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //选中时清空文字并设置密码符号
        private void PassWordTextBox_Enter(object sender, EventArgs e)
        {
            ErrorsLabel.Text = "";
            PassWordTextBox.Text = "";
            PassWordTextBox.PasswordChar = '*';
        }

        //选中时清空Textbox中的文字
        private void IdTextBox_Enter(object sender, EventArgs e)
        {
            ErrorsLabel.Text = "";
            IdTextBox.Text = "";
        }

        //鼠标放到按钮上显示“关闭”
        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.CloseButton, "关闭");
        }

        //鼠标放到按钮上显示“设置服务器IP”
        private void SetIPButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.SetIPButton, "设置服务器IP");
        }

        //设置服务器IP
        private void SetIPButton_Click(object sender, EventArgs e)
        {
            SetIPForm setip = new SetIPForm();//初始化窗口
            setip.Show();
        }

        //服务器地址更新通知
        private void LoginForm_Activated(object sender, EventArgs e)
        {
            if (isChangeIP) ErrorsLabel.Text = "服务器地址已更新:" + serverip;
            isChangeIP = false;
        }

    }
}
