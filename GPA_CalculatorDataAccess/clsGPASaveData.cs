using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsGPASaveData
    {
        static public bool GetLastGPASaveForUser(int userID, ref int GPASaveID, ref DateTime SavingDate
            , ref float GPA)
        {
            bool found = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select top 1 *from GPAsSaves where UserID=@userID order by SavingDate desc";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            GPASaveID = (int)reader[0];
                            SavingDate = (DateTime)reader[1];
                            GPA = float.Parse (reader[2].ToString());
                           
                            
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
        public static int AddNewGpaSaveWithItsCoursesResults(float gpa, 
            int userID,DataTable CoursesResults)
        {
            int gpaSaveID = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                   
                    using (SqlCommand cmd = new SqlCommand("spAddNewGPASaveWithItsCoursesResults", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        
                        cmd.Parameters.AddWithValue("@GPA", gpa);

                        cmd.Parameters.AddWithValue("@UserID", userID);


                        var tableParameter = cmd.Parameters.AddWithValue("@CoursesResultsToBeAdded", CoursesResults);
                        tableParameter.SqlDbType=SqlDbType.Structured;
                        tableParameter.TypeName = "CoursesResultsTableType";

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            gpaSaveID = id;
                        }
                    }
                       
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return gpaSaveID;
        }

        public static bool getGpaSaveByID(int gpaSaveID,ref DateTime savingDate,ref float gpa,
            ref int userID)
        {
            bool found = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from GPAsSaves where GPASaveID=@gpaSaveID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@gpaSaveID", gpaSaveID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                             
                            savingDate = (DateTime)reader[1];
                            gpa = float.Parse(reader[2].ToString());
                            
                            
                            userID = (int)reader[3];
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
