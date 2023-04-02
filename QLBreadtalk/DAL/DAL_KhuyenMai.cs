using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                conn.Open();

                string SQL = string.Format("");

                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return false;
        }


        public bool suaKhuyenMai(DTO.DTO_KhuyenMai km)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("");

                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return false;
        }


        public bool xoaKhuyenMai(string km_id)
        {
            try
            {
                conn.Open();

                string SQL = string.Format("");

                SqlCommand cmd = new SqlCommand(SQL, conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return false;
        }
    }
}
