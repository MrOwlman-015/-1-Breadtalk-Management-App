using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CongThucBanh
    {
		private int maBanh;
		private int maNL;
		private int khoiLuong;
		private string donviTinh;

        public DTO_CongThucBanh()
        {
        }

        public DTO_CongThucBanh(int maBanh, int maNL, int khoiLuong, string donviTinh)
        {
            this.maBanh = maBanh;
            this.maNL = maNL;
            this.khoiLuong = khoiLuong;
            this.donviTinh = donviTinh;
        }

        public int MaBanh { get => maBanh; set => maBanh = value; }
        public int MaNL { get => maNL; set => maNL = value; }
        public int KhoiLuong { get => khoiLuong; set => khoiLuong = value; }
        public string DonviTinh { get => donviTinh; set => donviTinh = value; }
    }
}
