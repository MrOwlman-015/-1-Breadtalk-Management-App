
namespace QLBreadtalk
{
    partial class fThemBanh
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
            this.pnl_TimKiem = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_XoaTuyChon = new System.Windows.Forms.Button();
            this.dgv_Banh = new System.Windows.Forms.DataGridView();
            this.pnl_SoLuong = new System.Windows.Forms.Panel();
            this.nbr_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.pnl_DonGia = new System.Windows.Forms.Panel();
            this.nbr_DonGia = new System.Windows.Forms.NumericUpDown();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.pnl_ID = new System.Windows.Forms.Panel();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.pnl_TenBanh = new System.Windows.Forms.Panel();
            this.txt_TenBanh = new System.Windows.Forms.TextBox();
            this.lbl_TenBanh = new System.Windows.Forms.Label();
            this.pnl_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Banh)).BeginInit();
            this.pnl_SoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).BeginInit();
            this.pnl_DonGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_DonGia)).BeginInit();
            this.pnl_ID.SuspendLayout();
            this.pnl_TenBanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_TimKiem
            // 
            this.pnl_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TimKiem.Controls.Add(this.btn_TimKiem);
            this.pnl_TimKiem.Controls.Add(this.txt_TimKiem);
            this.pnl_TimKiem.Location = new System.Drawing.Point(14, 38);
            this.pnl_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_TimKiem.Name = "pnl_TimKiem";
            this.pnl_TimKiem.Size = new System.Drawing.Size(450, 74);
            this.pnl_TimKiem.TabIndex = 12;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(341, 14);
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
            this.txt_TimKiem.Location = new System.Drawing.Point(-35, 26);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(363, 22);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Them.Location = new System.Drawing.Point(538, 64);
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
            this.btn_XoaTuyChon.Location = new System.Drawing.Point(698, 64);
            this.btn_XoaTuyChon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaTuyChon.Name = "btn_XoaTuyChon";
            this.btn_XoaTuyChon.Size = new System.Drawing.Size(100, 57);
            this.btn_XoaTuyChon.TabIndex = 5;
            this.btn_XoaTuyChon.Text = "Xóa tùy chọn";
            this.btn_XoaTuyChon.UseVisualStyleBackColor = false;
            this.btn_XoaTuyChon.Click += new System.EventHandler(this.btn_XoaTuyChon_Click);
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
            this.dgv_Banh.Location = new System.Drawing.Point(14, 137);
            this.dgv_Banh.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Banh.Name = "dgv_Banh";
            this.dgv_Banh.RowHeadersWidth = 82;
            this.dgv_Banh.RowTemplate.Height = 33;
            this.dgv_Banh.Size = new System.Drawing.Size(784, 508);
            this.dgv_Banh.TabIndex = 10;
            this.dgv_Banh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Banh_CellClick);
            // 
            // pnl_SoLuong
            // 
            this.pnl_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_SoLuong.Controls.Add(this.nbr_SoLuong);
            this.pnl_SoLuong.Controls.Add(this.lbl_SoLuong);
            this.pnl_SoLuong.Location = new System.Drawing.Point(802, 468);
            this.pnl_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_SoLuong.Name = "pnl_SoLuong";
            this.pnl_SoLuong.Size = new System.Drawing.Size(310, 74);
            this.pnl_SoLuong.TabIndex = 13;
            // 
            // nbr_SoLuong
            // 
            this.nbr_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbr_SoLuong.Location = new System.Drawing.Point(11, 46);
            this.nbr_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.nbr_SoLuong.Maximum = new decimal(new int[] {
            10000,
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
            this.lbl_SoLuong.Location = new System.Drawing.Point(11, 18);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(74, 19);
            this.lbl_SoLuong.TabIndex = 3;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // pnl_DonGia
            // 
            this.pnl_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_DonGia.Controls.Add(this.nbr_DonGia);
            this.pnl_DonGia.Controls.Add(this.lbl_DonGia);
            this.pnl_DonGia.Location = new System.Drawing.Point(802, 368);
            this.pnl_DonGia.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_DonGia.Name = "pnl_DonGia";
            this.pnl_DonGia.Size = new System.Drawing.Size(310, 74);
            this.pnl_DonGia.TabIndex = 14;
            // 
            // nbr_DonGia
            // 
            this.nbr_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbr_DonGia.Location = new System.Drawing.Point(15, 39);
            this.nbr_DonGia.Margin = new System.Windows.Forms.Padding(2);
            this.nbr_DonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbr_DonGia.Name = "nbr_DonGia";
            this.nbr_DonGia.Size = new System.Drawing.Size(263, 22);
            this.nbr_DonGia.TabIndex = 5;
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_DonGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(11, 18);
            this.lbl_DonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(66, 19);
            this.lbl_DonGia.TabIndex = 3;
            this.lbl_DonGia.Text = "Đơn giá";
            // 
            // pnl_ID
            // 
            this.pnl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ID.Controls.Add(this.txt_ID);
            this.pnl_ID.Controls.Add(this.lbl_ID);
            this.pnl_ID.Location = new System.Drawing.Point(802, 170);
            this.pnl_ID.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_ID.Name = "pnl_ID";
            this.pnl_ID.Size = new System.Drawing.Size(310, 74);
            this.pnl_ID.TabIndex = 15;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(11, 49);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(263, 22);
            this.txt_ID.TabIndex = 4;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(11, 18);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(72, 19);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Mã bánh";
            // 
            // pnl_TenBanh
            // 
            this.pnl_TenBanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TenBanh.Controls.Add(this.txt_TenBanh);
            this.pnl_TenBanh.Controls.Add(this.lbl_TenBanh);
            this.pnl_TenBanh.Location = new System.Drawing.Point(802, 270);
            this.pnl_TenBanh.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_TenBanh.Name = "pnl_TenBanh";
            this.pnl_TenBanh.Size = new System.Drawing.Size(310, 74);
            this.pnl_TenBanh.TabIndex = 16;
            // 
            // txt_TenBanh
            // 
            this.txt_TenBanh.Location = new System.Drawing.Point(11, 49);
            this.txt_TenBanh.Name = "txt_TenBanh";
            this.txt_TenBanh.Size = new System.Drawing.Size(263, 22);
            this.txt_TenBanh.TabIndex = 5;
            // 
            // lbl_TenBanh
            // 
            this.lbl_TenBanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TenBanh.AutoSize = true;
            this.lbl_TenBanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.lbl_TenBanh.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenBanh.Location = new System.Drawing.Point(11, 18);
            this.lbl_TenBanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenBanh.Name = "lbl_TenBanh";
            this.lbl_TenBanh.Size = new System.Drawing.Size(75, 19);
            this.lbl_TenBanh.TabIndex = 3;
            this.lbl_TenBanh.Text = "Tên bánh";
            // 
            // fThemBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 623);
            this.Controls.Add(this.pnl_TenBanh);
            this.Controls.Add(this.pnl_ID);
            this.Controls.Add(this.pnl_DonGia);
            this.Controls.Add(this.pnl_SoLuong);
            this.Controls.Add(this.btn_XoaTuyChon);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pnl_TimKiem);
            this.Controls.Add(this.dgv_Banh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fThemBanh";
            this.Text = "Thêm bánh";
            this.Load += new System.EventHandler(this.fThemBanh_Load);
            this.pnl_TimKiem.ResumeLayout(false);
            this.pnl_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Banh)).EndInit();
            this.pnl_SoLuong.ResumeLayout(false);
            this.pnl_SoLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).EndInit();
            this.pnl_DonGia.ResumeLayout(false);
            this.pnl_DonGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_DonGia)).EndInit();
            this.pnl_ID.ResumeLayout(false);
            this.pnl_ID.PerformLayout();
            this.pnl_TenBanh.ResumeLayout(false);
            this.pnl_TenBanh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_XoaTuyChon;
        private System.Windows.Forms.DataGridView dgv_Banh;
        private System.Windows.Forms.Panel pnl_SoLuong;
        private System.Windows.Forms.NumericUpDown nbr_SoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Panel pnl_DonGia;
        private System.Windows.Forms.NumericUpDown nbr_DonGia;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Panel pnl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Panel pnl_TenBanh;
        private System.Windows.Forms.TextBox txt_TenBanh;
        private System.Windows.Forms.Label lbl_TenBanh;
    }
}