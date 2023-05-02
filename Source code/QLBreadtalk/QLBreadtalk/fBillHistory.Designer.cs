namespace QLBreadtalk
{
    partial class fBillHistory
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_XoaTuyChon = new System.Windows.Forms.Button();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.lbl_MaKM = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            this.lbl_MaHD = new System.Windows.Forms.Label();
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_MaKM = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.dgv_ChiTietHD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_HoaDon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_XoaTuyChon);
            this.splitContainer1.Panel2.Controls.Add(this.dtp_NgayLap);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_TongTien);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_NgayLap);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_MaKM);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_MaNV);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_MaKH);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_MaHD);
            this.splitContainer1.Panel2.Controls.Add(this.btn_XemChiTiet);
            this.splitContainer1.Panel2.Controls.Add(this.txt_TongTien);
            this.splitContainer1.Panel2.Controls.Add(this.txt_MaKM);
            this.splitContainer1.Panel2.Controls.Add(this.txt_MaNV);
            this.splitContainer1.Panel2.Controls.Add(this.txt_MaKH);
            this.splitContainer1.Panel2.Controls.Add(this.txt_MaHD);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_ChiTietHD);
            this.splitContainer1.Size = new System.Drawing.Size(1158, 644);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoaDon.BackgroundColor = System.Drawing.Color.Orange;
            this.dgv_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.GridColor = System.Drawing.Color.DarkOrange;
            this.dgv_HoaDon.Location = new System.Drawing.Point(3, 0);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.RowHeadersWidth = 51;
            this.dgv_HoaDon.RowTemplate.Height = 24;
            this.dgv_HoaDon.Size = new System.Drawing.Size(415, 644);
            this.dgv_HoaDon.TabIndex = 0;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellClick);
            // 
            // btn_XoaTuyChon
            // 
            this.btn_XoaTuyChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_XoaTuyChon.Location = new System.Drawing.Point(401, 324);
            this.btn_XoaTuyChon.Name = "btn_XoaTuyChon";
            this.btn_XoaTuyChon.Size = new System.Drawing.Size(114, 39);
            this.btn_XoaTuyChon.TabIndex = 15;
            this.btn_XoaTuyChon.Text = "Xóa tùy chọn";
            this.btn_XoaTuyChon.UseVisualStyleBackColor = false;
            this.btn_XoaTuyChon.Click += new System.EventHandler(this.btn_XoaTuyChon_Click);
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Location = new System.Drawing.Point(479, 70);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(200, 22);
            this.dtp_NgayLap.TabIndex = 14;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(476, 139);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(69, 16);
            this.lbl_TongTien.TabIndex = 13;
            this.lbl_TongTien.Text = "Tổng Tiền";
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Location = new System.Drawing.Point(476, 53);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(66, 16);
            this.lbl_NgayLap.TabIndex = 12;
            this.lbl_NgayLap.Text = "Ngày Lập";
            // 
            // lbl_MaKM
            // 
            this.lbl_MaKM.AutoSize = true;
            this.lbl_MaKM.Location = new System.Drawing.Point(75, 313);
            this.lbl_MaKM.Name = "lbl_MaKM";
            this.lbl_MaKM.Size = new System.Drawing.Size(98, 16);
            this.lbl_MaKM.TabIndex = 11;
            this.lbl_MaKM.Text = "Mã Khuyến Mãi";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(75, 223);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(91, 16);
            this.lbl_MaNV.TabIndex = 10;
            this.lbl_MaNV.Text = "Mã Nhân Viên";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.Location = new System.Drawing.Point(75, 139);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(102, 16);
            this.lbl_MaKH.TabIndex = 9;
            this.lbl_MaKH.Text = "Mã Khách Hàng";
            // 
            // lbl_MaHD
            // 
            this.lbl_MaHD.AutoSize = true;
            this.lbl_MaHD.Location = new System.Drawing.Point(75, 53);
            this.lbl_MaHD.Name = "lbl_MaHD";
            this.lbl_MaHD.Size = new System.Drawing.Size(82, 16);
            this.lbl_MaHD.TabIndex = 8;
            this.lbl_MaHD.Text = "Mã Hóa Đơn";
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_XemChiTiet.Location = new System.Drawing.Point(541, 324);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(114, 39);
            this.btn_XemChiTiet.TabIndex = 7;
            this.btn_XemChiTiet.Text = "Xem chi tiết";
            this.btn_XemChiTiet.UseVisualStyleBackColor = false;
            this.btn_XemChiTiet.Click += new System.EventHandler(this.btn_XemChiTiet_Click);
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(479, 158);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(200, 22);
            this.txt_TongTien.TabIndex = 6;
            // 
            // txt_MaKM
            // 
            this.txt_MaKM.Location = new System.Drawing.Point(78, 332);
            this.txt_MaKM.Name = "txt_MaKM";
            this.txt_MaKM.Size = new System.Drawing.Size(200, 22);
            this.txt_MaKM.TabIndex = 5;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(78, 242);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(200, 22);
            this.txt_MaNV.TabIndex = 4;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(78, 158);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(200, 22);
            this.txt_MaKH.TabIndex = 3;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(78, 70);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(200, 22);
            this.txt_MaHD.TabIndex = 1;
            // 
            // dgv_ChiTietHD
            // 
            this.dgv_ChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietHD.BackgroundColor = System.Drawing.Color.Orange;
            this.dgv_ChiTietHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHD.GridColor = System.Drawing.Color.DarkOrange;
            this.dgv_ChiTietHD.Location = new System.Drawing.Point(3, 422);
            this.dgv_ChiTietHD.Name = "dgv_ChiTietHD";
            this.dgv_ChiTietHD.RowHeadersWidth = 51;
            this.dgv_ChiTietHD.RowTemplate.Height = 24;
            this.dgv_ChiTietHD.Size = new System.Drawing.Size(718, 219);
            this.dgv_ChiTietHD.TabIndex = 0;
            // 
            // fBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 644);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fBillHistory";
            this.Text = "Lịch sử đơn hàng";
            this.Load += new System.EventHandler(this.fBillHistory_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_NgayLap;
        private System.Windows.Forms.Label lbl_MaKM;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_MaKH;
        private System.Windows.Forms.Label lbl_MaHD;
        private System.Windows.Forms.Button btn_XemChiTiet;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.TextBox txt_MaKM;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.TextBox txt_MaHD;
        private System.Windows.Forms.DataGridView dgv_ChiTietHD;
        private System.Windows.Forms.Button btn_XoaTuyChon;
    }
}