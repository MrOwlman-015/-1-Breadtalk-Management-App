using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Banh : DBConnection
    {
        public DataTable getBanh()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Banh", conn);
            DataTable dtBanh = new DataTable();
            da.Fill(dtBanh);
            return dtBanh;
        }


        public bool themBanh(DTO.DTO_Banh bh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Banh_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maBanh", null);
            cmd.Parameters.AddWithValue("@tenBanh", bh.TenBanh);
            cmd.Parameters.AddWithValue("@soLuong", bh.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", bh.DonGia);
            cmd.Parameters.AddWithValue("@maKhuyenMai", bh.MaKhuyenMai);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaBanh(DTO.DTO_Banh bh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Banh_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@maBanh", null);
            cmd.Parameters.AddWithValue("@tenBanh", bh.TenBanh);
            cmd.Parameters.AddWithValue("@soLuong", bh.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", bh.DonGia);
            cmd.Parameters.AddWithValue("@maKhuyenMai", bh.MaKhuyenMai);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaBanh(DTO.DTO_Banh bh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Banh_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@maBanh", null);
            cmd.Parameters.AddWithValue("@tenBanh", bh.TenBanh);
            cmd.Parameters.AddWithValue("@soLuong", bh.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", bh.DonGia);
            cmd.Parameters.AddWithValue("@maKhuyenMai", bh.MaKhuyenMai);
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
