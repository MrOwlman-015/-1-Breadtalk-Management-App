namespace QLBreadtalk
{
    partial class fBanh
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
            this.dgv_Banh = new System.Windows.Forms.DataGridView();
            this.pnl_PhimChucNang = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_XoaTuyChon = new System.Windows.Forms.Button();
            this.pnl_TimKiem = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.pnl_ID = new System.Windows.Forms.Panel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.pnl_TenBanh = new System.Windows.Forms.Panel();
            this.lbl_TenBanh = new System.Windows.Forms.Label();
            this.txt_TenBanh = new System.Windows.Forms.TextBox();
            this.pnl_GiaTien = new System.Windows.Forms.Panel();
            this.nbr_GiaTien = new System.Windows.Forms.NumericUpDown();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.pnl_SoLuong = new System.Windows.Forms.Panel();
            this.nbr_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Banh)).BeginInit();
            this.pnl_PhimChucNang.SuspendLayout();
            this.pnl_TimKiem.SuspendLayout();
            this.pnl_ID.SuspendLayout();
            this.pnl_TenBanh.SuspendLayout();
            this.pnl_GiaTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_GiaTien)).BeginInit();
            this.pnl_SoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Banh
            // 
            this.dgv_Banh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Banh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Banh.BackgroundColor = System.Drawing.Color.Orange;
            this.dgv_Banh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Banh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Banh.GridColor = System.Drawing.Color.DarkOrange;
            this.dgv_Banh.Location = new System.Drawing.Point(2, 95);
            this.dgv_Banh.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Banh.Name = "dgv_Banh";
            this.dgv_Banh.RowHeadersWidth = 82;
            this.dgv_Banh.RowTemplate.Height = 33;
            this.dgv_Banh.Size = new System.Drawing.Size(695, 548);
            this.dgv_Banh.TabIndex = 1;
            this.dgv_Banh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Banh_CellClick);
            // 
            // pnl_PhimChucNang
            // 
            this.pnl_PhimChucNang.Controls.Add(this.btn_Xoa);
            this.pnl_PhimChucNang.Controls.Add(this.btn_CapNhat);
            this.pnl_PhimChucNang.Controls.Add(this.btn_Them);
            this.pnl_PhimChucNang.Controls.Add(this.btn_XoaTuyChon);
            this.pnl_PhimChucNang.Location = new System.Drawing.Point(8, 8);
            this.pnl_PhimChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_PhimChucNang.Name = "pnl_PhimChucNang";
            this.pnl_PhimChucNang.Size = new System.Drawing.Size(689, 84);
            this.pnl_PhimChucNang.TabIndex = 2;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Xoa.Location = new System.Drawing.Point(377, 13);
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
            this.btn_CapNhat.Location = new System.Drawing.Point(214, 13);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(89, 57);
            this.btn_CapNhat.TabIndex = 7;
            this.btn_CapNhat.Text = "Sửa";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Them.Location = new System.Drawing.Point(55, 13);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(89, 57);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_XoaTuyChon
            // 
            this.btn_XoaTuyChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_XoaTuyChon.Location = new System.Drawing.Point(531, 13);
            this.btn_XoaTuyChon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaTuyChon.Name = "btn_XoaTuyChon";
            this.btn_XoaTuyChon.Size = new System.Drawing.Size(100, 57);
            this.btn_XoaTuyChon.TabIndex = 5;
            this.btn_XoaTuyChon.Text = "Xóa tùy chọn";
            this.btn_XoaTuyChon.UseVisualStyleBackColor = false;
            this.btn_XoaTuyChon.Click += new System.EventHandler(this.btn_XoaTuyChon_Click);
            // 
            // pnl_TimKiem
            // 
            this.pnl_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TimKiem.Controls.Add(this.btn_TimKiem);
            this.pnl_TimKiem.Controls.Add(this.txt_TimKiem);
            this.pnl_TimKiem.Location = new System.Drawing.Point(713, 21);
            this.pnl_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_TimKiem.Name = "pnl_TimKiem";
            this.pnl_TimKiem.Size = new System.Drawing.Size(366, 71);
            this.pnl_TimKiem.TabIndex = 3;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(271, 15);
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
            this.txt_TimKiem.Location = new System.Drawing.Point(7, 26);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(247, 22);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // pnl_ID
            // 
            this.pnl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ID.Controls.Add(this.lbl_ID);
            this.pnl_ID.Controls.Add(this.txt_ID);
            this.pnl_ID.Location = new System.Drawing.Point(713, 116);
            this.pnl_ID.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ID.Name = "pnl_ID";
            this.pnl_ID.Size = new System.Drawing.Size(366, 77);
            this.pnl_ID.TabIndex = 4;
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
            this.lbl_ID.Size = new System.Drawing.Size(72, 19);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Mã bánh";
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Location = new System.Drawing.Point(7, 42);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(247, 22);
            this.txt_ID.TabIndex = 0;
            // 
            // pnl_TenBanh
            // 
            this.pnl_TenBanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TenBanh.Controls.Add(this.lbl_TenBanh);
            this.pnl_TenBanh.Controls.Add(this.txt_TenBanh);
            this.pnl_TenBanh.Location = new System.Drawing.Point(713, 240);
            this.pnl_TenBanh.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_TenBanh.Name = "pnl_TenBanh";
            this.pnl_TenBanh.Size = new System.Drawing.Size(368, 77);
            this.pnl_TenBanh.TabIndex = 5;
            // 
            // lbl_TenBanh
            // 
            this.lbl_TenBanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenBanh.AutoSize = true;
            this.lbl_TenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_TenBanh.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBanh.Location = new System.Drawing.Point(7, 12);
            this.lbl_TenBanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenBanh.Name = "lbl_TenBanh";
            this.lbl_TenBanh.Size = new System.Drawing.Size(75, 19);
            this.lbl_TenBanh.TabIndex = 2;
            this.lbl_TenBanh.Text = "Tên bánh";
            // 
            // txt_TenBanh
            // 
            this.txt_TenBanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TenBanh.Location = new System.Drawing.Point(8, 44);
            this.txt_TenBanh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenBanh.Name = "txt_TenBanh";
            this.txt_TenBanh.Size = new System.Drawing.Size(247, 22);
            this.txt_TenBanh.TabIndex = 0;
            // 
            // pnl_GiaTien
            // 
            this.pnl_GiaTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_GiaTien.Controls.Add(this.nbr_GiaTien);
            this.pnl_GiaTien.Controls.Add(this.lbl_GiaTien);
            this.pnl_GiaTien.Location = new System.Drawing.Point(713, 366);
            this.pnl_GiaTien.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_GiaTien.Name = "pnl_GiaTien";
            this.pnl_GiaTien.Size = new System.Drawing.Size(366, 77);
            this.pnl_GiaTien.TabIndex = 6;
            // 
            // nbr_GiaTien
            // 
            this.nbr_GiaTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbr_GiaTien.Location = new System.Drawing.Point(8, 44);
            this.nbr_GiaTien.Margin = new System.Windows.Forms.Padding(2);
            this.nbr_GiaTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbr_GiaTien.Name = "nbr_GiaTien";
            this.nbr_GiaTien.Size = new System.Drawing.Size(264, 22);
            this.nbr_GiaTien.TabIndex = 4;
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_GiaTien.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.Location = new System.Drawing.Point(7, 13);
            this.lbl_GiaTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(70, 19);
            this.lbl_GiaTien.TabIndex = 3;
            this.lbl_GiaTien.Text = "Giá tiền";
            // 
            // pnl_SoLuong
            // 
            this.pnl_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_SoLuong.Controls.Add(this.nbr_SoLuong);
            this.pnl_SoLuong.Controls.Add(this.lbl_SoLuong);
            this.pnl_SoLuong.Location = new System.Drawing.Point(713, 488);
            this.pnl_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_SoLuong.Name = "pnl_SoLuong";
            this.pnl_SoLuong.Size = new System.Drawing.Size(366, 77);
            this.pnl_SoLuong.TabIndex = 9;
            // 
            // nbr_SoLuong
            // 
            this.nbr_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbr_SoLuong.Location = new System.Drawing.Point(9, 44);
            this.nbr_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nbr_SoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nbr_SoLuong.Name = "nbr_SoLuong";
            this.nbr_SoLuong.Size = new System.Drawing.Size(263, 22);
            this.nbr_SoLuong.TabIndex = 5;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_SoLuong.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(9, 12);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(74, 19);
            this.lbl_SoLuong.TabIndex = 3;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // fBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 644);
            this.Controls.Add(this.pnl_SoLuong);
            this.Controls.Add(this.pnl_GiaTien);
            this.Controls.Add(this.pnl_TenBanh);
            this.Controls.Add(this.pnl_ID);
            this.Controls.Add(this.pnl_TimKiem);
            this.Controls.Add(this.pnl_PhimChucNang);
            this.Controls.Add(this.dgv_Banh);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fBanh";
            this.Text = "Quản lý bánh";
            this.Load += new System.EventHandler(this.fBanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Banh)).EndInit();
            this.pnl_PhimChucNang.ResumeLayout(false);
            this.pnl_TimKiem.ResumeLayout(false);
            this.pnl_TimKiem.PerformLayout();
            this.pnl_ID.ResumeLayout(false);
            this.pnl_ID.PerformLayout();
            this.pnl_TenBanh.ResumeLayout(false);
            this.pnl_TenBanh.PerformLayout();
            this.pnl_GiaTien.ResumeLayout(false);
            this.pnl_GiaTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_GiaTien)).EndInit();
            this.pnl_SoLuong.ResumeLayout(false);
            this.pnl_SoLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Banh;
        private System.Windows.Forms.Panel pnl_PhimChucNang;
        private System.Windows.Forms.Button btn_XoaTuyChon;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel pnl_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Panel pnl_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Panel pnl_TenBanh;
        private System.Windows.Forms.Label lbl_TenBanh;
        private System.Windows.Forms.TextBox txt_TenBanh;
        private System.Windows.Forms.Panel pnl_GiaTien;
        private System.Windows.Forms.NumericUpDown nbr_GiaTien;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Panel pnl_SoLuong;
        private System.Windows.Forms.NumericUpDown nbr_SoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
    }
}