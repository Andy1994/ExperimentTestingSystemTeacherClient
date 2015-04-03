using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace HomeWorkofPrincipleofMicrocomputerManager
{
    public partial class studentAnswer : UserControl
    {
        private MySqlConnection conn;
        string qID = null;
        
        public studentAnswer()
        {
            InitializeComponent();
        }

        private void studentAnswer_Load(object sender, EventArgs e)
        {
            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8", LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

            //显示回答
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            byte[] blob = null;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("select * from answertable where answerID = " + MainForm.answerShowID + "", conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                qID = reader.GetString(3);
                title.Text = reader.GetString(4);
                int isCorrecting = reader.GetInt32(7);
                if (isCorrecting == 1)
                {
                    scoreBox.Text = reader.GetInt32(6).ToString();
                    comments.Text = reader.GetString(8);
                    int radio = reader.GetInt32(9);
                    if (radio == 1) zan.Checked = true;
                }

                //显示回答内容
                long len = reader.GetBytes(5, 0, null, 0, 0);
                blob = new byte[len];
                len = reader.GetBytes(5, 0, blob, 0, (int)len);
                MemoryStream ms = new MemoryStream(blob, false);
                richTextBox2.LoadFile(ms, RichTextBoxStreamType.RichText);

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

            //显示问题
            byte[] blob2 = null;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("select * from questiontable where questionID = '" + qID + "'", conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                Level.Text = reader.GetString(3);
                Type.Text = reader.GetString(2);

                //显示题目内容
                long len = reader.GetBytes(4, 0, null, 0, 0);
                blob2 = new byte[len];
                len = reader.GetBytes(4, 0, blob2, 0, (int)len);
                MemoryStream ms = new MemoryStream(blob2, false);
                richTextBox1.LoadFile(ms, RichTextBoxStreamType.RichText);

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

        private void submit_Click(object sender, EventArgs e)
        {
            if (scoreBox.Text == "")
            {
                MessageBox.Show("     分数不能为空!     ");
                return;
            }

            MySqlCommand cmd;
            try
            {
                int isZan = 0;
                if (zan.Checked) isZan = 1;
                int score = int.Parse(scoreBox.Text);

                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("update answertable set score="+score+",correcting=1,comments='"+comments.Text+"',zan="+isZan+" where answerID='"+MainForm.answerShowID+"'", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("     批改成功!     ");
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
