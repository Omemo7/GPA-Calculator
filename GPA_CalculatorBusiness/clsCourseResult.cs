using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsCourseResult
    {
        

        public int ID { get; set; }
        
        public clsGPASave GPASave {  get; set; }
        public clsCourse Course { get; set; }
        public clsGradeSymbol GradeSymbol { get; set; }

        public clsCourseResult(int iD, int gPASaveID,  int courseID, string gradeSymbol)
        {
            ID = iD;
            GPASave = clsGPASave.Find(gPASaveID);
            Course = clsCourse.Find(courseID);
            GradeSymbol = clsGradeSymbol.Find(gradeSymbol);
        }

        
        static public clsCourseResult CertifiedCourseResultByCourseIDForUser(int courseID,int userID)
        {

            int courseResultID = -1;
            int GpaSaveID = -1;
            string GradeSymbol = "";
            if (clsCourseResultData.getCertifiedCourseResultByCourseIDForUser(courseID,userID,
                ref courseResultID,ref GradeSymbol,ref GpaSaveID ))
                return new clsCourseResult(courseResultID, GpaSaveID, courseID, GradeSymbol);
            return null;
        }
       
            

    }
}
