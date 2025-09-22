using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsCourseGroupData
    {
        public static bool getCourseGroupByGroupID(int GroupID,ref string name)
        {
            bool Found = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from CoursesGroups where GroupID=@GroupID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@GroupID", GroupID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            name = reader["GroupName"].ToString();
                            

                            Found = true;
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return Found;
        }
    }
}
