using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NguyenLieu
    {
		private int maNL;
		private string tenNL;
		private int soLuong;
		private int donGia;
		private string donviTinh;

        public DTO_NguyenLieu()
        {
        }

        public DTO_NguyenLieu(int maNL, string tenNL, int soLuong, int donGia, string donviTinh)
        {
            this.maNL = maNL;
            this.tenNL = tenNL;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.donviTinh = donviTinh;
        }

        public int MaNL { get => maNL; set => maNL = value; }
        public string TenNL { get => tenNL; set => tenNL = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public string DonviTinh { get => donviTinh; set => donviTinh = value; }
    }
}
