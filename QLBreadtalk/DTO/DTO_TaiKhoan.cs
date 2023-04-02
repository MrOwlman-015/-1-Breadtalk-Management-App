using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string username;
        private string pass;
        private int loai;

        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Loai { get => loai; set => loai = value; }

        public DTO_TaiKhoan()
        {
        }

        public DTO_TaiKhoan(string username, string pass, int loai)
        {
            this.username = username;
            this.pass = pass;
            this.loai = loai;
        }
    }
}
