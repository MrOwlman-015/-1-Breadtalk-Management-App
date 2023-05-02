using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using BUS;
using DTO;
namespace QLBreadtalk
{
    
    public partial class fLogin : Form
    {
        BUS.BUS_TaiKhoan tk = new BUS_TaiKhoan();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_MouseEnter(object sender, EventArgs e)
        {
            btn_DangNhap.ForeColor = Color.White;
        }

        private void btn_DangNhap_MouseLeave(object sender, EventArgs e)
        {
            btn_DangNhap.ForeColor = Color.Black;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text == "Tên đăng nhập")
            {
                pnl_saiTaiKhoan.Visible = true;
                return;
            }
            if (txt_MatKhau.Text == "Nhập mật khẩu")
            {
                pnl_saiMatKhau.Visible = true;
                return;
            }


            DTO.DTO_TaiKhoan dto_tk = new DTO_TaiKhoan(txt_TaiKhoan.Text, txt_MatKhau.Text, 3);
            if (tk.checkLogIn(txt_TaiKhoan.Text, txt_MatKhau.Text))
            {
                if (tk.getTypeOfAccount(txt_TaiKhoan.Text) == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    fMenu fm = new fMenu();
                    this.Hide();
                    fm.ShowDialog();
                    this.Show();
                }
                else if (tk.getTypeOfAccount(txt_TaiKhoan.Text) == 3)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    BUS_KhachHang kh = new BUS_KhachHang();
                    string id = kh.getID(txt_TaiKhoan.Text, txt_MatKhau.Text);
                    fMenuForUser fm = new fMenuForUser(id);
                    this.Hide();
                    fm.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
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
            txt_MatKhau.PasswordChar = '*';
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

        private void lnk_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fRegist fr = new fRegist();
            fr.ShowDialog();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
