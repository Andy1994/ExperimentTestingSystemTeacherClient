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
    public partial class TestSetting : UserControl
    {
        private MySqlConnection conn;
        public TestSetting()
        {
            InitializeComponent();
        }

        private void TestSetting_Load(object sender, EventArgs e)
        {
            //教师码取得
            textBox9.Text = LoginForm.classname;

            string connStr = String.Format("server={0};user id=root; password=; database=wjylsystem; pooling=false; Charset=utf8", LoginForm.serverip);
            //创建数据库链接
            conn = new MySqlConnection(connStr);

            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("select * from testsetting", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string level = reader.GetString(0);
                    if (level == "100")
                    {
                        textBox4.Text = reader.GetInt32(1).ToString();
                        textBox8.Text = reader.GetInt32(2).ToString();
                    }
                    else if (level == "90")
                    {
                        textBox3.Text = reader.GetInt32(1).ToString();
                        textBox7.Text = reader.GetInt32(2).ToString();
                    }
                    else if (level == "80")
                    {
                        textBox2.Text = reader.GetInt32(1).ToString();
                        textBox6.Text = reader.GetInt32(2).ToString();
                    }
                    else if (level == "70")
                    {
                        textBox1.Text = reader.GetInt32(1).ToString();
                        textBox5.Text = reader.GetInt32(2).ToString();
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

        private void submit_Click(object sender, EventArgs e)
        {
            LoginForm.classname = textBox9.Text;
            MySqlCommand cmd;
            try
            {
                conn.Open();
                //数据库查询代码
                cmd = new MySqlCommand("update testsetting set number="+int.Parse(textBox1.Text)+",minutes="+int.Parse(textBox5.Text)+" where level='70'", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("update testsetting set number=" + int.Parse(textBox2.Text) + ",minutes=" + int.Parse(textBox6.Text) + " where level='80'", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("update testsetting set number=" + int.Parse(textBox3.Text) + ",minutes=" + int.Parse(textBox7.Text) + " where level='90'", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("update testsetting set number=" + int.Parse(textBox4.Text) + ",minutes=" + int.Parse(textBox8.Text) + " where level='100'", conn);
                cmd.ExecuteNonQuery();
                cmd = new MySqlCommand("update userinfo set classname='" + textBox9.Text + "' where userid='" + LoginForm.userid + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("     更改成功!     ");
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
