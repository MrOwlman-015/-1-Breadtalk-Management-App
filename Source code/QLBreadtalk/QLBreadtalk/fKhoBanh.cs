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
using DTO;
namespace QLBreadtalk
{
    public partial class fKhoBanh : Form
    {
        BUS_KhoBanh kb = new BUS_KhoBanh();
        public fKhoBanh()
        {
            InitializeComponent();
        }

        private void SetEditingMode(bool enable)
        {
            txt_ID.Enabled = false;
            if (!enable)
            {
                dgv_KhoBanh.ClearSelection();
            }
            btn_Them.Enabled = !enable;
            btn_XoaTuyChon.Enabled = enable;
            btn_Xoa.Enabled = enable;
            btn_CapNhat.Enabled = enable;
        }

        private void fKhoBanh_Load(object sender, EventArgs e)
        {
            txt_ID.ReadOnly = true;
            nbr_SoLuongTon.Enabled = false;
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
            kb.bindGridView(dgv_KhoBanh);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int soLuongTon = Convert.ToInt32(nbr_SoLuongVao.Value) - Convert.ToInt32(nbr_SoLuongHong.Value);
            DTO_KhoBanh dTO_KhoBanh = new DTO_KhoBanh(0, txt_TenBanh.Text, soLuongTon, Convert.ToInt32(nbr_SoLuongXuat.Value), Convert.ToInt32(nbr_SoLuongVao.Value), Convert.ToInt32(nbr_SoLuongHong.Value));
            if (kb.themKhoBanh(dTO_KhoBanh))
            {
                kb.bindGridView(dgv_KhoBanh);
                MessageBox.Show("Thêm bánh thành công!");
            }
            else
            {
                MessageBox.Show("Thêm bánh thất bại!");
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            int soLuongTon = Convert.ToInt32(nbr_SoLuongVao.Value) - Convert.ToInt32(nbr_SoLuongHong.Value);
            DTO_KhoBanh dTO_KhoBanh = new DTO_KhoBanh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, soLuongTon, Convert.ToInt32(nbr_SoLuongXuat.Value), Convert.ToInt32(nbr_SoLuongVao.Value), Convert.ToInt32(nbr_SoLuongHong.Value));
            if (kb.suaKhoBanh(dTO_KhoBanh))
            {
                kb.bindGridView(dgv_KhoBanh);
                MessageBox.Show("Cập nhật bánh thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật bánh thất bại!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int soLuongTon = Convert.ToInt32(nbr_SoLuongVao.Value) - Convert.ToInt32(nbr_SoLuongHong.Value);
            DTO_KhoBanh dTO_KhoBanh = new DTO_KhoBanh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, soLuongTon, Convert.ToInt32(nbr_SoLuongXuat.Value), Convert.ToInt32(nbr_SoLuongVao.Value), Convert.ToInt32(nbr_SoLuongHong.Value));
            if (kb.xoaKhoBanh(dTO_KhoBanh))
            {
                kb.bindGridView(dgv_KhoBanh);
                MessageBox.Show("Xóa bánh thành công!");
            }
            else
            {
                MessageBox.Show("Xóa bánh thất bại!");
            }
        }

        private void btn_XoaTuyChon_Click(object sender, EventArgs e)
        {
            SetEditingMode(false);
            txt_ID.Text = "";
            txt_TenBanh.Text = "";
            nbr_SoLuongTon.Value = 0;
            nbr_SoLuongXuat.Value = 0;
            nbr_SoLuongVao.Value = 0;
            nbr_SoLuongHong.Value = 0;
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

        private void dgv_KhoBanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_KhoBanh.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_KhoBanh.Rows[e.RowIndex];

                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_TenBanh.Text = row.Cells[1].Value.ToString();
                nbr_SoLuongTon.Value = Convert.ToDecimal(row.Cells[2].Value);
                nbr_SoLuongXuat.Value = Convert.ToDecimal(row.Cells[3].Value);
                nbr_SoLuongVao.Value = Convert.ToDecimal(row.Cells[4].Value);
                nbr_SoLuongHong.Value = Convert.ToDecimal(row.Cells[5].Value);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            kb.bindGridViewbySearch(dgv_KhoBanh, txt_TimKiem.Text);
        }
    }
}
