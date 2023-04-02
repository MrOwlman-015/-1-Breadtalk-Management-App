using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CongThucBanh : DBConnection
    {
        public DataTable getCongThucBanh()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CongThucBanh", conn);
            DataTable dtCongThucBanh = new DataTable();
            da.Fill(dtCongThucBanh);
            return dtCongThucBanh;
        }


        public bool themCongThucBanh(DTO.DTO_CongThucBanh ctbh)
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


        public bool suaCongThucBanh(DTO.DTO_CongThucBanh ctbh)
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


        public bool xoaCongThucBanh(string ctbh_id)
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
