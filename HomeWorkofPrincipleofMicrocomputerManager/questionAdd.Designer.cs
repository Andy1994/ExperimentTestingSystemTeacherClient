namespace HomeWorkofPrincipleofMicrocomputerManager
{
    partial class questionAdd
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quesType = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.addPic = new System.Windows.Forms.Button();
            this.Bold = new System.Windows.Forms.Button();
            this.Italic = new System.Windows.Forms.Button();
            this.Underline = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题:";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(78, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(228, 26);
            this.title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "难度:";
            // 
            // scoreLevel
            // 
            this.scoreLevel.FormattingEnabled = true;
            this.scoreLevel.Items.AddRange(new object[] {
            "默认",
            "70",
            "80",
            "90",
            "100"});
            this.scoreLevel.Location = new System.Drawing.Point(78, 50);
            this.scoreLevel.Name = "scoreLevel";
            this.scoreLevel.Size = new System.Drawing.Size(50, 20);
            this.scoreLevel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(170, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "题目类型:";
            // 
            // quesType
            // 
            this.quesType.FormattingEnabled = true;
            this.quesType.Items.AddRange(new object[] {
            "问答题",
            "编程题"});
            this.quesType.Location = new System.Drawing.Point(246, 50);
            this.quesType.Name = "quesType";
            this.quesType.Size = new System.Drawing.Size(60, 20);
            this.quesType.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(5, 110);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(600, 380);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LimeGreen;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(19, 509);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 25);
            this.save.TabIndex = 8;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // addPic
            // 
            this.addPic.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.insertImage;
            this.addPic.FlatAppearance.BorderSize = 0;
            this.addPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPic.Location = new System.Drawing.Point(19, 81);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(25, 25);
            this.addPic.TabIndex = 9;
            this.addPic.UseVisualStyleBackColor = true;
            this.addPic.Click += new System.EventHandler(this.addPic_Click);
            // 
            // Bold
            // 
            this.Bold.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.bold2;
            this.Bold.FlatAppearance.BorderSize = 0;
            this.Bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bold.Location = new System.Drawing.Point(50, 81);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(25, 25);
            this.Bold.TabIndex = 10;
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.Italic;
            this.Italic.FlatAppearance.BorderSize = 0;
            this.Italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Italic.Location = new System.Drawing.Point(81, 81);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(25, 25);
            this.Italic.TabIndex = 11;
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.Underline;
            this.Underline.FlatAppearance.BorderSize = 0;
            this.Underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Underline.Location = new System.Drawing.Point(112, 81);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(25, 25);
            this.Underline.TabIndex = 12;
            this.Underline.UseVisualStyleBackColor = true;
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // questionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.Italic);
            this.Controls.Add(this.Bold);
            this.Controls.Add(this.addPic);
            this.Controls.Add(this.save);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.quesType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "questionAdd";
            this.Size = new System.Drawing.Size(610, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scoreLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox quesType;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button addPic;
        private System.Windows.Forms.Button Bold;
        private System.Windows.Forms.Button Italic;
        private System.Windows.Forms.Button Underline;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
