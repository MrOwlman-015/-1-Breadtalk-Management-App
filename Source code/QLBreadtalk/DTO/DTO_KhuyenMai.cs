using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhuyenMai
    {
        private int maKhuyenMai;
        private string tenKM;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private int mabanh;

        public DTO_KhuyenMai()
        {
        }

        public DTO_KhuyenMai(int maKhuyenMai, string tenKM, DateTime ngayBatDau, DateTime ngayKetThuc, int mabanh)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.tenKM = tenKM;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.mabanh = mabanh;
        }

        public int MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public int Mabanh { get => mabanh; set => mabanh = value; }
    }
}
