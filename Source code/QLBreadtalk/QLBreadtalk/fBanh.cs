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

namespace QLBreadtalk
{
    public partial class fBanh : Form
    {
        BUS_Banh bh = new BUS_Banh();
        public fBanh()
        {
            InitializeComponent();
        }

        private void fBanh_Load(object sender, EventArgs e)
        {
            txt_ID.Enabled = false;
            bh.bindGridView(dgv_Banh);
        }

        private void SetEditingMode(bool enable)
        {
            txt_ID.Enabled = false;
            if (!enable)
            {
                dgv_Banh.ClearSelection();
            }
            btn_Them.Enabled = !enable;
            btn_XoaTuyChon.Enabled = enable;
            btn_Xoa.Enabled = enable;
            btn_CapNhat.Enabled = enable;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            /*DTO_Banh dto_Banh = new DTO_Banh(0, txt_TenBanh.Text, (int)nbr_GiaTien.Value, (int)nbr_SoLuong.Value);
            if (bh.themBanh(dto_Banh))
            {
                bh.bindGridView(dgv_Banh);
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Fail");
            }*/
            fThemBanh f = new fThemBanh();
            this.Hide();
            f.ShowDialog();
            bh.bindGridView(dgv_Banh);
            this.Show();
        }

        private void btn_XoaTuyChon_Click(object sender, EventArgs e)
        {
            SetEditingMode(false);
            txt_ID.Text = "";
            txt_TenBanh.Text = "";
            nbr_GiaTien.Value = 0;
            nbr_SoLuong.Value = 0;
        }

        private bool checkEmpty()
        {
            if (txt_ID.Text == "" && txt_TenBanh.Text == "")
            {
                return true;
            }
            return false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                DTO_Banh dto_Banh = new DTO_Banh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, (int)nbr_GiaTien.Value, (int)nbr_SoLuong.Value);
                if (bh.suaBanh(dto_Banh))
                {
                    bh.bindGridView(dgv_Banh);
                    MessageBox.Show("Thành công!");
                    btn_XoaTuyChon_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy đảm bảo đầy đủ các thông tin trước khi thực hiện thao tác!");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                DTO_Banh dto_Banh = new DTO_Banh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, (int)nbr_GiaTien.Value, (int)nbr_SoLuong.Value);

                if (bh.xoaBanh(dto_Banh))
                {
                    /*BUS_KhoBanh kb = new BUS_KhoBanh();
                    DataTable da = kb.getKhoBanhbyID(Convert.ToInt32(txt_ID.Text));
                    DataRow row = da.Rows[0];
                    int soBanhTon = (int)(row["soLuongTon"]);
                    int soBanhXuat = (int)(row["soLuongXuat"]);
                    int soBanhVao = (int)(row["soLuongVao"]);
                    int soBanhHong = (int)(row["soBanhHong"]);
                    DTO_KhoBanh dTO_KhoBanh = new DTO_KhoBanh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, soBanhTon, soBanhXuat, soBanhVao, soBanhHong);
                    if (kb.xoaKhoBanh(dTO_KhoBanh))
                    {
                        bh.bindGridView(dgv_Banh);
                        MessageBox.Show("Thành công!");
                        btn_XoaTuyChon_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại!");
                    }*/
                    bh.bindGridView(dgv_Banh);
                    MessageBox.Show("Thành công!");
                    btn_XoaTuyChon_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy đảm bảo đầy đủ các thông tin trước khi thực hiện thao tác!");
            }
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

        private void dgv_Banh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_Banh.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_Banh.Rows[e.RowIndex];

                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_TenBanh.Text = row.Cells[1].Value.ToString();
                nbr_GiaTien.Value = Convert.ToDecimal(row.Cells[3].Value);
                nbr_SoLuong.Value = Convert.ToDecimal(row.Cells[2].Value);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bh.bindGridViewbySearch(dgv_Banh, txt_TimKiem.Text);
        }
    }
}
