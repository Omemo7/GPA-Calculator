using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsUniversityData
    {

        public static Dictionary<int,string> getUniversitiesNamesWithIDs()
        {
            var NamesWithIDs= new Dictionary<int,string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select UniversityID,Name from Universities";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            NamesWithIDs[(int)reader[0]]=reader[1].ToString();
                            
                    }
                }
            }
            catch (Exception) { throw; }
            return NamesWithIDs;
        }
        public static DataTable getAllUniversities()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select *from Universities";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        if (reader.HasRows) 
                            dt.Load(reader);
                    }
                }
            }
            catch (Exception) { throw; }

        return dt;
        }
        public static string getUniversityNameByID(int id)
        {
            string UniversityName = "";
            
            

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select Name from Universities where UniversityID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        UniversityName = result.ToString();
                    }
                }
                  
            }
            catch (Exception ex)
            {
                throw;
            }
           
            return UniversityName;
        }
    }
}
