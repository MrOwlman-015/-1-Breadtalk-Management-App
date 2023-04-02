using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NguyenLieu : DBConnection
    {
        public DataTable getNguyenLieu()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NguyenLieu", conn);
            DataTable dtNguyenLieu = new DataTable();
            da.Fill(dtNguyenLieu);
            return dtNguyenLieu;
        }


        public bool themNguyenLieu(DTO.DTO_NguyenLieu nl)
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


        public bool suaNguyenLieu(DTO.DTO_NguyenLieu nl)
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


        public bool xoaNguyenLieu(string nl_id)
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
