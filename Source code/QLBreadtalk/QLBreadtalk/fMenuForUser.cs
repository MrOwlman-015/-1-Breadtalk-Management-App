using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBreadtalk
{
    public partial class fMenuForUser : Form
    {
        private string id;
        public fMenuForUser(string id)
        {
            InitializeComponent();
            /*this.WindowState = FormWindowState.Maximized;*/
            this.id = id;
        }

        private void btn_LsDonHang_Click(object sender, EventArgs e)
        {
            fBillHistory f = new fBillHistory(this.id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
