using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLBreadtalk
{
    public partial class fNhanvien : Form
    {
        BUS.BUS_NhanVien nv = new BUS.BUS_NhanVien();
        public fNhanvien()
        {
            InitializeComponent();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            nv.bindGridViewbySearch(dgv_NhanVien, txt_TimKiem.Text);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto_nv = new DTO_NhanVien(null, txt_HoTen.Text, txt_Sdt.Text, 0);
            if (!nv.checkPhoneUsed(txt_Sdt.Text))
            {
                if (nv.themNhanVien(dto_nv))
                {
                    MessageBox.Show("Success");
                    this.fNhanvien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("Phone already in used.");
            }
        }

        private void fNhanvien_Load(object sender, EventArgs e)
        {
            txt_ID.Enabled = false;
            nbr_SoCaLam.Enabled = false;
            nv.bindGridView(dgv_NhanVien);
        }

        private void SetEditingMode(bool enable)
        {
            txt_ID.Enabled = false;
            if (!enable)
            {
                dgv_NhanVien.ClearSelection();
            }
            btn_Them.Enabled = !enable;
            btn_XoaTatCa.Enabled = true;
            btn_Xoa.Enabled = enable;
            btn_CapNhat.Enabled = enable;
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

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Enabled = true;
            nbr_SoCaLam.Enabled = true;
            SetEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_NhanVien.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_NhanVien.Rows[e.RowIndex];

                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_HoTen.Text = row.Cells[1].Value.ToString();
                txt_Sdt.Text = row.Cells[2].Value.ToString();
                nbr_SoCaLam.Value = Convert.ToDecimal(row.Cells[3].Value);
            }
        }

        private void btn_XoaTatCa_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_HoTen.Text = "";
            txt_Sdt.Text = "";
            nbr_SoCaLam.Value = 0;
            SetEditingMode(false);
            txt_ID.Enabled = false;
            nbr_SoCaLam.Enabled = false;

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto_nv = new DTO_NhanVien(txt_ID.Text, txt_HoTen.Text, txt_Sdt.Text, Convert.ToInt32(nbr_SoCaLam.Value));
            if (nv.suaNhanVien(dto_nv))
            {
                MessageBox.Show("Success");
                this.fNhanvien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto_nv = new DTO_NhanVien(txt_ID.Text, txt_HoTen.Text, txt_Sdt.Text, Convert.ToInt32(nbr_SoCaLam.Value));
            if (nv.xoaNhanVien(dto_nv))
            {
                MessageBox.Show("Success");
                this.fNhanvien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
