using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL.DAL_TaiKhoan dalTaiKhoan = new DAL.DAL_TaiKhoan();

        public DataTable getTaiKhoan()
        {
            return dalTaiKhoan.getTaiKhoan();
        }

        public bool checkUsernameUsed(string username)
        {
            return dalTaiKhoan.checkUsernameUsed(username);
        }

        public int getTypeOfAccount(string account)
        {
            return dalTaiKhoan.getTypeOfAccount(account);
        }

       

        public bool checkLogIn(string username, string password)
        {
            DataTable da = dalTaiKhoan.getTaiKhoan();

            foreach (DataRow row in da.Rows)
            {
                string rowUsername = row["username"].ToString();
                string rowPassword = row["pass"].ToString();

                if (rowUsername == username && rowPassword == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
