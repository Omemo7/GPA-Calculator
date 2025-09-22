using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsCourseWithUniversityWithMajorData
    {
        public static bool getCourseWithUniversityWithMajor(int courseID, int universityWithMajorID,
            ref int ID, ref int courseGroupID)
        {
            bool found = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from CoursesWithUniversitiesWithMajors
where CourseID=@courseID and UniversityWithMajorID=@universityWithMajorID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseID", courseID);
                        cmd.Parameters.AddWithValue("@universityWithMajorID", universityWithMajorID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ID = (int)reader["CourseWithUniversityWithMajorID"];
                                courseGroupID = (int)reader["CourseGroupID"];
                                found = true;
                            }
                        }
                    }
                }

            }
            catch (Exception ex) { throw; }
            return found;
        }
    }
}
