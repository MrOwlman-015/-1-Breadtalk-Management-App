using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhoBanh
    {
		private int maBanh;
		private string tenBanh;
		private int soLuongTon;
		private int soLuongXuat;
		private int soLuongVao;
		private int soBanhHong = 0;

        public DTO_KhoBanh()
        {
        }

        public DTO_KhoBanh(int maBanh, string tenBanh, int soLuongTon, int soLuongXuat, int soLuongVao, int soBanhHong)
        {
            this.maBanh = maBanh;
            this.tenBanh = tenBanh;
            this.soLuongTon = soLuongTon;
            this.soLuongXuat = soLuongXuat;
            this.soLuongVao = soLuongVao;
            this.soBanhHong = soBanhHong;
        }

        public int MaBanh { get => maBanh; set => maBanh = value; }
        public string TenBanh { get => tenBanh; set => tenBanh = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public int SoLuongXuat { get => soLuongXuat; set => soLuongXuat = value; }
        public int SoLuongVao { get => soLuongVao; set => soLuongVao = value; }
        public int SoBanhHong { get => soBanhHong; set => soBanhHong = value; }
    }
}
