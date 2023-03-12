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

namespace QLBreadtalk
{
    public partial class fRegist : Form
    {
        /*Form opener;*/
        public fRegist(Form opener)
        {
            InitializeComponent();
            opener = ParentForm;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\HOC TAP\PROJECT\hangthat\QLBreadtalk\QLBreadtalk\bin\Debug\TestQLBreadtalk.mdf"";Integrated Security=True;Connect Timeout=30;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE taikhoan=@tk", cnn);
            cmd.Parameters.AddWithValue("@tk", txt_username.Text.ToLower());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Username already used");
                dr.Close();
                return;
            }
            else
            {
                dr.Close();
                if (String.Compare(txt_password.Text, txt_repassword.Text) != 0)
                {
                    MessageBox.Show("Xac nhan mk sai");
                    txt_username.Text = "";
                    return;
                }
                SqlCommand cmd2 = new SqlCommand("INSERT INTO NhanVien values (@tennv, @taikhoan, @matkhau, @sdt);", cnn);
                cmd2.Parameters.AddWithValue("@tennv", "");
                cmd2.Parameters.AddWithValue("@taikhoan", txt_username.Text);
                cmd2.Parameters.AddWithValue("@matkhau", txt_password.Text);
                cmd2.Parameters.AddWithValue("@sdt", txt_phone.Text);
                int i = cmd2.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            cnn.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void txt_repassword_TextChanged(object sender, EventArgs e)
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
            }
        }

        private void txt_repassword_Enter(object sender, EventArgs e)
        {
            if (txt_repassword.Text == "Nhập lại mật khẩu")
            {
                txt_repassword.Text = "";
                txt_repassword.ForeColor = Color.Black;
            }
        }

        private void txt_repassword_Leave(object sender, EventArgs e)
        {
            if (txt_repassword.Text == "")
            {
                txt_repassword.Text = "Nhập lại mật khẩu";
                txt_repassword.ForeColor = Color.Gray;
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
    }
}
