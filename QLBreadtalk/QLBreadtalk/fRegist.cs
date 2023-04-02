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
        /*Form opener;*/
        public fRegist(Form opener)
        {
            InitializeComponent();
            opener = ParentForm;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*DTO.DTO_KhachHang dto_kh = new DTO_KhachHang(null, "Teof", txt_username.Text, txt_password.Text, txt_phone.Text);
            DTO_KhachHang dto_kh2 = kh.getKhachHangbyUsername(txt_username.Text);
            
            if (String.Compare(dto_kh.TkKH, dto_kh2.TkKH) == 0)
            {
                if (String.Compare(txt_password.Text, txt_repassword.Text) != 0)
                {
                    MessageBox.Show("Xác nhận mật khẩu sai!");
                    return;
                }
                DataTable dt = kh.getKhachHangbyPhone(txt_phone.Text);
                if (dt.Rows.Count > 0)
                {

                    if (kh.themKhachHang(dto_kh))
                    {
                        MessageBox.Show("Thanh cong!");

                    }
                    else
                    {
                        MessageBox.Show("Fail!");
                    }
                }
                else
                {
                    MessageBox.Show("Phone already in used");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Username already in used");
                return;
            }*/



            DTO_KhachHang dto_kh = new DTO_KhachHang(null, txt_name.Text, txt_username.Text, txt_password.Text, txt_phone.Text);
            BUS.BUS_TaiKhoan tk = new BUS_TaiKhoan();
            if (!tk.checkUsernameUsed(txt_username.Text))
            {
                if (String.Compare(txt_password.Text, txt_repassword.Text) != 0)
                {
                    MessageBox.Show("Xác nhận mật khẩu sai!");
                    return;
                }
                BUS.BUS_KhachHang buskh = new BUS_KhachHang();
                if (!buskh.checkPhoneUsed(txt_phone.Text))
                {
                    if (kh.themKhachHang(dto_kh))
                    {
                        MessageBox.Show("Thanh cong");
                    }
                    else
                    {
                        MessageBox.Show("That bai");
                    }
                }
                else
                {
                    pnl_phone.Visible = true;
                }
            }
            else
            {
                pnl_username.Visible = true;
                return;
            }
        }

        
        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Tên đăng nhập")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
        }

        

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Tên đăng nhập";
                txt_username.ForeColor = Color.Gray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
           
            if (txt_password.Text == "Nhập mật khẩu")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Nhập mật khẩu";
                txt_password.ForeColor = Color.Gray;
                txt_password.UseSystemPasswordChar = false;

            }
        }

        private void txt_repassword_Enter(object sender, EventArgs e)
        {
            txt_repassword.PasswordChar = '*';
            if (txt_repassword.Text == "Nhập lại mật khẩu")
            {
                txt_repassword.Text = "";
                txt_repassword.ForeColor = Color.Black;
                txt_repassword.UseSystemPasswordChar = true;

            }
        }

        private void txt_repassword_Leave(object sender, EventArgs e)
        {
            if (txt_repassword.Text == "")
            {
                txt_repassword.Text = "Nhập lại mật khẩu";
                txt_repassword.ForeColor = Color.Gray;
                txt_repassword.UseSystemPasswordChar = false;

            }
        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            if (txt_phone.Text == "Số điện thoại")
            {
                txt_phone.Text = "";
                txt_phone.ForeColor = Color.Black;
            }
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                txt_phone.Text = "Số điện thoại";
                txt_phone.ForeColor = Color.Gray;
            }
        }

        private void lbl_repassword_Click(object sender, EventArgs e)
        {

        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Họ và tên")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Họ và tên";
                txt_name.ForeColor = Color.Gray;
            }
        }
    }
}
 