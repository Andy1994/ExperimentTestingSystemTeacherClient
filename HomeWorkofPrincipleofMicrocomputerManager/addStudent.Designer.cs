namespace HomeWorkofPrincipleofMicrocomputerManager
{
    partial class addStudent
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
            this.xuhaoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.classBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号:";
            // 
            // xuhaoBox
            // 
            this.xuhaoBox.Location = new System.Drawing.Point(98, 127);
            this.xuhaoBox.Name = "xuhaoBox";
            this.xuhaoBox.Size = new System.Drawing.Size(140, 21);
            this.xuhaoBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(98, 46);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(140, 21);
            this.nameBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(50, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "专业班级:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(98, 19);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(140, 21);
            this.idBox.TabIndex = 1;
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(98, 100);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(140, 21);
            this.classBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "班内序号:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(98, 73);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(140, 21);
            this.passBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LimeGreen;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(98, 154);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(140, 23);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "提交";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xuhaoBox);
            this.Controls.Add(this.label1);
            this.Name = "addStudent";
            this.Size = new System.Drawing.Size(610, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuhaoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}
