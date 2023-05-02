using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DAL
{
    public class DAL_ChiTietHoaDon : DBConnection
    {
        public DataTable getChiTietHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon", conn);
            DataTable dtChiTietHoaDon = new DataTable();
            da.Fill(dtChiTietHoaDon);
            return dtChiTietHoaDon;
        }

        public void bindGridView(DataGridView dataGridView,int id)
        {
            conn.Open();
            string query = "SELECT * FROM chiTiet_Hoadon where maHoadon = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindGridViewbyID(DataGridView dataGridView, string cusid)
        {
            conn.Open();
            string query = "SELECT * FROM chiTiet_Hoadon where maHoadon in (select maHoadon from Hoadon where maKH = @id)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", cusid);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public int getTotalCash(int id)
        {
            conn.Open ();
            string query = "select soLuong, donGia from chiTiet_Hoadon where maHoadon = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue ("@id", id);
            int total = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                total += Convert.ToInt32(reader[0]) * Convert.ToInt32(reader[1]);
            }
            return total;
        }
        public bool themChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.chiTiet_Hoadon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maHD", cthd.MaHoadon);
            cmd.Parameters.AddWithValue("@maBanh", cthd.MaBanh);
            cmd.Parameters.AddWithValue("@soLuong", cthd.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", cthd.DonGia);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.dbo.chiTiet_Hoadon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@maHD", cthd.MaHoadon);
            cmd.Parameters.AddWithValue("@maBanh", cthd.MaBanh);
            cmd.Parameters.AddWithValue("@soLuong", cthd.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", cthd.DonGia);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.dbo.chiTiet_Hoadon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@maHD", cthd.MaHoadon);
            cmd.Parameters.AddWithValue("@maBanh", cthd.MaBanh);
            cmd.Parameters.AddWithValue("@soLuong", cthd.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", cthd.DonGia);

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
