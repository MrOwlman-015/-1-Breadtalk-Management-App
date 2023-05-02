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
    public class DAL_HoaDon : DBConnection
    {
        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }

        public DataTable getDoanhThu(DateTime dateStart, DateTime dateEnd)
        {
            conn.Open();
            string sql = "SELECT CAST(ngayLap AS DATE) AS ngaylap, SUM(tongTien) AS doanhthu FROM Hoadon WHERE ngayLap BETWEEN @startDate AND @endDate GROUP BY CAST(ngayLap AS DATE)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@startDate", dateStart);
            cmd.Parameters.AddWithValue("@endDate", dateEnd);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();
            return dt;
        }



        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * FROM Hoadon";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindGridViewbyID(DataGridView dataGridView, string id) {
            conn.Open();
            string query = "select * from Hoadon where maKH = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue ("@id", id);
            SqlDataAdapter dv = new SqlDataAdapter (cmd);
            DataTable dt = new DataTable ();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }


        public int getCurrentMaHoaDon()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MAX(maHoadon) FROM Hoadon", conn);
            int currentMaHoaDon = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return currentMaHoaDon;
        }

        public bool themHoaDon(DTO.DTO_HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Hoadon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maHD", null);
            cmd.Parameters.AddWithValue("@maKH", hd.MaKH);
            cmd.Parameters.AddWithValue("@maNV", hd.MaNV);
            cmd.Parameters.AddWithValue("@maKhuyenMai", hd.MaKhuyenMai);
            cmd.Parameters.AddWithValue("@ngayLap", hd.NgayLap);
            cmd.Parameters.AddWithValue("@tongTien", hd.TongTien);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaHoaDon(DTO.DTO_HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Hoadon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@maHD", hd.MaHoadon);
            cmd.Parameters.AddWithValue("@maKH", hd.MaKH);
            cmd.Parameters.AddWithValue("@maNV", hd.MaNV);
            cmd.Parameters.AddWithValue("@maKhuyenMai", hd.MaKhuyenMai);
            cmd.Parameters.AddWithValue("@ngayLap", hd.NgayLap);
            cmd.Parameters.AddWithValue("@tongTien", hd.TongTien);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaHoaDon(DTO_HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Hoadon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@maHD", hd.MaHoadon);
            cmd.Parameters.AddWithValue("@maKH", hd.MaKH);
            cmd.Parameters.AddWithValue("@maNV", hd.MaNV);
            cmd.Parameters.AddWithValue("@maKhuyenMai", hd.MaKhuyenMai);
            cmd.Parameters.AddWithValue("@ngayLap", hd.NgayLap);
            cmd.Parameters.AddWithValue("@tongTien", hd.TongTien);
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
