using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string maKH;
        private string tenKH;
        private string tkKH;
        private string passKH;
        private string sdtKH;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string TkKH { get => tkKH; set => tkKH = value; }
        public string PassKH { get => passKH; set => passKH = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }

        public DTO_KhachHang(string maKH, string tenKH, string tkKH, string passKH, string sdtKH)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.tkKH = tkKH;
            this.passKH = passKH;
            this.sdtKH = sdtKH;
        }

        public DTO_KhachHang() { 

        }

    }
}
