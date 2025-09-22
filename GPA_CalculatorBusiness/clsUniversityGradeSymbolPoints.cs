using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsUniversityGradeSymbolPoints
    {
        public int UniversityGradeSymbolPointsID {  get; set; }

        public float Points {  get; set; }
        public clsGradeSymbol GradeSymbol { get; set; }
        public clsUniversity University { get; set; }


        

        public static DataTable GradeSymbolPointsTableForThisUniversity(int uniID)
        {
            return clsUniversityGradeSymbolPointsData.getGradeSymbolPointsTableForThisUniversity(uniID);
        }
        static public double SymbolPointsForThisSymbolAndThisUniversity(string Symbol, int uniID)
        {


            return clsUniversityGradeSymbolPointsData.
                getGradeSymbolPointsForThisSymbolAndThisUniversity(Symbol, uniID);


        }
    }

   
}
