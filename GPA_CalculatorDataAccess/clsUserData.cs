using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GPACalculatorDataAccess
{
    public class clsUserData
    {

        public static bool ResetUser(int UserID)
        {
            bool reseted=false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spResetUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);


                        object result = cmd.ExecuteScalar();
                        if (result != null && bool.TryParse(result.ToString(), out bool r))
                        {
                            reseted= r;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return reseted;
        }

        public static int AddUser(string username, string password,int uniWithMajorID,string name)
        {
            int userID = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO [dbo].[Users]
           ([Username]
           ,[Password]
           ,[UniversityWithMajorID]
           ,[Name])
     VALUES
           (@Username,@Password,@UniversityWithMajorID,@Name)
select SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@UniversityWithMajorID", uniWithMajorID);
                    cmd.Parameters.AddWithValue("@Name", name);

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(),out int id))
                    {
                        userID = id;
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return userID;
        }
        public static string getHashedPasswordByUserID(int userID)
        {
            string Password = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select password from Users where UserID=@userID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        Password=result.ToString();
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return Password;
        }
        public static bool getUserByUserID(int userID,ref string username,ref string password,
            ref string name,ref int universityWithMajorID)
        {
            bool Found = false;
            
            
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from users where userid=@userID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            username = (string)reader["username"];
                            password = (string)reader["password"];
                            name = (string)reader["name"];
                            universityWithMajorID = (int)reader["UniversityWithMajorID"];
                            Found = true;
                        }
                    }

                }
                
                
            }
            catch(Exception ex)
            { 
                throw; 
            }
            
            return Found;
        }
        public static bool UpdateUser(int userID,string username,string password,int universityWithMajorID,
            string name)
        {
            bool updated = false;
            try
            {
                
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"UPDATE [dbo].[Users]
   SET [Username] = @username
      ,[Password] = @password
      ,[UniversityWithMajorID] = @universityWithMajorID
      ,[Name] =@name
 WHERE UserID=@userID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                   
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@universityWithMajorID", universityWithMajorID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    int affectedRows=cmd.ExecuteNonQuery();

                    if (affectedRows > 0) { updated = true; }

                }


            }
            catch (Exception ex)
            {
                throw;
            }
            return updated;
        }

        public static bool IsUserAllowedToRetakeCourseByUserID(int userID, int courseID)
        {
            bool allowed = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select courseID from getAllowedToRetakeCoursesTableForUser(@UserID) where CourseID = @CourseID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@CourseID", courseID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    { allowed = true; }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return allowed;
        }
        public static int getTotalCompletedHoursForUser(int userID)//counts hours for passed courses(completed)
        {
            int CHours = 0;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select dbo.getTotalCompletedHoursForUser(@UserID) as TotalCompletedHours";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    

                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(),out int h))
                    { CHours = h; }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return CHours;
        }

        public static int getTotalCertifiedHoursForUser(int userID)//counts hours for certified courses even failed ones 
        {
            int CHours = 0;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select dbo.getTotalCertifiedHoursForUser(@UserID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);


                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int h))
                    { CHours = h; }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return CHours;
        }

        public static bool IsCourseTakenForUser(int courseID,int userID)
        {
            bool isTaken = false;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT [dbo].[IsCourseTakenForUser] (
   @courseID,@userID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@courseID", courseID);
                    cmd.Parameters.AddWithValue("@userID", userID);


                    object result = cmd.ExecuteScalar();

                    if (result != null && bool.TryParse(result.ToString(), out bool taken))
                    { isTaken=taken; }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return isTaken;
        }
        public static DataTable getAllAllowedToTakeCoursesTableForThisUser(int userID)
        {
            DataTable dt=new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getAllAllowedToTakeCoursesTableForThisUser(@userID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userID", userID);

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

        
        public static DataTable getAllCourseAttemptsUser(int courseID,int userID)
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getAllCourseAttemptsForUser(@CourseID ,@UserID )";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@CourseID",courseID);

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
        public static DataTable getAllCertifiedCoursesResultsForUser(int userID)
        {
            DataTable dt = new DataTable();


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getCertifiedCoursesResultsTableForUser(@UserID)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    

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
        public static bool DoesUsernameExist(string username)
        {
            bool exists = false;
            try
            {
                
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select username from Users where Username=@username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);


                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        exists = true;
                    }

                }


            }
            catch (Exception ex)
            {
                throw;
            }
            return exists;
        }
       

        public static bool getUserByUsername(string username,ref int userID, ref string password,
            ref string name, ref int universityWithMajorID)
        {
            bool Found = false;
            
            
            try
            {
                using(SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from users where Username=@username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       
                        if (reader.Read())
                        {

                            userID = (int)reader["userID"];
                            password = (string)reader["password"];
                            name = (string)reader["name"];
                            universityWithMajorID = (int)reader["UniversityWithMajorID"];
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
