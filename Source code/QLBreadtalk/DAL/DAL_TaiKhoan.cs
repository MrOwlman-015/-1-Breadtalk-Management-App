using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TaiKhoan : DBConnection
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tai_khoan", conn);
            DataTable dtTaiKhoan = new DataTable();
            da.Fill(dtTaiKhoan);
            return dtTaiKhoan;
        }

        public bool checkUsernameUsed(string username)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Tai_khoan where username = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);
            DTO_TaiKhoan tk = null;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tk = new DTO_TaiKhoan();
                tk.Username = (string)reader["username"];
                tk.Pass = (string)reader["pass"];
                tk.Loai = (int)reader["loai"];
            }
            reader.Close();
            if (tk == null)
            {
                return false;
            }
            return true;
        }

        public int getTypeOfAccount(string username)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Tai_khoan where username = @username", conn);
            cmd.Parameters.AddWithValue ("@username", username);
            SqlDataReader reader = cmd.ExecuteReader();
            int loai = 0;
            if (reader.Read())
            {
                loai = (int)reader["Loai"];
            }
            conn.Close();
            return loai;
        }

    }
}
