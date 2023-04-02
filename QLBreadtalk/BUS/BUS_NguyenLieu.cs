using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_NguyenLieu
    {
        DAL.DAL_NguyenLieu dalNguyenLieu = new DAL.DAL_NguyenLieu();

        public DataTable getNguyenLieu()
        {
            return dalNguyenLieu.getNguyenLieu();
        }

        public bool themNguyenLieu(DTO.DTO_NguyenLieu nl)
        {
            return dalNguyenLieu.themNguyenLieu(nl);
        }

        public bool suaNguyenLieu(DTO.DTO_NguyenLieu nl)
        {
            return dalNguyenLieu.suaNguyenLieu(nl);
        }

        public bool xoaNguyenLieu(string nl_ID)
        {
            return dalNguyenLieu.xoaNguyenLieu(nl_ID);
        }
    }
}
