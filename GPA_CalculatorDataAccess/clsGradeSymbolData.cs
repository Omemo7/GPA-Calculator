using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorDataAccess
{
    public class clsGradeSymbolData
    {
        
            public static int getRankOfGradeSymbol(string GradeSymbol)//counts hours for certified courses even failed ones 
        {
            int Rank = -1;


            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select Rank from GradesSymbols where GradeSymbol = @GradeSymbol";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@GradeSymbol", GradeSymbol.Trim());


                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int r))
                    { Rank = r; }

                }


            }
            catch (Exception ex)
            {
                throw;
            }

            return Rank;
        }
        public static bool getGradeSymbol(string gradeSymbol,ref int id,ref byte rank)
        {
            bool found = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from GradesSymbols where GradeSymbol=@gradeSymbol";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@gradeSymbol", gradeSymbol);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = (int)reader[0];
                            rank = byte.Parse(reader[2].ToString());
                            found = true;
                        }
                        
                    }
                }
            }
            catch (Exception ex) { throw; }
            return found;
        }
    }
}
