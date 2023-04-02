using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhuyenMai
    {
        DAL.DAL_KhuyenMai dalKhuyenMai = new DAL.DAL_KhuyenMai();

        public DataTable getKhuyenMai()
        {
            return dalKhuyenMai.getKhuyenMai();
        }

        public bool themKhuyenMai(DTO.DTO_KhuyenMai km)
        {
            return dalKhuyenMai.themKhuyenMai(km);
        }

        public bool suaKhuyenMai(DTO.DTO_KhuyenMai km)
        {
            return dalKhuyenMai.suaKhuyenMai(km);
        }

        public bool xoaKhuyenMai(string km_ID)
        {
            return dalKhuyenMai.xoaKhuyenMai(km_ID);
        }
    }
}
