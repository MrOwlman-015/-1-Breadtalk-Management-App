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

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto_nv = new DTO_NhanVien(null, txt_name.Text, txt_phone.Text, 0);
            if (!nv.checkPhoneUsed(txt_phone.Text))
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
            txt_workshift.Enabled = false;
            nv.bindGridView(dgv_staff);
        }

        private void SetEditingMode(bool enable)
        {
            txt_ID.Enabled = false;
            if (!enable)
            {
                dgv_staff.ClearSelection();
            }
            btn_Them.Enabled = !enable;
            btn_Clear.Enabled = true;
            btn_Xoa.Enabled = enable;
            btn_Sua.Enabled = enable;
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Enabled = true;
            txt_workshift.Enabled = true;
            SetEditingMode(true);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                DataGridViewRow row = dgv_staff.Rows[e.RowIndex];

                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_name.Text = row.Cells[1].Value.ToString();
                txt_phone.Text = row.Cells[2].Value.ToString();
                txt_workshift.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_workshift.Text = "";
            SetEditingMode(false);
            txt_ID.Enabled = false;
            txt_workshift.Enabled = false;

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dto_nv = new DTO_NhanVien(txt_ID.Text, txt_name.Text, txt_phone.Text, Convert.ToInt32(txt_workshift.Text));
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
            DTO_NhanVien dto_nv = new DTO_NhanVien(txt_ID.Text, txt_name.Text, txt_phone.Text, Convert.ToInt32(txt_workshift.Text));
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
