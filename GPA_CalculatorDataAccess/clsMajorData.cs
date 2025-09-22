using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsMajorData
    {
        public static string getMajorNameByID(int id)
        {
            string MajorName = "";
           
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select Name from Majors where MajorID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MajorName = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
           
            return MajorName;
        }
    }
}
