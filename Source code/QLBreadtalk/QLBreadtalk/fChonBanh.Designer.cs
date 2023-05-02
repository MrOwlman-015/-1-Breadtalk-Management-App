
namespace QLBreadtalk
{
    partial class fChonBanh
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
            this.pnl_SoLuong = new System.Windows.Forms.Panel();
            this.nbr_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.pnl_TimKiem = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgv_Banh = new System.Windows.Forms.DataGridView();
            this.pnl_SoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).BeginInit();
            this.pnl_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Banh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_SoLuong
            // 
            this.pnl_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_SoLuong.Controls.Add(this.nbr_SoLuong);
            this.pnl_SoLuong.Controls.Add(this.lbl_SoLuong);
            this.pnl_SoLuong.Location = new System.Drawing.Point(538, 19);
            this.pnl_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_SoLuong.Name = "pnl_SoLuong";
            this.pnl_SoLuong.Size = new System.Drawing.Size(319, 74);
            this.pnl_SoLuong.TabIndex = 18;
            // 
            // nbr_SoLuong
            // 
            this.nbr_SoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nbr_SoLuong.Location = new System.Drawing.Point(20, 46);
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
            this.lbl_SoLuong.Location = new System.Drawing.Point(20, 18);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(74, 19);
            this.lbl_SoLuong.TabIndex = 3;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_Them.Location = new System.Drawing.Point(876, 34);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(345, 57);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pnl_TimKiem
            // 
            this.pnl_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TimKiem.Controls.Add(this.btn_TimKiem);
            this.pnl_TimKiem.Controls.Add(this.txt_TimKiem);
            this.pnl_TimKiem.Location = new System.Drawing.Point(10, 19);
            this.pnl_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_TimKiem.Name = "pnl_TimKiem";
            this.pnl_TimKiem.Size = new System.Drawing.Size(524, 71);
            this.pnl_TimKiem.TabIndex = 17;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(85)))));
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(415, 14);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(82, 42);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.txt_TimKiem.Location = new System.Drawing.Point(17, 26);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(363, 22);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // dgv_Banh
            // 
            this.dgv_Banh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Banh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Banh.BackgroundColor = System.Drawing.Color.Orange;
            this.dgv_Banh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Banh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Banh.ColumnHeadersHeight = 29;
            this.dgv_Banh.GridColor = System.Drawing.Color.DarkOrange;
            this.dgv_Banh.Location = new System.Drawing.Point(10, 94);
            this.dgv_Banh.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Banh.Name = "dgv_Banh";
            this.dgv_Banh.RowHeadersWidth = 82;
            this.dgv_Banh.RowTemplate.Height = 33;
            this.dgv_Banh.Size = new System.Drawing.Size(1211, 508);
            this.dgv_Banh.TabIndex = 16;
            this.dgv_Banh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Banh_CellClick);
            // 
            // fChonBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 623);
            this.Controls.Add(this.pnl_SoLuong);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.pnl_TimKiem);
            this.Controls.Add(this.dgv_Banh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fChonBanh";
            this.Text = "Thêm bánh vào đơn hàng";
            this.Load += new System.EventHandler(this.fChonBanh_Load);
            this.pnl_SoLuong.ResumeLayout(false);
            this.pnl_SoLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).EndInit();
            this.pnl_TimKiem.ResumeLayout(false);
            this.pnl_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Banh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SoLuong;
        private System.Windows.Forms.NumericUpDown nbr_SoLuong;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel pnl_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgv_Banh;
    }
}