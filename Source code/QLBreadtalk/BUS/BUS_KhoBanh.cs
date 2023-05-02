using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_KhoBanh
    {
        DAL.DAL_KhoBanh dalKhoBanh = new DAL.DAL_KhoBanh();

        public DataTable getKhoBanh()
        {
            return dalKhoBanh.getKhoBanh();
        }

        public DataTable getKhoBanhbyID(int ID)
        {
            return dalKhoBanh.getKhoBanhbyID(ID);
        }

        public bool themKhoBanh(DTO.DTO_KhoBanh kb)
        {
            return dalKhoBanh.themKhoBanh(kb);
        }

        public bool suaKhoBanh(DTO.DTO_KhoBanh kb)
        {
            return dalKhoBanh.suaKhoBanh(kb);
        }

        public bool xoaKhoBanh(DTO.DTO_KhoBanh kb)
        {
            return dalKhoBanh.xoaKhoBanh(kb);
        }

        public void bindGridView(DataGridView gridView)
        {
            dalKhoBanh.bindGridView(gridView);
        }

        public void bindGridViewbySearch(DataGridView gridView, string name)
        {
            dalKhoBanh.bindGridViewbySearch(gridView, name);
        }
    }
}
