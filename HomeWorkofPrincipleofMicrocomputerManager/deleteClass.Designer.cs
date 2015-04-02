namespace HomeWorkofPrincipleofMicrocomputerManager
{
    partial class deleteClass
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
            this.label2 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.TextBox();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "要删除的班级名字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(106, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "教师姓名:";
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(182, 24);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(140, 21);
            this.className.TabIndex = 5;
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(182, 54);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(140, 21);
            this.teacherName.TabIndex = 6;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(182, 81);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(140, 23);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(328, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "(例: 计科1202)";
            // 
            // deleteClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.className);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "deleteClass";
            this.Size = new System.Drawing.Size(610, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label3;
    }
}
