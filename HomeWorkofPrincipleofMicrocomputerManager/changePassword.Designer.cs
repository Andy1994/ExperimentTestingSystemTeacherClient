namespace HomeWorkofPrincipleofMicrocomputerManager
{
    partial class changePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePassword));
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newPasswordConfirm = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPassword
            // 
            this.oldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldPassword.Location = new System.Drawing.Point(50, 30);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(200, 21);
            this.oldPassword.TabIndex = 1;
            this.oldPassword.Text = "原密码";
            this.oldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPassword.Enter += new System.EventHandler(this.oldPassword_Enter);
            // 
            // newPassword
            // 
            this.newPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassword.Location = new System.Drawing.Point(50, 69);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(200, 21);
            this.newPassword.TabIndex = 2;
            this.newPassword.Text = "新密码";
            this.newPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPassword.Enter += new System.EventHandler(this.newPassword_Enter);
            // 
            // newPasswordConfirm
            // 
            this.newPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPasswordConfirm.Location = new System.Drawing.Point(50, 107);
            this.newPasswordConfirm.Name = "newPasswordConfirm";
            this.newPasswordConfirm.Size = new System.Drawing.Size(200, 21);
            this.newPasswordConfirm.TabIndex = 3;
            this.newPasswordConfirm.Text = "新密码确认";
            this.newPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.LimeGreen;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Submit.Location = new System.Drawing.Point(50, 146);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(200, 25);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "确定";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(300, 202);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.newPasswordConfirm);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changePassword";
            this.Text = "密码修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox newPasswordConfirm;
        private System.Windows.Forms.Button Submit;
    }
}