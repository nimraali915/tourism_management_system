using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConn
    {
        private readonly string ConnectionString;
        public DBConn()
        {

            ConnectionString = "Data Source=DESKTOP-K1ODDQM\\SQLEXPRESS;;Database=TMS;Integrated Security=True;";
        }
        public bool ExecuteCommand(string query)
        {
            bool check;

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    check = cmd.ExecuteNonQuery() > 0;
                }
            }
            return check;
        }
        public DataTable FetchData(string query)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString)) 
            { using (SqlCommand cmd = new SqlCommand(query, con))
             { 
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet(); 
                    sda.Fill(dt);
                    return dt.Tables[0]; 
                } 
            }
        }


    }
}
