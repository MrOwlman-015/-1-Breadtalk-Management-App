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

namespace QuanLyBanHang
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLBreadtalk.mdf";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE username=@tk and pass=@mk", cnn);
            cmd.Parameters.AddWithValue("@tk", txtNameAccount.Text);
            cmd.Parameters.AddWithValue("@mk", txtPassWord.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                fMenu f = new fMenu();
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Incorrect username or password. Try again!");
                txtNameAccount.Text = "";
                txtPassWord.Text = "";
                return;
            }
            cnn.Close();


        }
    }
}
