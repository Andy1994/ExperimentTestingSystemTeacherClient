﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public deleteClass deleteclass;
        public addTeacher addteacher;
        public deleteTeacher deleteteacher;
        public questionShow questionshow;
        public questionAdd questionadd;
        public studentAnswer studentanswer;
        public addPaper addpaper;
        public TestSetting testsetting;

        Button ButtonTag;
        public static int answerShowID;
        public static int questionShowID;
        public static int refresh;

        private MySqlConnection conn;
        int Button1ClickFlag = 0;
        int Button2ClickFlag = 0;

        bool isFirstAddQuestion = true;

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
            unDisplayStudentButton();

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
            unDisplayStudentButton();

            button21.Text = "题目浏览";
            button22.Text = "题目添加";
            button23.Text = "试卷添加";
            button24.Text = "试卷设置";
            unDisplayButton(2, 4);
        }


        private void button13_Click(object sender, EventArgs e)
        {
            TimeStatus.Text = button13.Text;
            Button1ClickFlag = 3;
            unDisplay23Button();
            unDisplayStudentButton();

            addStudentInPanel2(1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TimeStatus.Text = button14.Text;
            Button1ClickFlag = 4;
            unDisplay23Button();
            unDisplayStudentButton();

            addStudentInPanel2(2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            TimeStatus.Text = button15.Text;
            Button1ClickFlag = 5;
            unDisplay23Button();
            unDisplayStudentButton();

            addStudentInPanel2(3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TimeStatus.Text = button16.Text;
            Button1ClickFlag = 6;
            unDisplay23Button();
            unDisplayStudentButton();

            addStudentInPanel2(4);
        }

        void unDisplayStudentButton()
        {
            for (int i = 1; i <= 7; i++)
            {
                foreach (Control con in splitContainer2.Panel1.Controls)
                {
                    if (con.Name != "button21")
                    {
                        if (con.Name != "button22")
                        {
                            if (con.Name != "button23")
                            {
                                if (con.Name != "button24")
                                {
                                    splitContainer2.Panel1.Controls.Remove(con);
                                }
                                continue;
                            }
                            continue;
                        }
                        continue;
                    }
                }
            }
        }

        void unDisplayButton(int k,int i)
        {
            int jc = 0;
            foreach (Control con in splitContainer2.Panel1.Controls)
            {
                jc++;
            }
            if (jc<11 && splitContainer2.SplitterDistance > 165)
            {
                splitContainer2.SplitterDistance -= 15;
            }

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
                    else con.Visible = false; 
                    //splitContainer3.Panel1.Controls.Remove(con);
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
            //学生添加删除
            if (Button1ClickFlag == 1)
            {
                button31.Text = "学生添加";
                button32.Text = "学生删除";
                unDisplayButton(3, 2);
                if (splitContainer3.SplitterDistance == 175) splitContainer3.SplitterDistance -= 15;
            }
            //问题浏览
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
            //班级添加删除
            if (Button1ClickFlag == 1)
            {
                button31.Text = "班级添加";
                button32.Text = "班级删除";
                unDisplayButton(3, 2);
                if (splitContainer3.SplitterDistance == 175) splitContainer3.SplitterDistance -= 15;
            }
            //添加问题
            else if (Button1ClickFlag == 2)
            {
                unDisplayButton(3, 0);
                questionadd = new questionAdd();
                panel2.Visible = true;
                panel2.Controls.Clear();
                panel2.Controls.Add(questionadd);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button2ClickFlag = 3;
            //教师添加删除
            if (Button1ClickFlag == 1)
            {
                button31.Text = "教师添加";
                button32.Text = "教师删除";
                unDisplayButton(3, 2);
                if (splitContainer3.SplitterDistance == 175) splitContainer3.SplitterDistance -= 15;
            }
            //试卷添加
            else if (Button1ClickFlag == 2)
            {
                unDisplayButton(3, 0);
                addQuestionInPanel3();
                isFirstAddQuestion = true;

                panel2.Visible = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Button1ClickFlag == 2)
            {
                unDisplayButton(3, 0);
                testsetting = new TestSetting();
                panel2.Visible = true;
                panel2.Controls.Clear();
                panel2.Controls.Add(testsetting);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Button1ClickFlag == 1)
            {
                if (Button2ClickFlag == 1)
                {
                    addstudent = new addStudent();
                    panel2.Visible = true;
                    panel2.Controls.Clear();
                    panel2.Controls.Add(addstudent);
                }
                else if (Button2ClickFlag == 2)
                {
                    addclass = new addClass();
                    panel2.Visible = true;
                    panel2.Controls.Clear();
                    panel2.Controls.Add(addclass);
                }
                else if (Button2ClickFlag == 3)
                {
                    addteacher = new addTeacher();
                    panel2.Visible = true;
                    panel2.Controls.Clear();
                    panel2.Controls.Add(addteacher);
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
                    panel2.Visible = true;
                    panel2.Controls.Clear();
                    panel2.Controls.Add(deletestudent);
                }
                else if (Button2ClickFlag == 2)
                {
                    deleteclass = new deleteClass();
                    panel2.Visible = true;
                    panel2.Controls.Clear();
                    panel2.Controls.Add(deleteclass);
                }
                else if (Button2ClickFlag == 3)
                {
                    deleteteacher = new deleteTeacher();
                    panel2.Visible = true;
                    panel2.Controls.Clear();
                    panel2.Controls.Add(deleteteacher);
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
                    addQuestionButton(LocationFlag, buttonName, questionID, 0 ,0, null);
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

        void addQuestionButton(int i, string title, int qID, int aID, int flag, string id)
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

            if (flag == 0)
            {
                if (aID == 0)
                {
                    buttonX.Text = title;
                    buttonX.Tag = qID;//为button添加Tag
                    if (Button2ClickFlag == 3) buttonX.Click += new EventHandler(this.addQuestionToPaper_Click);//添加试卷
                    else buttonX.Click += new EventHandler(this.questionshow_Click);//问题详情
                }
                else
                {
                    //添加学生回答按钮
                    if (id == "green") buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(240)))));
                    buttonX.Text = title;
                    buttonX.Tag = aID;
                    buttonX.Click += new EventHandler(this.showAnswerDetail_Click);
                }
                splitContainer3.Panel1.Controls.Add(buttonX);
            }
            else if (flag == 1)
            {
                buttonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
                
                buttonX.Text = title;
                buttonX.Tag = id;
                buttonX.Click += new EventHandler(this.studentAnswerShow_Click);
                splitContainer2.Panel1.Controls.Add(buttonX);
            }
        }

        private void addQuestionToPaper_Click(object sender, EventArgs e)
        {
            //获取按钮Tag
            ButtonTag = (Button)sender;

            if (isFirstAddQuestion)
            {
                richTextBox1.Text += ButtonTag.Tag.ToString() + "," + ButtonTag.Text;
                isFirstAddQuestion = false;
            }
            else richTextBox1.Text += ","+ ButtonTag.Tag.ToString() + "," + ButtonTag.Text;

            //点击之后按钮背景色改变
            ButtonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            panel2.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(questionshow);
        }

        void addStudentInPanel2(int i)
        {
            int LocationFlag = 1;
            string className = null;
            if (i == 1) className = button13.Text;
            else if (i == 2) className = button14.Text;
            else if (i == 3) className = button15.Text;
            else if (i == 4) className = button16.Text;

            MySqlCommand cmd;
            MySqlDataReader reader = null;
            string sql = "select * from userinfo where classname='"+ className +"' order by xuhao";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string username = reader.GetString(1);
                    int xuhao = reader.GetInt32(7);
                    addQuestionButton(LocationFlag, username+" "+xuhao.ToString(), 0, 0, 1, id);
                    LocationFlag++;
                }
                //有题目显示出来，判断数量，决定要不要改变SplitterDistance
                if (LocationFlag != 1)
                {
                    if (this.Width == 1100 && LocationFlag > 11 && splitContainer2.SplitterDistance < 165)
                    {
                        splitContainer2.SplitterDistance += 15;
                    }
                    else if (this.Width > 1100 && LocationFlag > 16 && splitContainer2.SplitterDistance < 165)
                    {
                        splitContainer2.SplitterDistance += 15;
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

        private void studentAnswerShow_Click(object sender, EventArgs e)
        {
            //恢复原来背景色
            if (ButtonTag != null) ButtonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            //获取按钮Tag
            ButtonTag = (Button)sender;
            string userid = (string)(ButtonTag.Tag);
            TimeStatus.Text = ButtonTag.Text + " " + userid;
            //点击之后按钮背景色改变
            ButtonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));

            unDisplayButton(3, 0);//清空

            int LocationFlag = 1;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            string sql = "select * from answertable where userid='"+userid+"' order by answerID desc";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int aID = reader.GetInt32(0);
                    string title = reader.GetString(4);
                    string time = reader.GetString(2);
                    int correcting = reader.GetInt32(7);
                    if (correcting == 0)
                    {
                        addQuestionButton(LocationFlag, title + " " + time, 0, aID, 0, null);
                    }
                    else addQuestionButton(LocationFlag, title + " " + time, 0, aID, 0, "green");
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

        private void showAnswerDetail_Click(object sender, EventArgs e)
        {
            //恢复原来背景色
            if (ButtonTag != null) ButtonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            //获取按钮Tag
            ButtonTag = (Button)sender;
            answerShowID = (int)(ButtonTag.Tag);
            //点击之后按钮背景色改变
            ButtonTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));

            studentanswer = new studentAnswer();
            panel2.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(studentanswer);
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            changePassword changepassword = new changePassword();
            changepassword.Show();
        }

        private void submitpaper_Click(object sender, EventArgs e)
        {
            if (paperTitle.Text == "")
            {
                MessageBox.Show("     试卷标题不能为空!     ");
                return;
            }
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("     试卷不能为空,点击左侧题目按钮添加!     ");
                return;
            }
            string time = DateTime.Now.ToString("yyyy-MM-dd");

            MySqlCommand cmd;
            try
            {
                string sql = "insert into papertable(teacherName,paperName,questionArray,time) values('"+LoginForm.username+"','"+paperTitle.Text+"','"+richTextBox1.Text+"','"+time+"')";
                cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("     试卷添加成功!     ");

                //控件恢复
                paperTitle.Text = "";
                richTextBox1.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
