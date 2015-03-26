namespace HomeWorkofPrincipleofMicrocomputerManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonPractice = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonDocument = new System.Windows.Forms.Button();
            this.ButtonLevel100 = new System.Windows.Forms.Button();
            this.ButtonLevel95 = new System.Windows.Forms.Button();
            this.ButtonLevel80 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.开始NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.继续CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TimeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.QianDaoCount = new System.Windows.Forms.Label();
            this.MyInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPractice
            // 
            this.ButtonPractice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonPractice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonPractice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ButtonPractice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.ButtonPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPractice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonPractice.Location = new System.Drawing.Point(5, 5);
            this.ButtonPractice.Name = "ButtonPractice";
            this.ButtonPractice.Size = new System.Drawing.Size(190, 50);
            this.ButtonPractice.TabIndex = 1;
            this.ButtonPractice.Text = "练 习";
            this.ButtonPractice.UseVisualStyleBackColor = false;
            this.ButtonPractice.Click += new System.EventHandler(this.PracticeButton_Click);
            this.ButtonPractice.MouseEnter += new System.EventHandler(this.ButtonPractice_MouseEnter);
            this.ButtonPractice.MouseLeave += new System.EventHandler(this.ButtonPractice_MouseLeave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.splitContainer1.Panel1.Controls.Add(this.ButtonDocument);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonLevel100);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonLevel95);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonLevel80);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonPractice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(990, 571);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // ButtonDocument
            // 
            this.ButtonDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonDocument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonDocument.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ButtonDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.ButtonDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDocument.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonDocument.Location = new System.Drawing.Point(5, 225);
            this.ButtonDocument.Name = "ButtonDocument";
            this.ButtonDocument.Size = new System.Drawing.Size(190, 50);
            this.ButtonDocument.TabIndex = 5;
            this.ButtonDocument.Text = "文档查看";
            this.ButtonDocument.UseVisualStyleBackColor = false;
            this.ButtonDocument.MouseEnter += new System.EventHandler(this.ButtonDocument_MouseEnter);
            this.ButtonDocument.MouseLeave += new System.EventHandler(this.ButtonDocument_MouseLeave);
            // 
            // ButtonLevel100
            // 
            this.ButtonLevel100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonLevel100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonLevel100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ButtonLevel100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.ButtonLevel100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLevel100.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLevel100.Location = new System.Drawing.Point(5, 170);
            this.ButtonLevel100.Name = "ButtonLevel100";
            this.ButtonLevel100.Size = new System.Drawing.Size(190, 50);
            this.ButtonLevel100.TabIndex = 4;
            this.ButtonLevel100.Text = "测试 100分题目";
            this.ButtonLevel100.UseVisualStyleBackColor = false;
            this.ButtonLevel100.MouseEnter += new System.EventHandler(this.ButtonLevel100_MouseEnter);
            this.ButtonLevel100.MouseLeave += new System.EventHandler(this.ButtonLevel100_MouseLeave);
            // 
            // ButtonLevel95
            // 
            this.ButtonLevel95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonLevel95.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonLevel95.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ButtonLevel95.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.ButtonLevel95.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLevel95.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLevel95.Location = new System.Drawing.Point(5, 115);
            this.ButtonLevel95.Name = "ButtonLevel95";
            this.ButtonLevel95.Size = new System.Drawing.Size(190, 50);
            this.ButtonLevel95.TabIndex = 3;
            this.ButtonLevel95.Text = "测试 95分题目";
            this.ButtonLevel95.UseVisualStyleBackColor = false;
            this.ButtonLevel95.MouseEnter += new System.EventHandler(this.ButtonLevel95_MouseEnter);
            this.ButtonLevel95.MouseLeave += new System.EventHandler(this.ButtonLevel95_MouseLeave);
            // 
            // ButtonLevel80
            // 
            this.ButtonLevel80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonLevel80.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonLevel80.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ButtonLevel80.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.ButtonLevel80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLevel80.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLevel80.Location = new System.Drawing.Point(5, 60);
            this.ButtonLevel80.Name = "ButtonLevel80";
            this.ButtonLevel80.Size = new System.Drawing.Size(190, 50);
            this.ButtonLevel80.TabIndex = 2;
            this.ButtonLevel80.Text = "测试 80分题目";
            this.ButtonLevel80.UseVisualStyleBackColor = false;
            this.ButtonLevel80.MouseEnter += new System.EventHandler(this.ButtonLevel80_MouseEnter);
            this.ButtonLevel80.MouseLeave += new System.EventHandler(this.ButtonLevel80_MouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "插入图片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(402, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 68);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始NToolStripMenuItem,
            this.继续CToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(990, 25);
            this.mainMenu.TabIndex = 6;
            this.mainMenu.Text = "menuStrip1";
            // 
            // 开始NToolStripMenuItem
            // 
            this.开始NToolStripMenuItem.Name = "开始NToolStripMenuItem";
            this.开始NToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.开始NToolStripMenuItem.Text = "开始(&N)";
            // 
            // 继续CToolStripMenuItem
            // 
            this.继续CToolStripMenuItem.Name = "继续CToolStripMenuItem";
            this.继续CToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.继续CToolStripMenuItem.Text = "继续(&C)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimeStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(990, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TimeStatus
            // 
            this.TimeStatus.AutoSize = false;
            this.TimeStatus.Name = "TimeStatus";
            this.TimeStatus.Size = new System.Drawing.Size(600, 17);
            this.TimeStatus.Text = "StatusLabel1";
            this.TimeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BodyPanel);
            this.MainPanel.Controls.Add(this.InfoPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(990, 621);
            this.MainPanel.TabIndex = 9;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.splitContainer1);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 50);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(990, 571);
            this.BodyPanel.TabIndex = 7;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.pictureBox1);
            this.InfoPanel.Controls.Add(this.ExitButton);
            this.InfoPanel.Controls.Add(this.QianDaoCount);
            this.InfoPanel.Controls.Add(this.MyInfoButton);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(990, 50);
            this.InfoPanel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(184, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.exit;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.Location = new System.Drawing.Point(98, 7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 36);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "退 出";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // QianDaoCount
            // 
            this.QianDaoCount.AutoSize = true;
            this.QianDaoCount.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QianDaoCount.Location = new System.Drawing.Point(215, 18);
            this.QianDaoCount.Name = "QianDaoCount";
            this.QianDaoCount.Size = new System.Drawing.Size(77, 14);
            this.QianDaoCount.TabIndex = 8;
            this.QianDaoCount.Text = "签到: 0 次";
            // 
            // MyInfoButton
            // 
            this.MyInfoButton.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.head_logo;
            this.MyInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.MyInfoButton.FlatAppearance.BorderSize = 0;
            this.MyInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.MyInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MyInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyInfoButton.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MyInfoButton.Location = new System.Drawing.Point(7, 7);
            this.MyInfoButton.Name = "MyInfoButton";
            this.MyInfoButton.Size = new System.Drawing.Size(85, 36);
            this.MyInfoButton.TabIndex = 7;
            this.MyInfoButton.Text = "ID info";
            this.MyInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyInfoButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(990, 668);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "微机原理实验考核系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPractice;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem 开始NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 继续CToolStripMenuItem;
        private System.Windows.Forms.Button MyInfoButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TimeStatus;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Label QianDaoCount;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ButtonLevel80;
        private System.Windows.Forms.Button ButtonLevel100;
        private System.Windows.Forms.Button ButtonLevel95;
        private System.Windows.Forms.Button ButtonDocument;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}