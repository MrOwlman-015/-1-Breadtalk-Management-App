using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL.DAL_ChiTietHoaDon dalChiTietHoaDon = new DAL.DAL_ChiTietHoaDon();

        public DataTable getChiTietHoaDon()
        {
            return dalChiTietHoaDon.getChiTietHoaDon();
        }

        public bool themChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            return dalChiTietHoaDon.themChiTietHoaDon(cthd);
        }

        public bool suaChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            return dalChiTietHoaDon.suaChiTietHoaDon(cthd);
        }

        public bool xoaChiTietHoaDon(string cthd_ID)
        {
            return dalChiTietHoaDon.xoaChiTietHoaDon(cthd_ID);
        }
    }
}
