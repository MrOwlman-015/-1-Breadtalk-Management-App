using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CongThucBanh
    {
        DAL.DAL_CongThucBanh dalCongThucBanh = new DAL.DAL_CongThucBanh();

        public DataTable getCongThucBanh()
        {
            return dalCongThucBanh.getCongThucBanh();
        }

        public bool themCongThucBanh(DTO.DTO_CongThucBanh ctbh)
        {
            return dalCongThucBanh.themCongThucBanh(ctbh);
        }

        public bool suaCongThucBanh(DTO.DTO_CongThucBanh ctbh)
        {
            return dalCongThucBanh.suaCongThucBanh(ctbh);
        }

        public bool xoaCongThucBanh(string ctbh_ID)
        {
            return dalCongThucBanh.xoaCongThucBanh(ctbh_ID);
        }
    }
}
