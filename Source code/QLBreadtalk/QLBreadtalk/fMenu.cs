using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBreadtalk
{
    public partial class fMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        /*private Form activeForm;*/

        public fMenu()
        {
            InitializeComponent();
            /*this.WindowState = FormWindowState.Maximized;*/
            random = new Random();
            btnExitMenu.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Times New Roman", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnl_Home.BackColor = color;
                    pnl_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnExitMenu.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(50, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btn_Banh_Click(object sender, EventArgs e)
        {
            fBanh f = new fBanh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            fLaphoadon f = new fLaphoadon();
            this.Hide(); f.ShowDialog();
            this.Show();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            fNhanvien f = new fNhanvien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_KhoBanh_Click(object sender, EventArgs e)
        {
            fKhoBanh f = new fKhoBanh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            fDoanhthu f = new fDoanhthu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        /*private void button6_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }*/
        /*private void Reset()
        {
            DisableButton();
            lbl_Home.Text = "HOME";
            pnl_Home.BackColor = Color.FromArgb(123, 121, 121);
            pnl_Logo.BackColor = Color.FromArgb(39, 38, 60);
            currentButton = null;
            btnExitMenu.Visible = false;
        }*/

        private void panelHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
