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
    public partial class fThemBanh : Form
    {
        BUS_KhoBanh kb = new BUS_KhoBanh();
        public fThemBanh()
        {
            InitializeComponent();
        }

        private void fThemBanh_Load(object sender, EventArgs e)
        {
            txt_ID.ReadOnly = true;
            txt_TenBanh.ReadOnly = true;
            kb.bindGridView(dgv_Banh);
            SetEditingMode(false);
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

        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                dgv_Banh.ClearSelection();
            }
            btn_Them.Enabled = enable;
            btn_XoaTuyChon.Enabled = enable;
        }

        private void dgv_Banh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !isRowNullOrEmpty(dgv_Banh.Rows[e.RowIndex]))
            {
                DataGridViewRow row = dgv_Banh.Rows[e.RowIndex];

                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_TenBanh.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btn_XoaTuyChon_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_TenBanh.Text = "";
            nbr_DonGia.Value = 0;
            nbr_SoLuong.Value = 0;
            SetEditingMode(false);
        }

        private bool checkEmpty()
        {
            if (txt_ID.Text == "" && txt_TenBanh.Text == "")
            {
                return true;
            }
            return false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                DTO_Banh dTO_Banh = new DTO_Banh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, Convert.ToInt32(nbr_SoLuong.Value), Convert.ToInt32(nbr_DonGia.Value));
                BUS_Banh bh = new BUS_Banh();

                if (Convert.ToInt32(nbr_DonGia.Value) <= 0 || Convert.ToInt32(nbr_SoLuong.Value) <= 0)
                {
                    MessageBox.Show("Đơn giá hoặc số lượng không được bé hơn hoặc bằng 0!");
                    return;
                }
                else
                {
                    DataTable da0 = kb.getKhoBanhbyID(Convert.ToInt32(txt_ID.Text));
                    DataRow row0 = da0.Rows[0];
                    int soBanhTon0 = (int)(row0["soLuongTon"]);
                    if (soBanhTon0 < Convert.ToInt32(nbr_SoLuong.Value))
                    {
                        MessageBox.Show("Số lượng nhập vào không được lớn hơn số lượng bánh tồn trong kho!");
                        return;
                    }
                    else
                    {
                        if (!bh.checkBanhbyID(Convert.ToInt32(txt_ID.Text)))
                        {
                            if (bh.themBanh(dTO_Banh))
                            {
                                MessageBox.Show("Thêm bánh thành công!");
                                DataTable da = kb.getKhoBanhbyID(Convert.ToInt32(txt_ID.Text));
                                DataRow row = da.Rows[0];
                                int soBanhTon = (int)(row["soLuongTon"]);
                                int soBanhXuat = (int)(row["soLuongXuat"]);
                                int soBanhVao = (int)(row["soLuongVao"]);
                                int soBanhHong = (int)(row["soBanhHong"]);
                                DTO_KhoBanh kb2 = new DTO_KhoBanh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, soBanhTon - Convert.ToInt32(nbr_SoLuong.Value), soBanhXuat + Convert.ToInt32(nbr_SoLuong.Value), soBanhVao, soBanhHong);
                                kb.suaKhoBanh(kb2);
                                kb.bindGridView(dgv_Banh);
                            }
                            else
                            {
                                MessageBox.Show("Thêm bánh thất bại!");
                                return;
                            }
                        }
                        else
                        {
                            DataTable da_banh = bh.getBanhbyID(Convert.ToInt32(txt_ID.Text));
                            DataRow row_banh = da_banh.Rows[0];
                            int soLuong = (int)(row_banh["soLuong"]);
                            dTO_Banh.SoLuong += soLuong;
                            if (bh.suaBanh(dTO_Banh))
                            {
                                MessageBox.Show("Thêm bánh thành công!");
                                DataTable da = kb.getKhoBanhbyID(Convert.ToInt32(txt_ID.Text));
                                DataRow row = da.Rows[0];
                                int soBanhTon = (int)(row["soLuongTon"]);
                                int soBanhXuat = (int)(row["soLuongXuat"]);
                                int soBanhVao = (int)(row["soLuongVao"]);
                                int soBanhHong = (int)(row["soBanhHong"]);
                                DTO_KhoBanh kb2 = new DTO_KhoBanh(Convert.ToInt32(txt_ID.Text), txt_TenBanh.Text, soBanhTon - Convert.ToInt32(nbr_SoLuong.Value), soBanhXuat + Convert.ToInt32(nbr_SoLuong.Value), soBanhVao, soBanhHong);
                                kb.suaKhoBanh(kb2);
                                kb.bindGridView(dgv_Banh);
                            }
                            else
                            {
                                MessageBox.Show("Thêm bánh thất bại!");
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Thêm bánh thất bại!");
                return;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            kb.bindGridViewbySearch(dgv_Banh, txt_TimKiem.Text);
        }
    }
}
