using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public class Database
    {
        private string connectionString = @"Data Source=DESKTOP-IPDB6V8\HOANGLE;Initial Catalog=QLSV;Persist Security Info=True;User ID=sa;Password=den123456;TrustServerCertificate=True";
        private SqlConnection con;
        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Connected failed: "+ ex.Message);
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            } // Kết nối được tự động đóng ở đây
        }

        public DataRow Select(string sql) 
        {
            try
            {
                cmd = new SqlCommand(sql, con);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant show data" + ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cant run linq" + ex.Message);
                return -100;
            }
            finally 
            { 
                con.Close(); 
            }
        }
    }
}
