using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace GPACalculatorDataAccess
{
    public class clsUniversityGradeSymbolPointsData
    {
        static public DataTable getGradeSymbolPointsTableForThisUniversity(int universityID)
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select*from getGradesSymbolsPointsTableForThisUniversity(@uniID) order by Rank";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@uniID",universityID);
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
        public static double getGradeSymbolPointsForThisSymbolAndThisUniversity(string symbol, int uniID)
        {
            double symbolPoints = -1;
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    conn.Open();
                    string query = @"select points from getGradesSymbolsPointsTableForThisUniversity(@uniID)
                    where GradeSymbol=@symbol";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@uniID", uniID);
                    cmd.Parameters.AddWithValue("@symbol", symbol);
                    
                    object result= cmd.ExecuteScalar();
                    if(result != null && double.TryParse(result.ToString(),out double points))
                    {
                        symbolPoints = points;
                    }

                }
            }
            catch (Exception)
            {
                throw;
            }
            return symbolPoints;

        }

        
        
    }
}
