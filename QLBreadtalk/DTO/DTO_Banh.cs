using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Banh
    {
        private int maBanh;
        private string tenBanh;
        private int soLuong;
        private int donGia;
        private string maKhuyenMai;

        public DTO_Banh()
        {
        }

        public int MaBanh { get => maBanh; set => maBanh = value; }
        public string TenBanh { get => tenBanh; set => tenBanh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }

        public DTO_Banh(int maBanh, string tenBanh, int soLuong, int donGia, string maKhuyenMai)
        {
            this.maBanh = maBanh;
            this.tenBanh = tenBanh;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.maKhuyenMai = maKhuyenMai;
        }
    }
}
