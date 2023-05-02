using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string maNV;
        private string hoTenNV;
        private string sdt;
        private int soCaLam;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int SoCaLam { get => soCaLam; set => soCaLam = value; }

        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(string maNV, string hoTenNV, string sdt, int soCaLam)
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.sdt = sdt;
            this.soCaLam = soCaLam;
        }
    }
}
