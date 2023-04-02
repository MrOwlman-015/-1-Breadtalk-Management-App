using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_NhanVien : DBConnection
    {
        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }

        public bool checkPhoneUsed(string phone)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from NhanVien where sdt = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            DTO_NhanVien nv = null;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nv = new DTO_NhanVien();
                nv.MaNV = (string)reader["maNV"];
                nv.HoTenNV = (string)reader["hotenNV"];
                nv.Sdt = (string)reader["sdt"];
                nv.SoCaLam = (int)reader["soCaLam"];
            }
            reader.Close();
            conn.Close();
            if (nv == null)
            {
                return false;
            }
            return true;
        }
        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT maNV, hotenNV, sdt, soCaLam from NhanVien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }


        public bool themNhanVien(DTO.DTO_NhanVien nv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.NhanVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maNV", null);
            cmd.Parameters.AddWithValue("@hotenNV", nv.HoTenNV);
            cmd.Parameters.AddWithValue("@sdt", nv.Sdt);
            cmd.Parameters.AddWithValue("@soCaLam", nv.SoCaLam);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaNhanVien(DTO.DTO_NhanVien nv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.NhanVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@maNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@hotenNV", nv.HoTenNV);
            cmd.Parameters.AddWithValue("@sdt", nv.Sdt);
            cmd.Parameters.AddWithValue("@soCaLam", nv.SoCaLam);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaNhanVien(DTO.DTO_NhanVien nv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.NhanVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@maNV", nv.MaNV);
            cmd.Parameters.AddWithValue("@hotenNV", nv.HoTenNV);
            cmd.Parameters.AddWithValue("@sdt", nv.Sdt);
            cmd.Parameters.AddWithValue("@soCaLam", nv.SoCaLam);
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
