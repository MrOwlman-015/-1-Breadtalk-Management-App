namespace QLBreadtalk
{
    partial class fNhanvien
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
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.pnl_search = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pnl_ID = new System.Windows.Forms.Panel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pnl_phone = new System.Windows.Forms.Panel();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.pnl_workshift = new System.Windows.Forms.Panel();
            this.lbl_workshift = new System.Windows.Forms.Label();
            this.txt_workshift = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_search.SuspendLayout();
            this.pnl_ID.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.pnl_phone.SuspendLayout();
            this.pnl_workshift.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_staff
            // 
            this.dgv_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(2, 105);
            this.dgv_staff.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowHeadersWidth = 82;
            this.dgv_staff.RowTemplate.Height = 33;
            this.dgv_staff.Size = new System.Drawing.Size(646, 548);
            this.dgv_staff.TabIndex = 2;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Location = new System.Drawing.Point(695, 488);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 84);
            this.panel1.TabIndex = 3;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Xoa.Location = new System.Drawing.Point(267, 13);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(89, 57);
            this.btn_Xoa.TabIndex = 8;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Sua.Location = new System.Drawing.Point(141, 13);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(89, 57);
            this.btn_Sua.TabIndex = 7;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Them.Location = new System.Drawing.Point(10, 13);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 57);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnl_search
            // 
            this.pnl_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_search.Controls.Add(this.btn_search);
            this.pnl_search.Controls.Add(this.txt_search);
            this.pnl_search.Location = new System.Drawing.Point(20, 11);
            this.pnl_search.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_search.Name = "pnl_search";
            this.pnl_search.Size = new System.Drawing.Size(695, 70);
            this.pnl_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(594, 17);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 42);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.txt_search.Location = new System.Drawing.Point(23, 28);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(555, 22);
            this.txt_search.TabIndex = 0;
            // 
            // pnl_ID
            // 
            this.pnl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ID.Controls.Add(this.lbl_ID);
            this.pnl_ID.Controls.Add(this.txt_ID);
            this.pnl_ID.Location = new System.Drawing.Point(695, 105);
            this.pnl_ID.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ID.Name = "pnl_ID";
            this.pnl_ID.Size = new System.Drawing.Size(366, 77);
            this.pnl_ID.TabIndex = 5;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(6, 10);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(107, 19);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Mã nhân viên";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Location = new System.Drawing.Point(7, 42);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(349, 22);
            this.txt_ID.TabIndex = 0;
            // 
            // pnl_name
            // 
            this.pnl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_name.Controls.Add(this.lbl_name);
            this.pnl_name.Controls.Add(this.txt_name);
            this.pnl_name.Location = new System.Drawing.Point(695, 195);
            this.pnl_name.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(368, 77);
            this.pnl_name.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(7, 12);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 19);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Họ và tên";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.Location = new System.Drawing.Point(8, 44);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(348, 22);
            this.txt_name.TabIndex = 0;
            // 
            // pnl_phone
            // 
            this.pnl_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_phone.Controls.Add(this.lbl_phone);
            this.pnl_phone.Controls.Add(this.txt_phone);
            this.pnl_phone.Location = new System.Drawing.Point(695, 288);
            this.pnl_phone.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_phone.Name = "pnl_phone";
            this.pnl_phone.Size = new System.Drawing.Size(368, 77);
            this.pnl_phone.TabIndex = 7;
            // 
            // lbl_phone
            // 
            this.lbl_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_phone.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(7, 12);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(105, 19);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "Số điện thoại";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone.Location = new System.Drawing.Point(8, 44);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(348, 22);
            this.txt_phone.TabIndex = 0;
            // 
            // pnl_workshift
            // 
            this.pnl_workshift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_workshift.Controls.Add(this.lbl_workshift);
            this.pnl_workshift.Controls.Add(this.txt_workshift);
            this.pnl_workshift.Location = new System.Drawing.Point(695, 385);
            this.pnl_workshift.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_workshift.Name = "pnl_workshift";
            this.pnl_workshift.Size = new System.Drawing.Size(368, 77);
            this.pnl_workshift.TabIndex = 8;
            // 
            // lbl_workshift
            // 
            this.lbl_workshift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_workshift.AutoSize = true;
            this.lbl_workshift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_workshift.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workshift.Location = new System.Drawing.Point(7, 12);
            this.lbl_workshift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_workshift.Name = "lbl_workshift";
            this.lbl_workshift.Size = new System.Drawing.Size(79, 19);
            this.lbl_workshift.TabIndex = 2;
            this.lbl_workshift.Text = "Số ca làm";
            // 
            // txt_workshift
            // 
            this.txt_workshift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_workshift.Location = new System.Drawing.Point(7, 33);
            this.txt_workshift.Margin = new System.Windows.Forms.Padding(2);
            this.txt_workshift.Name = "txt_workshift";
            this.txt_workshift.Size = new System.Drawing.Size(348, 22);
            this.txt_workshift.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Clear.Location = new System.Drawing.Point(923, 587);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(128, 57);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Xóa tùy chọn";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // fNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 655);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.pnl_workshift);
            this.Controls.Add(this.pnl_phone);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.pnl_ID);
            this.Controls.Add(this.pnl_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_staff);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fNhanvien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.fNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_search.ResumeLayout(false);
            this.pnl_search.PerformLayout();
            this.pnl_ID.ResumeLayout(false);
            this.pnl_ID.PerformLayout();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.pnl_phone.ResumeLayout(false);
            this.pnl_phone.PerformLayout();
            this.pnl_workshift.ResumeLayout(false);
            this.pnl_workshift.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel pnl_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel pnl_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel pnl_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Panel pnl_workshift;
        private System.Windows.Forms.Label lbl_workshift;
        private System.Windows.Forms.TextBox txt_workshift;
        private System.Windows.Forms.Button btn_Clear;
    }
}