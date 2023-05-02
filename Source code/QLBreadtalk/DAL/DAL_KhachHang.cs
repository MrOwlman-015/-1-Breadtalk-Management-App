using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.IO;

namespace DAL
{
    public class DAL_KhachHang : DBConnection
    {
        public string getID(string username, string pass)
        {
            conn.Open();
            string query = "select maKH from KhachHang where username = @username and pass = @pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string id = reader.GetString(0);
            conn.Close();
            return id;
        }

        public string getIDbyPhone(string phone)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from KhachHang where sdt = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();
                string id = (string)sqlDataReader.GetString(0);
                sqlDataReader.Close();
                conn.Close();
                return id;
            }
            else
            {
                DTO_KhachHang kh = new DTO_KhachHang(null, "", phone, phone, phone);
                conn.Close();
                this.themKhachHang(kh);
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT * from KhachHang where sdt = @phone", conn);
                cmd2.Parameters.AddWithValue("@phone", phone);
                SqlDataReader reader = cmd2.ExecuteReader();
                reader.Read();
                string id = (string)reader.GetString(0);
                reader.Close();
                conn.Close();
                return id;
            }
        }

        public bool checkPhoneUsed(string phone)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from KhachHang where sdt = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            DTO_KhachHang kh = null;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                kh = new DTO_KhachHang();
                kh.MaKH = (string)reader["maKH"];
                kh.TenKH = (string)reader["tenKH"];
                kh.TkKH = (string)reader["username"];
                kh.PassKH = (string)reader["pass"];
                kh.SdtKH = (string)reader["sdt"];
            }
            reader.Close();
            conn.Close();
            if (kh == null)
            {
                return false;
            }
            return true;
        }


        public bool themKhachHang(DTO.DTO_KhachHang kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Khachhang_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maKH", null);
            cmd.Parameters.AddWithValue("@tenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@username", kh.TkKH);
            cmd.Parameters.AddWithValue("@pass", kh.PassKH);
            cmd.Parameters.AddWithValue("@sdt", kh.SdtKH);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;

        }


        public bool suaKhachHang(DTO.DTO_KhachHang kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Khachhang_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@maKH", null);
            cmd.Parameters.AddWithValue("@tenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@username", kh.TkKH);
            cmd.Parameters.AddWithValue("@pass", kh.PassKH);
            cmd.Parameters.AddWithValue("@sdt", kh.SdtKH);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaKhachHang(DTO.DTO_KhachHang kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Khachhang_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@maKH", null);
            cmd.Parameters.AddWithValue("@tenKH", kh.TenKH);
            cmd.Parameters.AddWithValue("@username", kh.TkKH);
            cmd.Parameters.AddWithValue("@pass", kh.PassKH);
            cmd.Parameters.AddWithValue("@sdt", kh.SdtKH);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
