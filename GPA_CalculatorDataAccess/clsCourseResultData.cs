using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsCourseResultData
    {
        public static bool getCertifiedCourseResultByCourseIDForUser(int courseID, int userID
            ,ref int courseResultID ,ref string GradeSymbol ,ref int GPASaveID)

        {
            bool found=false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getCertifiedCoursesResultsTableForUser(@userID)
where CourseID=@courseID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    
                    cmd.Parameters.AddWithValue("@userID", userID);
                    
                    cmd.Parameters.AddWithValue("@courseID", courseID);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            courseResultID = (int)reader[0];
                            GradeSymbol = reader[3].ToString();
                            GPASaveID = (int)reader[4];


                            found = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return found;
        }
       
    }
}
