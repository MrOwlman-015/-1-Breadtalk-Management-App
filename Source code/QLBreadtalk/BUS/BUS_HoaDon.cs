using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL.DAL_HoaDon dalHoaDon = new DAL.DAL_HoaDon();

        public DataTable getHoaDon()
        {
            return dalHoaDon.getHoaDon();
        }

        public void bindGridView(DataGridView gridView)
        {
            dalHoaDon.bindGridView(gridView);
        }

        public void bindGridViewbyID(DataGridView gridView, string id) {
            dalHoaDon.bindGridViewbyID(gridView, id);
        }

        public int getCurrentMaHoaDon()
        {
            return dalHoaDon.getCurrentMaHoaDon();
        }

        public bool themHoaDon(DTO.DTO_HoaDon hd)
        {
            return dalHoaDon.themHoaDon(hd);
        }

        public bool suaHoaDon(DTO.DTO_HoaDon hd)
        {
            return dalHoaDon.suaHoaDon(hd);
        }

        public bool xoaHoaDon(DTO.DTO_HoaDon hd)
        {
            return dalHoaDon.xoaHoaDon(hd);
        }

        public DataTable getDoanhThu(DateTime dateStart, DateTime dateEnd)
        {
            return dalHoaDon.getDoanhThu(dateStart, dateEnd);
        }
    }
}
