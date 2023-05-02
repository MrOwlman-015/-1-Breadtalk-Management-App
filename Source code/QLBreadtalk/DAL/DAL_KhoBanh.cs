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
    public class DAL_KhoBanh : DBConnection
    {
        public DataTable getKhoBanh()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhoBanh", conn);
            DataTable dtKhoBanh = new DataTable();
            da.Fill(dtKhoBanh);
            return dtKhoBanh;
        }

        public DataTable getKhoBanhbyID(int ID)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM KhoBanh where maBanh = @id", conn);
            cmd.Parameters.AddWithValue("@id", ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtKhoBanh = new DataTable();
            da.Fill(dtKhoBanh);
            conn.Close();
            return dtKhoBanh;
        }


        public bool themKhoBanh(DTO.DTO_KhoBanh kb)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhoBanh_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maBanh", kb.MaBanh);
            cmd.Parameters.AddWithValue("@tenBanh", kb.TenBanh);
            cmd.Parameters.AddWithValue("@soLuongTon", kb.SoLuongTon);
            cmd.Parameters.AddWithValue("@soLuongXuat", kb.SoLuongXuat);
            cmd.Parameters.AddWithValue("@soLuongVao", kb.SoLuongVao);
            cmd.Parameters.AddWithValue("@soBanhHong", kb.SoBanhHong);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaKhoBanh(DTO.DTO_KhoBanh kb)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhoBanh_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@maBanh", kb.MaBanh);
            cmd.Parameters.AddWithValue("@tenBanh", kb.TenBanh);
            cmd.Parameters.AddWithValue("@soLuongTon", kb.SoLuongTon);
            cmd.Parameters.AddWithValue("@soLuongXuat", kb.SoLuongXuat);
            cmd.Parameters.AddWithValue("@soLuongVao", kb.SoLuongVao);
            cmd.Parameters.AddWithValue("@soBanhHong", kb.SoBanhHong);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaKhoBanh(DTO_KhoBanh kb)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.KhoBanh_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@maBanh", kb.MaBanh);
            cmd.Parameters.AddWithValue("@tenBanh", kb.TenBanh);
            cmd.Parameters.AddWithValue("@soLuongTon", kb.SoLuongTon);
            cmd.Parameters.AddWithValue("@soLuongXuat", kb.SoLuongXuat);
            cmd.Parameters.AddWithValue("@soLuongVao", kb.SoLuongVao);
            cmd.Parameters.AddWithValue("@soBanhHong", kb.SoBanhHong);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * from KhoBanh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from KhoBanh where tenBanh like '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
