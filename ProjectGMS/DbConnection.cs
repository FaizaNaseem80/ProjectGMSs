using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGMS
{
    class DbConnection
    {

       string connectionstring = "Data Source=DESKTOP-VKORAQ4\\MSSQLSERVERR;Initial Catalog=FMS;Integrated Security=True";
        public DataTable procedureExecuteQuery(string query, bool flag, string EmpEmail, string EmpPassword, string EmpType)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", EmpEmail);
            cmd.Parameters.AddWithValue("@Password", EmpPassword);
            cmd.Parameters.AddWithValue("@Type", EmpType);


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable ExecuteQuery(string query, bool flag)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            if (flag)
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return null;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

        }

      
    }
}
