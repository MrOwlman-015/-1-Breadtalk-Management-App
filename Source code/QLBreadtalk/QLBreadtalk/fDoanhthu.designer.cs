namespace QLBreadtalk
{
    partial class fDoanhthu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl_NgayThang = new System.Windows.Forms.Panel();
            this.dtp_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cht_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.pnl_NgayThang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_DoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_NgayThang
            // 
            this.pnl_NgayThang.Controls.Add(this.dtp_NgayKetThuc);
            this.pnl_NgayThang.Controls.Add(this.label1);
            this.pnl_NgayThang.Controls.Add(this.dtp_NgayBatDau);
            this.pnl_NgayThang.Controls.Add(this.label2);
            this.pnl_NgayThang.Location = new System.Drawing.Point(8, 8);
            this.pnl_NgayThang.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_NgayThang.Name = "pnl_NgayThang";
            this.pnl_NgayThang.Size = new System.Drawing.Size(776, 64);
            this.pnl_NgayThang.TabIndex = 2;
            // 
            // dtp_NgayKetThuc
            // 
            this.dtp_NgayKetThuc.Location = new System.Drawing.Point(501, 24);
            this.dtp_NgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayKetThuc.Name = "dtp_NgayKetThuc";
            this.dtp_NgayKetThuc.Size = new System.Drawing.Size(275, 22);
            this.dtp_NgayKetThuc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "đến ngày";
            // 
            // dtp_NgayBatDau
            // 
            this.dtp_NgayBatDau.Location = new System.Drawing.Point(101, 24);
            this.dtp_NgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayBatDau.Name = "dtp_NgayBatDau";
            this.dtp_NgayBatDau.Size = new System.Drawing.Size(275, 22);
            this.dtp_NgayBatDau.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Từ ngày";
            // 
            // cht_DoanhThu
            // 
            chartArea2.Name = "ChartArea1";
            this.cht_DoanhThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_DoanhThu.Legends.Add(legend2);
            this.cht_DoanhThu.Location = new System.Drawing.Point(8, 77);
            this.cht_DoanhThu.Name = "cht_DoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cht_DoanhThu.Series.Add(series2);
            this.cht_DoanhThu.Size = new System.Drawing.Size(1138, 555);
            this.cht_DoanhThu.TabIndex = 13;
            this.cht_DoanhThu.Text = "Doanh Thu";
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(836, 27);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(143, 44);
            this.btn_Xem.TabIndex = 14;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(1003, 27);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(143, 44);
            this.btn_Print.TabIndex = 15;
            this.btn_Print.Text = "In";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // fDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 644);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.cht_DoanhThu);
            this.Controls.Add(this.pnl_NgayThang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fDoanhthu";
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.fDoanhthu_Load);
            this.pnl_NgayThang.ResumeLayout(false);
            this.pnl_NgayThang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_DoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_NgayThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_NgayBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_NgayKetThuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_DoanhThu;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button btn_Print;
    }
}