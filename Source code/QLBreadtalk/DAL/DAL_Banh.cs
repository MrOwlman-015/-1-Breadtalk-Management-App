using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Banh : DBConnection
    {
        public bool checkBanhbyID(int ID)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Banh where maBanh = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return true;
            }
            reader.Close();
            conn.Close();
            return false;
        }

        public DataTable getBanhbyID(int ID)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Banh where maBanh = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable getBanh()
        {
            conn.Open ();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Banh", conn);
            DataTable dtBanh = new DataTable();
            da.Fill(dtBanh);
            conn.Close();
            return dtBanh;
        }


        public bool themBanh(DTO.DTO_Banh bh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.Banh_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@maBanh", bh.MaBanh);
            cmd.Parameters.AddWithValue("@tenBanh", bh.TenBanh);
            cmd.Parameters.AddWithValue("@soLuong", bh.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", bh.DonGia);
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
            cmd.Parameters.AddWithValue("@maBanh", bh.MaBanh);
            cmd.Parameters.AddWithValue("@tenBanh", bh.TenBanh);
            cmd.Parameters.AddWithValue("@soLuong", bh.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", bh.DonGia);
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
            cmd.Parameters.AddWithValue("@maBanh", bh.MaBanh);
            cmd.Parameters.AddWithValue("@tenBanh", bh.TenBanh);
            cmd.Parameters.AddWithValue("@soLuong", bh.SoLuong);
            cmd.Parameters.AddWithValue("@donGia", bh.DonGia);
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
            string query = "SELECT * from Banh";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public int getSoLuong(int id)
        {
            conn.Open();
            string query = "select soLuong from Banh where maBanh = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int soluong = Convert.ToInt32(reader[0]);
            conn.Close();
            return soluong;
        }


        public bool truBanh(int id, int soluong)
        {
            conn.Open();
            string query = "update Banh set soLuong = @soLuong where maBanh = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue ("@id", id);
            cmd.Parameters.AddWithValue("@soLuong", soluong);
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            if (res>0)
            {
                return true;
            }
            return false;
        }
        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from Banh where tenBanh like '%' + @name + '%'";
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
