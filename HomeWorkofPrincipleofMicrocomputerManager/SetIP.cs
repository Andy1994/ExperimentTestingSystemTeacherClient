using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeWorkofPrincipleofMicrocomputerManager
{
    public partial class SetIPForm : Form
    {
        public SetIPForm()
        {
            StartPosition = FormStartPosition.CenterScreen;//窗口初始位置为屏幕中间
            InitializeComponent();
        }

        //读取serverIP并在TextBox中显示
        private void SetIP_Load(object sender, EventArgs e)
        {
            IPTextBox.Text = LoginForm.serverip;
        }

        //点击确认按钮重新设置IP，窗口隐藏
        private void ComfirmSetIpButton_Click(object sender, EventArgs e)
        {
            LoginForm.serverip = IPTextBox.Text;
            LoginForm.isChangeIP = true;
            this.Hide();
        }
    }
}
