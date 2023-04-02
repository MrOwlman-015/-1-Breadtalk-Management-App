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
        private int tongTien;

        public DTO_HoaDon()
        {
        }

        public DTO_HoaDon(int maHoadon, string maKH, string maNV, DateTime ngayLap, int tongTien)
        {
            this.maHoadon = maHoadon;
            this.maKH = maKH;
            this.maNV = maNV;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
        }

        public int MaHoadon { get => maHoadon; set => maHoadon = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }


    }
}
