using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool themKhoBanh(DTO.DTO_KhoBanh kb)
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


        public bool suaKhoBanh(DTO.DTO_KhoBanh kb)
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


        public bool xoaKhoBanh(string kb_id)
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
