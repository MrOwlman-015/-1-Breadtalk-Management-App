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

namespace QLBreadtalk
{
    public partial class fBillHistory : Form
    {
        BUS_HoaDon hd = new BUS_HoaDon();
        private string id;
        public fBillHistory(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private bool isRowNullOrEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value == null || cell.Value == DBNull.Value)
                {
                    return true;
                }

                if (cell.Value is string str && string.IsNullOrEmpty(str))
                {
                    return true;
                }
            }

            return false;
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_HoaDon.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_HoaDon.Rows[e.RowIndex];

                txt_MaHD.Text = row.Cells[0].Value.ToString();
                txt_MaKH.Text = row.Cells[1].Value.ToString();
                txt_MaNV.Text = row.Cells[2].Value.ToString();
                txt_MaKM.Text = row.Cells[3].Value.ToString();
                dtp_NgayLap.Value = Convert.ToDateTime(row.Cells[4].Value);
                txt_TongTien.Text = row.Cells[5].Value.ToString();
            }
            dgv_ChiTietHD.DataSource = null;
        }

        private void fBillHistory_Load(object sender, EventArgs e)
        {
            hd.bindGridViewbyID(dgv_HoaDon, this.id);

            txt_MaHD.ReadOnly = true;
            txt_MaKH.ReadOnly = true;
            txt_MaNV.ReadOnly = true;
            txt_MaKM.ReadOnly = true;
            txt_TongTien.ReadOnly = true;
            dtp_NgayLap.Enabled = false;
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            BUS_ChiTietHoaDon cthd = new BUS_ChiTietHoaDon();
            int cusid = Convert.ToInt32(txt_MaHD.Text);
            /*string cusid = this.id;*/
            cthd.bindGridView(dgv_ChiTietHD, cusid);
        }

        private void btn_XoaTuyChon_Click(object sender, EventArgs e)
        {
            dgv_HoaDon.ClearSelection();
            txt_MaHD.Text = "";
            txt_MaKH.Text = "";
            txt_MaNV.Text = "";
            txt_MaKM.Text = "";
            dtp_NgayLap.Value = DateTime.Now;
            txt_TongTien.Text = "";
        }
    }
}
