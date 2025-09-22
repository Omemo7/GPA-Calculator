using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsGradeSymbol
    {
        public int ID { get; set; }
        public string GradeSymbolAsText { get; set; }

        public byte Rank {  get; set; }

        public clsGradeSymbol(int iD, string gradeSymbol, byte rank)
        {
            ID = iD;
            GradeSymbolAsText = gradeSymbol;
            Rank = rank;
        }
        public static int RankOfGradeSymbol(string gradeSymbol)
        {
            return clsGradeSymbolData.getRankOfGradeSymbol(gradeSymbol);
        }
        public static clsGradeSymbol Find(string gradeSymbol)
        {
            int id = -1;
            byte rank = 0;
            if (clsGradeSymbolData.getGradeSymbol(gradeSymbol, ref id, ref rank))
                return new clsGradeSymbol(id,gradeSymbol,rank);
            return null;
        }
    }
}
