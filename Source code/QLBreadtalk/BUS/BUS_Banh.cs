using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_Banh
    {
        DAL.DAL_Banh dalBanh = new DAL.DAL_Banh();

        public bool checkBanhbyID(int ID)
        {
            return dalBanh.checkBanhbyID(ID);
        }

        public int getSoLuong(int id)
        {
            return dalBanh.getSoLuong(id);
        }

        public DataTable getBanhbyID(int ID)
        {
            return dalBanh.getBanhbyID(ID);
        }

        public bool truBanh(int id, int soLuong)
        {
            return dalBanh.truBanh(id, soLuong);
        }

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

        public void bindGridView(DataGridView dataGridView)
        {
            dalBanh.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            dalBanh.bindGridViewbySearch(dataGridView, name);
        }
    }
}
