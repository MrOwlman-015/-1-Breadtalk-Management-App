using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLBreadtalk
{
    public partial class fLaphoadon : Form
    {
        BUS_KhachHang kh = new BUS_KhachHang();
        BUS_HoaDon hd = new BUS_HoaDon();
        BUS_KhuyenMai km = new BUS_KhuyenMai();
        public fLaphoadon()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_SoTienNhan.Text) >= Convert.ToInt32(txt_TongTien.Text))
            {
                txt_SoTienThua.Text = (Convert.ToInt32(txt_SoTienNhan.Text) - Convert.ToInt32(txt_TongTien.Text)).ToString();
                int voucher = - 1 ;
                if (cbx_Voucher.SelectedItem.ToString() == "Voucher1")
                {
                    voucher = 1;
                } else if (cbx_Voucher.SelectedItem.ToString() == "20%")
                {
                    voucher = 2;
                } else if (cbx_Voucher.SelectedItem.ToString() == "30%")
                {
                    voucher = 3;
                } else if (cbx_Voucher.SelectedItem.ToString() == "50%")
                {
                    voucher = 4;
                }
                else
                {
                    voucher = 1;
                }

                DTO_HoaDon newHD = new DTO_HoaDon(hd.getCurrentMaHoaDon(), kh.getIDbyPhone(txt_Sdt.Text), txt_MaNV.Text, voucher, DateTime.Today, Convert.ToInt32(txt_TongTien.Text));
                hd.suaHoaDon(newHD);
            }
            else
            {
                MessageBox.Show("Không đủ tiền thanh toán!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoLuong_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {

            if(txt_Sdt.Text != "" && txt_MaNV.Text != "")
            {
                DTO_HoaDon dto_hd = new DTO_HoaDon(0, kh.getIDbyPhone(txt_Sdt.Text), txt_MaNV.Text, 2, DateTime.Today, 0);
                if (hd.themHoaDon(dto_hd))
                {   
                    fChonBanh f = new fChonBanh();
                    f.HoaDonId = hd.getCurrentMaHoaDon();
                    this.Hide();
                    f.ShowDialog();
                    
                    BUS_ChiTietHoaDon ct = new BUS_ChiTietHoaDon();
                    ct.bindGridView(dgv_HoaDon, hd.getCurrentMaHoaDon());
                    txt_TongTien.Text = ct.getTotalCash(hd.getCurrentMaHoaDon()).ToString();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại");
                }
            }
            else
            {
                MessageBox.Show("Nhập mã nhân viên và số điện thoại khách hàng");
            }

        }

        private void fLaphoadon_Load(object sender, EventArgs e)
        {
            txt_TongTien.ReadOnly = true;
            km.bindComboBox(cbx_Voucher);
            /*ct.bindGridView(dgv_HoaDon, hd.getCurrentMaHoaDon());*/
            BUS_ChiTietHoaDon ct = new BUS_ChiTietHoaDon();
        }

        private void cbx_Voucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Voucher.SelectedItem != null)
            {
                string voucher = cbx_Voucher.SelectedItem.ToString();
                if (voucher == "20%")
                {
                    txt_TongTien.Text = (Convert.ToDouble(txt_TongTien.Text) * (1 - 0.2)).ToString();
                }
                else if (voucher == "30%")
                {
                    txt_TongTien.Text = (Convert.ToDouble(txt_TongTien.Text) * (1 - 0.3)).ToString();

                }
                else if (voucher == "50%")
                {
                    txt_TongTien.Text = (Convert.ToDouble(txt_TongTien.Text) * (1 - 0.5)).ToString();

                }
            }
        }
    }
}
