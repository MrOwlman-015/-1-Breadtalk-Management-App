namespace QuanLyBanHang
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNameAccount = new System.Windows.Forms.TextBox();
            this.labelNameAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.labelMK = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogin_Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNameAccount);
            this.panel1.Controls.Add(this.labelNameAccount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 130);
            this.panel1.TabIndex = 0;
            // 
            // txtNameAccount
            // 
            this.txtNameAccount.Location = new System.Drawing.Point(370, 50);
            this.txtNameAccount.Name = "txtNameAccount";
            this.txtNameAccount.Size = new System.Drawing.Size(502, 31);
            this.txtNameAccount.TabIndex = 1;
            // 
            // labelNameAccount
            // 
            this.labelNameAccount.AutoSize = true;
            this.labelNameAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameAccount.Location = new System.Drawing.Point(131, 45);
            this.labelNameAccount.Name = "labelNameAccount";
            this.labelNameAccount.Size = new System.Drawing.Size(233, 36);
            this.labelNameAccount.TabIndex = 0;
            this.labelNameAccount.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng nhập";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(21, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 103);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtPassWord);
            this.panel3.Controls.Add(this.labelMK);
            this.panel3.Location = new System.Drawing.Point(12, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 130);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(21, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 100);
            this.panel4.TabIndex = 3;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(370, 50);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(502, 31);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMK.Location = new System.Drawing.Point(131, 45);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(161, 36);
            this.labelMK.TabIndex = 0;
            this.labelMK.Text = "Mật khẩu:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(523, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Đăng nhập";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin_Exit
            // 
            this.btnLogin_Exit.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_Exit.Location = new System.Drawing.Point(713, 402);
            this.btnLogin_Exit.Name = "btnLogin_Exit";
            this.btnLogin_Exit.Size = new System.Drawing.Size(171, 56);
            this.btnLogin_Exit.TabIndex = 4;
            this.btnLogin_Exit.Text = "Thoát";
            this.btnLogin_Exit.UseVisualStyleBackColor = true;
            this.btnLogin_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 521);
            this.Controls.Add(this.btnLogin_Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNameAccount;
        private System.Windows.Forms.Label labelNameAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLogin_Exit;
    }
}