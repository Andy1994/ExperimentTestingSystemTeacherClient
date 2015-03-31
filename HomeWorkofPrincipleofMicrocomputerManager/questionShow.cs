using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace HomeWorkofPrincipleofMicrocomputerManager
{
    public partial class questionShow : UserControl
    {
        private MySqlConnection conn;

        public questionShow()
        {
            InitializeComponent();
        }

        private void questionShow_Load(object sender, EventArgs e)
        {
            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8", LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

            MySqlCommand cmd;
            MySqlDataReader reader = null;
            byte[] blob = null;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("select * from questiontable where questionID = "+ MainForm.questionShowID +"", conn);
                reader = cmd.ExecuteReader();
                reader.Read();
                title.Text = reader.GetString(1);
                string type = reader.GetString(2);
                string diff = reader.GetString(3);
                //显示题目内容
                long len = reader.GetBytes(4, 0, null, 0, 0);
                blob = new byte[len];
                len = reader.GetBytes(4, 0, blob, 0, (int)len);
                MemoryStream ms = new MemoryStream(blob, false);
                richTextBox1.LoadFile(ms, RichTextBoxStreamType.RichText);

                if (type == "问答题") quesType.SelectedIndex = 0;
                else quesType.SelectedIndex = 1;

                if (diff == "80") scoreLevel.SelectedIndex = 1;
                else if (diff == "95") scoreLevel.SelectedIndex = 2;
                else if(diff == "100") scoreLevel.SelectedIndex = 3;
                else scoreLevel.SelectedIndex = 0;
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

        private void save_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                //建立内存流
                MemoryStream ms = new MemoryStream();
                ms.Position = 0;
                //把当前的richtextbox内容包括图片和文本保存到流中  
                richTextBox1.SaveFile(ms, RichTextBoxStreamType.RichText);
                ms.Position = 0;
                //将内存流储存为byte
                byte[] blob = new byte[ms.Length];
                ms.Read(blob, 0, blob.Length);
                
                string sql = "update questiontable set title='"+title.Text+"',questype='"+quesType.Text+"',difficulty='"+scoreLevel.Text+"',content = ?data where questionID = "+MainForm.questionShowID+"";
                //string sql = "update questiontable set title='" + title.Text + "' where questionID = " + MainForm.questionShowID + "";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("?data", MySql.Data.MySqlClient.MySqlDbType.LongBlob, blob.Length).Value = blob;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ms.Close();

                MessageBox.Show("     问题修改成功!     ");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            try
            {
                string sql = "delete from questiontable where questionID = "+MainForm.questionShowID+"";
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("     问题删除成功!     ");

                this.Visible = false;

                //刷新题目列表
                //MainForm.refresh = 1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
