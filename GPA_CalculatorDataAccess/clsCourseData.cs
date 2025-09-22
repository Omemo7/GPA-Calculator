using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsCourseData
    {
        public static bool getCourseByCourseID(int CourseID, ref string Name, ref int Hours)
            
        {
            bool Found = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from Courses where CourseID=@CourseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            Name = reader["Name"].ToString();
                            Hours = (int)reader["Hours"];
                            
                           

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

        public static DataTable getPrerequisitsForCourse(int courseID)
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select PrerequisiteID,PrerequisiteName from CoursesWithPrerequisitesView
where CourseID=@courseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@courseID", courseID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        dt.Load(reader);
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return dt;
        }


        public static DataTable getCoursesThatThisCourseIsPrerequisiteFor(int courseID)
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select CourseID,Name from CoursesWithPrerequisitesView
where PrerequisiteID=@courseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@courseID", courseID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        dt.Load(reader);
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return dt;
        }

    }
}
