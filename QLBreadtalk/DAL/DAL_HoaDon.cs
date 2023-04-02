using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool themHoaDon(DTO.DTO_HoaDon hd)
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


        public bool suaHoaDon(DTO.DTO_HoaDon hd)
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


        public bool xoaHoaDon(string hd_id)
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
