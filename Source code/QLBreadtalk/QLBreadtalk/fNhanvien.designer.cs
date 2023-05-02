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
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.pnl_PhimChucNang = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.pnl_TimKiem = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.pnl_ID = new System.Windows.Forms.Panel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.pnl_HoTen = new System.Windows.Forms.Panel();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.pnl_Sdt = new System.Windows.Forms.Panel();
            this.lbl_Sdt = new System.Windows.Forms.Label();
            this.txt_Sdt = new System.Windows.Forms.TextBox();
            this.pnl_SoCaLam = new System.Windows.Forms.Panel();
            this.nbr_SoCaLam = new System.Windows.Forms.NumericUpDown();
            this.lbl_SoCaLam = new System.Windows.Forms.Label();
            this.btn_XoaTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.pnl_PhimChucNang.SuspendLayout();
            this.pnl_TimKiem.SuspendLayout();
            this.pnl_ID.SuspendLayout();
            this.pnl_HoTen.SuspendLayout();
            this.pnl_Sdt.SuspendLayout();
            this.pnl_SoCaLam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoCaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.Color.Orange;
            this.dgv_NhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.GridColor = System.Drawing.Color.DarkOrange;
            this.dgv_NhanVien.Location = new System.Drawing.Point(2, 105);
            this.dgv_NhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 82;
            this.dgv_NhanVien.RowTemplate.Height = 33;
            this.dgv_NhanVien.Size = new System.Drawing.Size(646, 548);
            this.dgv_NhanVien.TabIndex = 2;
            this.dgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellClick);
            // 
            // pnl_PhimChucNang
            // 
            this.pnl_PhimChucNang.Controls.Add(this.btn_Xoa);
            this.pnl_PhimChucNang.Controls.Add(this.btn_CapNhat);
            this.pnl_PhimChucNang.Controls.Add(this.btn_Them);
            this.pnl_PhimChucNang.Location = new System.Drawing.Point(695, 488);
            this.pnl_PhimChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_PhimChucNang.Name = "pnl_PhimChucNang";
            this.pnl_PhimChucNang.Size = new System.Drawing.Size(368, 84);
            this.pnl_PhimChucNang.TabIndex = 3;
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
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_CapNhat.Location = new System.Drawing.Point(141, 13);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(89, 57);
            this.btn_CapNhat.TabIndex = 7;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
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
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pnl_TimKiem
            // 
            this.pnl_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TimKiem.Controls.Add(this.btn_TimKiem);
            this.pnl_TimKiem.Controls.Add(this.txt_TimKiem);
            this.pnl_TimKiem.Location = new System.Drawing.Point(20, 11);
            this.pnl_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_TimKiem.Name = "pnl_TimKiem";
            this.pnl_TimKiem.Size = new System.Drawing.Size(695, 70);
            this.pnl_TimKiem.TabIndex = 4;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(594, 17);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(82, 42);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.txt_TimKiem.Location = new System.Drawing.Point(23, 28);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(555, 22);
            this.txt_TimKiem.TabIndex = 0;
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
            // pnl_HoTen
            // 
            this.pnl_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_HoTen.Controls.Add(this.lbl_HoTen);
            this.pnl_HoTen.Controls.Add(this.txt_HoTen);
            this.pnl_HoTen.Location = new System.Drawing.Point(695, 195);
            this.pnl_HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_HoTen.Name = "pnl_HoTen";
            this.pnl_HoTen.Size = new System.Drawing.Size(368, 77);
            this.pnl_HoTen.TabIndex = 6;
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_HoTen.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(7, 12);
            this.lbl_HoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(78, 19);
            this.lbl_HoTen.TabIndex = 2;
            this.lbl_HoTen.Text = "Họ và tên";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_HoTen.Location = new System.Drawing.Point(8, 44);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(348, 22);
            this.txt_HoTen.TabIndex = 0;
            // 
            // pnl_Sdt
            // 
            this.pnl_Sdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Sdt.Controls.Add(this.lbl_Sdt);
            this.pnl_Sdt.Controls.Add(this.txt_Sdt);
            this.pnl_Sdt.Location = new System.Drawing.Point(695, 288);
            this.pnl_Sdt.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Sdt.Name = "pnl_Sdt";
            this.pnl_Sdt.Size = new System.Drawing.Size(368, 77);
            this.pnl_Sdt.TabIndex = 7;
            // 
            // lbl_Sdt
            // 
            this.lbl_Sdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Sdt.AutoSize = true;
            this.lbl_Sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_Sdt.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sdt.Location = new System.Drawing.Point(7, 12);
            this.lbl_Sdt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sdt.Name = "lbl_Sdt";
            this.lbl_Sdt.Size = new System.Drawing.Size(105, 19);
            this.lbl_Sdt.TabIndex = 2;
            this.lbl_Sdt.Text = "Số điện thoại";
            // 
            // txt_Sdt
            // 
            this.txt_Sdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Sdt.Location = new System.Drawing.Point(8, 44);
            this.txt_Sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Sdt.Name = "txt_Sdt";
            this.txt_Sdt.Size = new System.Drawing.Size(348, 22);
            this.txt_Sdt.TabIndex = 0;
            // 
            // pnl_SoCaLam
            // 
            this.pnl_SoCaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_SoCaLam.Controls.Add(this.nbr_SoCaLam);
            this.pnl_SoCaLam.Controls.Add(this.lbl_SoCaLam);
            this.pnl_SoCaLam.Location = new System.Drawing.Point(695, 385);
            this.pnl_SoCaLam.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_SoCaLam.Name = "pnl_SoCaLam";
            this.pnl_SoCaLam.Size = new System.Drawing.Size(368, 77);
            this.pnl_SoCaLam.TabIndex = 8;
            // 
            // nbr_SoCaLam
            // 
            this.nbr_SoCaLam.Location = new System.Drawing.Point(7, 34);
            this.nbr_SoCaLam.Name = "nbr_SoCaLam";
            this.nbr_SoCaLam.Size = new System.Drawing.Size(349, 22);
            this.nbr_SoCaLam.TabIndex = 3;
            // 
            // lbl_SoCaLam
            // 
            this.lbl_SoCaLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SoCaLam.AutoSize = true;
            this.lbl_SoCaLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_SoCaLam.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoCaLam.Location = new System.Drawing.Point(7, 12);
            this.lbl_SoCaLam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoCaLam.Name = "lbl_SoCaLam";
            this.lbl_SoCaLam.Size = new System.Drawing.Size(79, 19);
            this.lbl_SoCaLam.TabIndex = 2;
            this.lbl_SoCaLam.Text = "Số ca làm";
            // 
            // btn_XoaTatCa
            // 
            this.btn_XoaTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_XoaTatCa.Location = new System.Drawing.Point(923, 587);
            this.btn_XoaTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaTatCa.Name = "btn_XoaTatCa";
            this.btn_XoaTatCa.Size = new System.Drawing.Size(128, 57);
            this.btn_XoaTatCa.TabIndex = 9;
            this.btn_XoaTatCa.Text = "Xóa tùy chọn";
            this.btn_XoaTatCa.UseVisualStyleBackColor = false;
            this.btn_XoaTatCa.Click += new System.EventHandler(this.btn_XoaTatCa_Click);
            // 
            // fNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 655);
            this.Controls.Add(this.btn_XoaTatCa);
            this.Controls.Add(this.pnl_SoCaLam);
            this.Controls.Add(this.pnl_Sdt);
            this.Controls.Add(this.pnl_HoTen);
            this.Controls.Add(this.pnl_ID);
            this.Controls.Add(this.pnl_TimKiem);
            this.Controls.Add(this.pnl_PhimChucNang);
            this.Controls.Add(this.dgv_NhanVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fNhanvien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.fNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.pnl_PhimChucNang.ResumeLayout(false);
            this.pnl_TimKiem.ResumeLayout(false);
            this.pnl_TimKiem.PerformLayout();
            this.pnl_ID.ResumeLayout(false);
            this.pnl_ID.PerformLayout();
            this.pnl_HoTen.ResumeLayout(false);
            this.pnl_HoTen.PerformLayout();
            this.pnl_Sdt.ResumeLayout(false);
            this.pnl_Sdt.PerformLayout();
            this.pnl_SoCaLam.ResumeLayout(false);
            this.pnl_SoCaLam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoCaLam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Panel pnl_PhimChucNang;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel pnl_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Panel pnl_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Panel pnl_HoTen;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.Panel pnl_Sdt;
        private System.Windows.Forms.Label lbl_Sdt;
        private System.Windows.Forms.TextBox txt_Sdt;
        private System.Windows.Forms.Panel pnl_SoCaLam;
        private System.Windows.Forms.Label lbl_SoCaLam;
        private System.Windows.Forms.Button btn_XoaTatCa;
        private System.Windows.Forms.NumericUpDown nbr_SoCaLam;
    }
}