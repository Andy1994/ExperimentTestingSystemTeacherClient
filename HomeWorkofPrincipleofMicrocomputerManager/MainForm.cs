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
        public addStudent addstudent;//定义学生添加控件
        public deleteStudent deletestudent;
        public addClass addclass;
        public addTeacher addteacher;
        public deleteTeacher deleteteacher;
        public questionShow questionshow;

        Button ButtonTag;
        public static int questionShowID;
        public static int refresh;

        private MySqlConnection conn;
        int Button1ClickFlag = 0;
        int Button2ClickFlag = 0;

        public MainForm()
        {
            StartPosition = FormStartPosition.CenterScreen;//窗口初始位置为屏幕中间
            InitializeComponent();
            //TimeStatus.Text = String.Format("用户ID：{0} 密码：{1} 用户类型：{2} 专业：{3} 登录次数：{4} 点赞数量：{5}", LoginForm.userid, LoginForm.password, LoginForm.usertype, LoginForm.classname, LoginForm.logincount, LoginForm.zancount);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MyInfoButton.Text = LoginForm.username;//按钮Text改成用户名字
            TimeStatus.Text = "欢迎！" + LoginForm.username;
            unDisplay23Button();

            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8",
    LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

            int countClassNum = 0;
            MySqlDataReader reader = null;
            MySqlCommand cmd;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("select * from teacherinfo where teacherName='" + LoginForm.username + "'", conn);
                //查询结果放到reader中
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    countClassNum++;
                    if (countClassNum == 1) button13.Text = reader.GetString(2);
                    else if (countClassNum == 2) button14.Text = reader.GetString(2);
                    else if (countClassNum == 3) button15.Text = reader.GetString(2);
                    else if (countClassNum == 4) button16.Text = reader.GetString(2);
                }
                unDisplayButton(1, countClassNum+2);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }
        }

        void unDisplay23Button()
        {
            foreach (Control con in splitContainer2.Panel1.Controls) con.Visible = false;//按钮隐藏
            foreach (Control con in splitContainer3.Panel1.Controls) con.Visible = false;//按钮隐藏
        }

        //退出按钮关闭程序
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //点击关闭退出程序
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Button11_Click(object sender, EventArgs e)
        {
            TimeStatus.Text = button11.Text;
            Button1ClickFlag = 1;
            unDisplay23Button();

            button21.Text = "学生管理";
            button22.Text = "班级管理";
            button23.Text = "管理员管理";
            unDisplayButton(2,3);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            TimeStatus.Text = button12.Text;
            Button1ClickFlag = 2;
            unDisplay23Button();

            button21.Text = "题目浏览";
            button22.Text = "题目添加";
            button23.Text = "试卷添加";
            unDisplayButton(2, 3);
        }

        void unDisplayButton(int k,int i)
        {
            if (k == 1)
            {
                int j = 1;
                foreach (Control con in splitContainer1.Panel1.Controls)
                {
                    if (j <= (6 - i)) con.Visible = false;
                    else con.Visible = true;
                    j++;
                }
            }
            else if (k == 2)
            {
                int j = 1;
                foreach (Control con in splitContainer2.Panel1.Controls)
                {
                    if (j <= (4 - i)) con.Visible = false;
                    else con.Visible = true;
                    j++;
                }
            }
            else if (k == 3)
            {
                foreach (Control con in splitContainer3.Panel1.Controls)
                {
                    if (con.Name == "button31" || con.Name == "button32" || con.Name == "button33")
                    { 
                    }
                    else splitContainer3.Panel1.Controls.Remove(con);
                }
                if (i == 0)
                {
                    button31.Visible = false;
                    button32.Visible = false;
                    button33.Visible = false;
                }
                else if (i == 1)
                {
                    button31.Visible = true;
                    button32.Visible = false;
                    button33.Visible = false;
                }
                else if (i == 2)
                {
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = false;
                }
                else if (i == 3)
                {
                    button31.Visible = true;
                    button32.Visible = true;
                    button33.Visible = true;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button2ClickFlag = 1;
            if (Button1ClickFlag == 1)
            {
                button31.Text = "学生添加";
                button32.Text = "学生删除";
                unDisplayButton(3, 2);
                if (splitContainer3.SplitterDistance == 175) splitContainer3.SplitterDistance -= 15;
            }
            else if (Button1ClickFlag == 2)
            {
                unDisplayButton(3, 0);
                unDisplayButton(3, 0);
                addQuestionInPanel3();//在Panel3面板添加题目
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button2ClickFlag = 2;
            if (Button1ClickFlag == 1)
            {
                button31.Text = "班级添加";
                unDisplayButton(3, 1);
                if (splitContainer3.SplitterDistance == 175) splitContainer3.SplitterDistance -= 15;
            }
            else if (Button1ClickFlag == 2)
            {
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button2ClickFlag = 3;
            if (Button1ClickFlag == 1)
            {
                button31.Text = "教师添加";
                button32.Text = "教师删除";
                unDisplayButton(3, 2);
                if (splitContainer3.SplitterDistance == 175) splitContainer3.SplitterDistance -= 15;
            }
            else if (Button1ClickFlag == 2)
            {

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Button1ClickFlag == 2)
            {
 
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Button1ClickFlag == 1)
            {
                if (Button2ClickFlag == 1)
                {
                    addstudent = new addStudent();
                    splitContainer3.Panel2.Controls.Clear();
                    splitContainer3.Panel2.Controls.Add(addstudent);
                }
                else if (Button2ClickFlag == 2)
                {
                    addclass = new addClass();
                    splitContainer3.Panel2.Controls.Clear();
                    splitContainer3.Panel2.Controls.Add(addclass);
                }
                else if (Button2ClickFlag == 3)
                {
                    addteacher = new addTeacher();
                    splitContainer3.Panel2.Controls.Clear();
                    splitContainer3.Panel2.Controls.Add(addteacher);
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (Button1ClickFlag == 1)
            {
                if (Button2ClickFlag == 1)
                {
                    deletestudent = new deleteStudent();
                    splitContainer3.Panel2.Controls.Clear();
                    splitContainer3.Panel2.Controls.Add(deletestudent);
                }
                else if (Button2ClickFlag == 3)
                {
                    deleteteacher = new deleteTeacher();
                    splitContainer3.Panel2.Controls.Clear();
                    splitContainer3.Panel2.Controls.Add(deleteteacher);
                }
            }
        }
        void addQuestionInPanel3()
        {
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            int LocationFlag = 1;
            string buttonName = null;
            int questionID = 0;

            string sql = "select * from questiontable order by questionID desc";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    questionID = reader.GetInt32(0);
                    buttonName = reader.GetString(1);
                    addQuestionButton(LocationFlag, buttonName, questionID, 0);
                    LocationFlag++;
                }
                //有题目显示出来，判断数量，决定要不要改变SplitterDistance
                if (LocationFlag != 1)
                {
                    if (this.Width == 1100 && LocationFlag > 11 && splitContainer3.SplitterDistance < 165)
                    {
                        splitContainer3.SplitterDistance += 15;
                    }
                    else if (this.Width > 1100 && LocationFlag > 16 && splitContainer3.SplitterDistance < 165)
                    {
                        splitContainer3.SplitterDistance += 15;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }
        }

        void addQuestionButton(int i, string title, int qID, int aID)
        {
            System.Windows.Forms.Button buttonX = new Button();
            buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            buttonX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            buttonX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            buttonX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonX.FlatAppearance.BorderSize = 0;
            buttonX.Size = new System.Drawing.Size(150, 50);
            buttonX.Location = new System.Drawing.Point(5, 55 * (i - 1) + 5);

            if (aID == 0)
            {
                buttonX.Text = title;
                buttonX.Tag = qID;//为button添加Tag
                buttonX.Click += new EventHandler(this.questionshow_Click);//添加单击鼠标事件
            }
            else
            {
                buttonX.Text = qID.ToString() + " " + title;
                buttonX.Tag = aID;
                //buttonX.Click += new EventHandler(this.answerButton_Click);
            }
            splitContainer3.Panel1.Controls.Add(buttonX);
        }

        private void questionshow_Click(object sender, EventArgs e)
        {
            //恢复原来背景色
            if (ButtonTag != null) ButtonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            //获取按钮Tag
            ButtonTag = (Button)sender;
            questionShowID = (int)(ButtonTag.Tag);
            //点击之后按钮背景色改变
            ButtonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));

            questionshow = new questionShow();
            splitContainer3.Panel2.Controls.Clear();
            splitContainer3.Panel2.Controls.Add(questionshow);
        }
    }
}
