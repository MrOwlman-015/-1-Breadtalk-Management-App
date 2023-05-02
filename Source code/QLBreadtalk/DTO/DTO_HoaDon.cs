using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private int maHoadon;
        private string maKH;
	    private string maNV;
        private DateTime ngayLap;
        private int maKhuyenMai;
        private int tongTien;

        public DTO_HoaDon()
        {
        }

        public DTO_HoaDon(int maHoadon, string maKH, string maNV, int maKhuyenMai, DateTime ngayLap, int tongTien)
        {
            this.MaHoadon = maHoadon;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.NgayLap = ngayLap;
            this.MaKhuyenMai = maKhuyenMai;
            this.TongTien = tongTien;
        }

        public int MaHoadon { get => maHoadon; set => maHoadon = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
