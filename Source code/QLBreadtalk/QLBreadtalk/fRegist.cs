using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLBreadtalk
{
    public partial class fRegist : Form
    {
        BUS_KhachHang kh = new BUS_KhachHang();
        public fRegist()
        {
            InitializeComponent();

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            DTO_KhachHang dto_kh = new DTO_KhachHang(null, txt_HoTen.Text, txt_TaiKhoan.Text, txt_MatKhau.Text, txt_Sdt.Text);
            BUS.BUS_TaiKhoan tk = new BUS_TaiKhoan();
            if (!tk.checkUsernameUsed(txt_TaiKhoan.Text))
            {
                if (txt_MatKhau.TextLength < 6)
                {
                    pnl_saiMatKhau.Visible = true;
                }
                else
                {
                    if (String.Compare(txt_MatKhau.Text, txt_nhapXacNhan.Text) != 0)
                    {
                        pnl_saiXacNhan.Visible = true;
                        return;
                    }
                    BUS.BUS_KhachHang buskh = new BUS_KhachHang();
                    if (!buskh.checkPhoneUsed(txt_Sdt.Text))
                    {
                        if (kh.themKhachHang(dto_kh))
                        {
                            MessageBox.Show("Đăng ký thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại!");
                        }
                    }
                    else
                    {
                        pnl_saiSdt.Visible = true;
                    }
                }
            }
            else
            {
                /*pnl_saiTaiKhoan.Visible = true;*/
                MessageBox.Show("Đã tồn tại tài khoản!");
                return;
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_TaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text == "Tên đăng nhập")
            {
                txt_TaiKhoan.Text = "";
                txt_TaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txt_TaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text == "")
            {
                txt_TaiKhoan.Text = "Tên đăng nhập";
                txt_TaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {

            if (txt_MatKhau.Text == "Nhập mật khẩu")
            {
                txt_MatKhau.Text = "";
                txt_MatKhau.ForeColor = Color.Black;
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "")
            {
                txt_MatKhau.Text = "Nhập mật khẩu";
                txt_MatKhau.ForeColor = Color.Gray;
                txt_MatKhau.UseSystemPasswordChar = false;

            }
        }

        private void txt_XacNhan_Enter(object sender, EventArgs e)
        {
            txt_nhapXacNhan.PasswordChar = '*';
            if (txt_nhapXacNhan.Text == "Nhập lại mật khẩu")
            {
                txt_nhapXacNhan.Text = "";
                txt_nhapXacNhan.ForeColor = Color.Black;
                txt_nhapXacNhan.UseSystemPasswordChar = true;

            }
        }

        private void txt_XacNhan_Leave(object sender, EventArgs e)
        {
            if (txt_nhapXacNhan.Text == "")
            {
                txt_nhapXacNhan.Text = "Nhập lại mật khẩu";
                txt_nhapXacNhan.ForeColor = Color.Gray;
                txt_nhapXacNhan.UseSystemPasswordChar = false;

            }
        }

        private void txt_Sdt_Enter(object sender, EventArgs e)
        {
            if (txt_Sdt.Text == "Số điện thoại")
            {
                txt_Sdt.Text = "";
                txt_Sdt.ForeColor = Color.Black;
            }
        }

        private void txt_Sdt_Leave(object sender, EventArgs e)
        {
            if (txt_Sdt.Text == "")
            {
                txt_Sdt.Text = "Số điện thoại";
                txt_Sdt.ForeColor = Color.Gray;
            }
        }

        private void txt_HoTen_Enter(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "Họ và tên")
            {
                txt_HoTen.Text = "";
                txt_HoTen.ForeColor = Color.Black;
            }
        }

        private void txt_HoTen_Leave(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "")
            {
                txt_HoTen.Text = "Họ và tên";
                txt_HoTen.ForeColor = Color.Gray;
            }
        }
    }
}
 