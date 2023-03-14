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

namespace QLBreadtalk
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }






        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            btn_login.ForeColor = Color.White;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.ForeColor = Color.Black;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Tên đăng nhập")
            {
                panel6.Visible = true;
                return;
            }
            if (txt_mk.Text == "Nhập mật khẩu")
            {
                panel8.Visible = true;
                return;
            }
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLBreadtalk.mdf";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE username=@tk and pass=@mk", cnn);
            cmd.Parameters.AddWithValue("@tk", txt_username.Text);
            cmd.Parameters.AddWithValue("@mk", txt_mk.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                MessageBox.Show("Login succeeded");
            }
            else
            {
                dr.Close();
                MessageBox.Show("Failed to login");
                txt_username.Text = "";
                txt_mk.Text = "";
                return;
            }
            cnn.Close();
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

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Tên đăng nhập";
                txt_username.ForeColor = Color.Gray;
            }
        }

        private void txt_mk_Enter(object sender, EventArgs e)
        {
            txt_mk.PasswordChar = '*';
            if (txt_mk.Text == "Nhập mật khẩu")
            {
                txt_mk.Text = "";
                txt_mk.ForeColor = Color.Black; 
                txt_mk.UseSystemPasswordChar = true;
            }
        }

        private void txt_mk_Leave(object sender, EventArgs e)
        {
            if (txt_mk.Text == "")
            {
                txt_mk.Text = "Nhập mật khẩu";
                txt_mk.ForeColor = Color.Gray;
                txt_mk.UseSystemPasswordChar = false;

            }
        }

        private void lnk_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*this.Hide();*/
            fRegist fr = new fRegist(this);
            fr.ShowDialog();

        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnk_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
