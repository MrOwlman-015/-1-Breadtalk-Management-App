using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;

namespace QLBreadtalk
{
    public partial class fDoanhthu : Form
    {
        BUS_HoaDon hd = new BUS_HoaDon();
        public fDoanhthu()
        {
            InitializeComponent();
        }

        private void load()
        {
            cht_DoanhThu.DataSource = hd.getDoanhThu(Convert.ToDateTime(dtp_NgayBatDau.Value), Convert.ToDateTime(dtp_NgayKetThuc.Value));
            Series doanhThuSeries = cht_DoanhThu.Series.FindByName("DoanhThu");

            // Remove the series if it exists
            if (doanhThuSeries != null)
            {
                cht_DoanhThu.Series.Remove(doanhThuSeries);
            }
            cht_DoanhThu.Series.Add("DoanhThu");
            cht_DoanhThu.Series["DoanhThu"].XValueMember = "ngaylap";
            cht_DoanhThu.Series["DoanhThu"].YValueMembers = "doanhthu";
            cht_DoanhThu.DataBind();
            cht_DoanhThu.Titles.Add("Tổng doanh thu");
            Legend doanhThuLegend = cht_DoanhThu.Legends.FindByName("Doanh thu");

            if (doanhThuLegend != null)
            {
                cht_DoanhThu.Legends.Remove(doanhThuLegend);
            }
            cht_DoanhThu.Legends.Add("Doanh thu");
            cht_DoanhThu.ChartAreas[0].AxisX.Title = "Ngày";
            cht_DoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu";
            cht_DoanhThu.Dock = DockStyle.Fill;
            this.Controls.Add(cht_DoanhThu);


            /*DateTime startDate = dtp_NgayBatDau.Value;
            DateTime endDate = dtp_NgayKetThuc.Value;

            // Get the data for the chart from the data access layer
            DataTable data = hd.getDoanhThu(startDate, endDate);

            // Create a new chart series
            Series doanhThuSeries = new Series("DoanhThu");
            doanhThuSeries.XValueMember = "ngaylap";
            doanhThuSeries.YValueMembers = "doanhthu";

            // Bind the chart series to the data
            cht_DoanhThu.DataSource = data;
            cht_DoanhThu.Series.Clear();
            cht_DoanhThu.Series.Add(doanhThuSeries);
            cht_DoanhThu.DataBind();

            // Customize the chart appearance and layout
            cht_DoanhThu.Titles.Clear();
            cht_DoanhThu.Titles.Add("Tổng doanh thu");
            cht_DoanhThu.Legends.Clear();
            cht_DoanhThu.Legends.Add("Doanh thu");
            cht_DoanhThu.ChartAreas[0].AxisX.Title = "Ngày";
            cht_DoanhThu.ChartAreas[0].AxisY.Title = "Doanh thu";
            cht_DoanhThu.Dock = DockStyle.Fill;*/
        }

        private void fDoanhthu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
