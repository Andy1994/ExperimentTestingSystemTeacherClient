namespace HomeWorkofPrincipleofMicrocomputerManager
{
    partial class SetIPForm
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
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComfirmSetIpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IPTextBox.Location = new System.Drawing.Point(50, 40);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(200, 21);
            this.IPTextBox.TabIndex = 0;
            this.IPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器IP地址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComfirmSetIpButton
            // 
            this.ComfirmSetIpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComfirmSetIpButton.FlatAppearance.BorderSize = 0;
            this.ComfirmSetIpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComfirmSetIpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComfirmSetIpButton.Location = new System.Drawing.Point(50, 77);
            this.ComfirmSetIpButton.Name = "ComfirmSetIpButton";
            this.ComfirmSetIpButton.Size = new System.Drawing.Size(200, 25);
            this.ComfirmSetIpButton.TabIndex = 5;
            this.ComfirmSetIpButton.Text = "确定";
            this.ComfirmSetIpButton.UseVisualStyleBackColor = false;
            this.ComfirmSetIpButton.Click += new System.EventHandler(this.ComfirmSetIpButton_Click);
            // 
            // SetIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(300, 130);
            this.Controls.Add(this.ComfirmSetIpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetIPForm";
            this.Text = "设置服务器地址";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SetIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComfirmSetIpButton;
    }
}