using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhoBanh
    {
        DAL.DAL_KhoBanh dalKhoBanh = new DAL.DAL_KhoBanh();

        public DataTable getKhoBanh()
        {
            return dalKhoBanh.getKhoBanh();
        }

        public bool themKhoBanh(DTO.DTO_KhoBanh kb)
        {
            return dalKhoBanh.themKhoBanh(kb);
        }

        public bool suaKhoBanh(DTO.DTO_KhoBanh kb)
        {
            return dalKhoBanh.suaKhoBanh(kb);
        }

        public bool xoaKhoBanh(string kb_ID)
        {
            return dalKhoBanh.xoaKhoBanh(kb_ID);
        }
    }
}
