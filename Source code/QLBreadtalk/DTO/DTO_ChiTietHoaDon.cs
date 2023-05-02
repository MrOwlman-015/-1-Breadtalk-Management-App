using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietHoaDon
    {
        private int maHoadon;
        private int maBanh;
        private int soLuong;
        private int donGia;

        public DTO_ChiTietHoaDon()
        {
        }

        public DTO_ChiTietHoaDon(int maHoadon, int maBanh, int soLuong, int donGia)
        {
            this.maHoadon = maHoadon;
            this.maBanh = maBanh;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public int MaHoadon { get => maHoadon; set => maHoadon = value; }
        public int MaBanh { get => maBanh; set => maBanh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
    }
}
