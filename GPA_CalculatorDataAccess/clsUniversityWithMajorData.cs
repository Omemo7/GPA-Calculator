using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsUniversityWithMajorData
    {
        //implement function to get all majors for univerity

        static public List<string>getUniversityMajorsByUniversityID(int id)
        {
            List<string> Majors = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getUniversityMajorsByUniversityID(@id) ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Majors.Add(reader[0].ToString());
                            
                        }
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
            return Majors;
        }

        static public List<string> getUniversityMajorsByUniversityName(string name)
        {
            List<string> Majors = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getUniversityMajorsByUniversityName(@name) ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Majors.Add(reader[0].ToString());

                        }
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
            return Majors;
        }

        static public DataTable getAllUniversitiesWithMajors()
        {
            DataTable table = new DataTable();
            
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from UniversitiesWithMajorsView";

                    SqlCommand cmd = new SqlCommand(query, conn);
                   

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                            table.Load(reader);
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
            return table;

        }

        static public bool getUniversityWithMajorByID(int id, ref int universityID, ref int majorID)
        {
            bool found = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from UniversitiesWithMajors where UniversityWithMajorID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            universityID = (int)reader["UniversityID"];
                            majorID = (int)reader["MajorID"];
                            found = true;
                        }
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
            return found;
        }
    }

        
    
}
