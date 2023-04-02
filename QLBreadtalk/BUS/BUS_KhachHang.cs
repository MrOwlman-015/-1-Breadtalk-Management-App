using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAL.DAL_KhachHang dalKhachHang = new DAL.DAL_KhachHang();


        public bool checkPhoneUsed(string phone)
        {
            return dalKhachHang.checkPhoneUsed(phone);
        }

        public bool themKhachHang(DTO.DTO_KhachHang kh)
        {
            return dalKhachHang.themKhachHang(kh);
        }

        public bool suaKhachHang(DTO.DTO_KhachHang kh)
        {
            return dalKhachHang.suaKhachHang(kh);
        }

        public bool xoaKhachHang(DTO.DTO_KhachHang kh)
        {
            return dalKhachHang.xoaKhachHang(kh);
        }
    }
}
