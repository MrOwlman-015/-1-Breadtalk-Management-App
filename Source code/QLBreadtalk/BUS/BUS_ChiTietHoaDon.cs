using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ChiTietHoaDon
    {
        DAL.DAL_ChiTietHoaDon dalChiTietHoaDon = new DAL.DAL_ChiTietHoaDon();

        public DataTable getChiTietHoaDon()
        {
            return dalChiTietHoaDon.getChiTietHoaDon();
        }

        public int getTotalCash(int id)
        {
            return dalChiTietHoaDon.getTotalCash(id);
        }

        public void bindGridView(DataGridView dataGridView, int id)
        {
            dalChiTietHoaDon.bindGridView(dataGridView, id);
        }

        public void bindGridViewbyID(DataGridView dataGridView, string cusid)
        {
            dalChiTietHoaDon.bindGridViewbyID(dataGridView, cusid);
        }

        public bool themChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            return dalChiTietHoaDon.themChiTietHoaDon(cthd);
        }

        public bool suaChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            return dalChiTietHoaDon.suaChiTietHoaDon(cthd);
        }

        public bool xoaChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            return dalChiTietHoaDon.xoaChiTietHoaDon(cthd);
        }
    }
}
