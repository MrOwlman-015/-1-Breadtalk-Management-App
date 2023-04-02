using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public bool themChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
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


        public bool suaChiTietHoaDon(DTO.DTO_ChiTietHoaDon cthd)
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


        public bool xoaChiTietHoaDon(string cthd_id)
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
