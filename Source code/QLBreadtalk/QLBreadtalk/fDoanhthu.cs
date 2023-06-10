using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            cht_DoanhThu.Series.Clear();
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
        }

        private void fDoanhthu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveDialog.RestoreDirectory = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                try
                {
                    PdfWriter.GetInstance(pdfDoc, new FileStream(saveDialog.FileName, FileMode.Create));

                    pdfDoc.Open();

                    Bitmap chartImage = new Bitmap(cht_DoanhThu.Width, cht_DoanhThu.Height);
                    cht_DoanhThu.DrawToBitmap(chartImage, new System.Drawing.Rectangle(0, 0, cht_DoanhThu.Width, cht_DoanhThu.Height));

                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(chartImage, ImageFormat.Bmp);

                    pdfImage.ScaleToFit(pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin, pdfDoc.PageSize.Height - pdfDoc.TopMargin - pdfDoc.BottomMargin);

                    pdfDoc.Add(pdfImage);
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show("Error exporting chart to PDF: " + ex.Message);*/
                    MessageBox.Show("In thất bại! Lỗi: " + ex.Message);
                }
                finally
                {
                    MessageBox.Show("In thành công!");
                    pdfDoc.Close();
                }
            }
        }
    }
}
