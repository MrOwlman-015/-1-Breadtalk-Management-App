using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Banh
    {
        DAL.DAL_Banh dalBanh = new DAL.DAL_Banh();

        public DataTable getBanh()
        {
            return dalBanh.getBanh();
        }

        public bool themBanh(DTO.DTO_Banh bh)
        {
            return dalBanh.themBanh(bh);
        }

        public bool suaBanh(DTO.DTO_Banh bh)
        {
            return dalBanh.suaBanh(bh);
        }

        public bool xoaBanh(DTO.DTO_Banh bh)
        {
            return dalBanh.xoaBanh(bh);
        }
    }
}
