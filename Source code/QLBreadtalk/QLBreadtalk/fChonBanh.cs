using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QLBreadtalk
{
    public partial class fChonBanh : Form
    {
        int maBanh;
        string tenBanh = "";
        int sum;
        int tien;
        private int hoaDonId;
        BUS_Banh bh = new BUS_Banh();
        BUS_ChiTietHoaDon CTHD = new BUS_ChiTietHoaDon();

        public int HoaDonId { get => hoaDonId; set => hoaDonId = value; }

        public fChonBanh()
        {
            InitializeComponent();
        }

        private void fChonBanh_Load(object sender, EventArgs e)
        {
            bh.bindGridView(dgv_Banh);
        }

        private void dgv_Banh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgv_Banh.Rows[rowIndex];
                maBanh = Convert.ToInt32(row.Cells["maBanh"].Value);
                tenBanh = row.Cells["tenBanh"].Value.ToString();
                tien = Convert.ToInt32(row.Cells["donGia"].Value);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            sum = (int) nbr_SoLuong.Value * tien; 
            DTO_ChiTietHoaDon cthd = new DTO_ChiTietHoaDon(HoaDonId, maBanh, (int)nbr_SoLuong.Value, sum);
            bh.truBanh(maBanh, bh.getSoLuong(maBanh) - Convert.ToInt32(nbr_SoLuong.Value));
            CTHD.themChiTietHoaDon(cthd);
            bh.bindGridView(dgv_Banh);
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm hóa đơn thành công");
            this.Close();
        }
    }
}
