using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DAL
{
    public class DAL_KhuyenMai : DBConnection
    {
        public DataTable getKhuyenMai()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhuyenMai", conn);
            DataTable dtKhuyenMai = new DataTable();
            da.Fill(dtKhuyenMai);
            return dtKhuyenMai;
        }


        public bool themKhuyenMai(DTO.DTO_KhuyenMai km)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhuyenMai_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maKhuyenMai", null);
            cmd.Parameters.AddWithValue("@tenKM", km.TenKM);
            cmd.Parameters.AddWithValue("@ngayBatDau", km.NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayKetThuc", km.NgayKetThuc);
            cmd.Parameters.AddWithValue("@mabanh", km.Mabanh);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaKhuyenMai(DTO.DTO_KhuyenMai km)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhuyenMai_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@maKhuyenMai", km.MaKhuyenMai);
            cmd.Parameters.AddWithValue("@tenKM", km.TenKM);
            cmd.Parameters.AddWithValue("@ngayBatDau", km.NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayKetThuc", km.NgayKetThuc);
            cmd.Parameters.AddWithValue("@mabanh", km.Mabanh);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaKhuyenMai(DTO_KhuyenMai km)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhuyenMai_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@maKhuyenMai", km.MaKhuyenMai);
            cmd.Parameters.AddWithValue("@tenKM", km.TenKM);
            cmd.Parameters.AddWithValue("@ngayBatDau", km.NgayBatDau);
            cmd.Parameters.AddWithValue("@ngayKetThuc", km.NgayKetThuc);
            cmd.Parameters.AddWithValue("@mabanh", km.Mabanh);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public void bindComboBox(System.Windows.Forms.ComboBox cbx)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT tenKM FROM KhuyenMai", conn);
            SqlDataReader reader = command.ExecuteReader();
            /*DataTable table = new DataTable();
            table.Load(reader);
            cbx.DataSource = table;*/
            while (reader.Read())
            {
                cbx.Items.Add(reader.GetString(0));
            }
        }
    }
}
