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
    public partial class questionAdd : UserControl
    {
        private MySqlConnection conn;

        public questionAdd()
        {
            InitializeComponent();
            quesType.SelectedIndex = 0;
            scoreLevel.SelectedIndex = 0;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (title.Text == "")
            {
                MessageBox.Show("     标题不能为空     ");
                return;
            }

            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8", LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

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

                string sql = "insert into questiontable(title,questype,difficulty,content,answer) values('"+title.Text+"','"+quesType.Text+"','"+scoreLevel.Text+"',?data,'NULL')";
                //string sql = "update questiontable set title='" + title.Text + "' where questionID = " + MainForm.questionShowID + "";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("?data", MySql.Data.MySqlClient.MySqlDbType.LongBlob, blob.Length).Value = blob;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ms.Close();

                MessageBox.Show("     问题添加成功!     ");

                //控件恢复
                title.Text = "";
                richTextBox1.Text = "";
                scoreLevel.SelectedIndex = 0;
                quesType.SelectedIndex = 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png|bmp文件(*.bmp)|*.bmp|ico文件(*.ico)|*.ico";
            openFileDialog1.Title = "打开图片";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Clipboard.SetDataObject(Image.FromFile(openFileDialog1.FileName), false);
                richTextBox1.Paste();
            }
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            Font oldFont = this.richTextBox1.SelectionFont;
            Font newFont;
            if (oldFont.Bold)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus(); 
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Font oldFont = this.richTextBox1.SelectionFont;
            Font newFont;
            if (oldFont.Italic)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus(); 
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Font oldFont = this.richTextBox1.SelectionFont;
            Font newFont;
            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus(); 
        }
    }
}
