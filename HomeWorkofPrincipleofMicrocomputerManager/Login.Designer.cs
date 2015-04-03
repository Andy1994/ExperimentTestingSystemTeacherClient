namespace HomeWorkofPrincipleofMicrocomputerManager
{
    partial class LoginForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.SetIPButton = new System.Windows.Forms.Button();
            this.LoginBgi = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBgi)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(81)))), ((int)(((byte)(55)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(0, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(380, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.Location = new System.Drawing.Point(100, 290);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(200, 25);
            this.Login.TabIndex = 4;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdTextBox.Location = new System.Drawing.Point(100, 230);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(200, 21);
            this.IdTextBox.TabIndex = 5;
            this.IdTextBox.Text = "用户名";
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IdTextBox.Enter += new System.EventHandler(this.IdTextBox_Enter);
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWordTextBox.Location = new System.Drawing.Point(100, 260);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(200, 21);
            this.PassWordTextBox.TabIndex = 6;
            this.PassWordTextBox.Text = "密码";
            this.PassWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassWordTextBox.Enter += new System.EventHandler(this.PassWordTextBox_Enter);
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(81)))), ((int)(((byte)(55)))));
            this.ErrorsLabel.Location = new System.Drawing.Point(100, 319);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(200, 23);
            this.ErrorsLabel.TabIndex = 7;
            this.ErrorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetIPButton
            // 
            this.SetIPButton.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.setting;
            this.SetIPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetIPButton.FlatAppearance.BorderSize = 0;
            this.SetIPButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.SetIPButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(227)))), ((int)(((byte)(219)))));
            this.SetIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetIPButton.Location = new System.Drawing.Point(0, 310);
            this.SetIPButton.Name = "SetIPButton";
            this.SetIPButton.Size = new System.Drawing.Size(40, 40);
            this.SetIPButton.TabIndex = 8;
            this.SetIPButton.UseVisualStyleBackColor = true;
            this.SetIPButton.Click += new System.EventHandler(this.SetIPButton_Click);
            this.SetIPButton.MouseHover += new System.EventHandler(this.SetIPButton_MouseHover);
            // 
            // LoginBgi
            // 
            this.LoginBgi.BackgroundImage = global::HomeWorkofPrincipleofMicrocomputerManager.Properties.Resources.Title2;
            this.LoginBgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBgi.Location = new System.Drawing.Point(0, 0);
            this.LoginBgi.Name = "LoginBgi";
            this.LoginBgi.Size = new System.Drawing.Size(400, 200);
            this.LoginBgi.TabIndex = 2;
            this.LoginBgi.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.SetIPButton);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginBgi);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginBgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox LoginBgi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Label ErrorsLabel;
        private System.Windows.Forms.Button SetIPButton;

    }
}

