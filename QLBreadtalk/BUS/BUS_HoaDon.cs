using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL.DAL_HoaDon dalHoaDon = new DAL.DAL_HoaDon();

        public DataTable getHoaDon()
        {
            return dalHoaDon.getHoaDon();
        }

        public bool themHoaDon(DTO.DTO_HoaDon hd)
        {
            return dalHoaDon.themHoaDon(hd);
        }

        public bool suaHoaDon(DTO.DTO_HoaDon hd)
        {
            return dalHoaDon.suaHoaDon(hd);
        }

        public bool xoaHoaDon(string hd_ID)
        {
            return dalHoaDon.xoaHoaDon(hd_ID);
        }
    }
}
