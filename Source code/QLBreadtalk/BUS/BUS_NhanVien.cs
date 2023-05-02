using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_NhanVien
    {
        DAL.DAL_NhanVien dalNhanVien = new DAL.DAL_NhanVien();

        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }

        public bool checkPhoneUsed(string phone)
        {
            return dalNhanVien.checkPhoneUsed(phone);
        }

        public void bindGridView(DataGridView dv)
        {
            dalNhanVien.bindGridView(dv);
        }

        public void bindGridViewbySearch(DataGridView dv, string name)
        {
            dalNhanVien .bindGridViewbySearch(dv, name);
        }

        public bool themNhanVien(DTO.DTO_NhanVien nv)
        {
            return dalNhanVien.themNhanVien(nv);
        }

        public bool suaNhanVien(DTO.DTO_NhanVien nv)
        {
            return dalNhanVien.suaNhanVien(nv);
        }

        public bool xoaNhanVien(DTO.DTO_NhanVien nv)
        {
            return dalNhanVien.xoaNhanVien(nv);
        }
    }
}
