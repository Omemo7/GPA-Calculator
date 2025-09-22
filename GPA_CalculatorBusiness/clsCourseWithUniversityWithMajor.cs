using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsCourseWithUniversityWithMajor
    {
        public int ID {  get; set; }
        public clsCourse Course { get; set; }
        public clsUniversityWithMajor UniversityWithMajor {  get; set; }
        public clsCourseGroup CourseGroup { get; set; }

        public clsCourseWithUniversityWithMajor()
        {

        }
        private clsCourseWithUniversityWithMajor(int iD, int courseID, int universityWithMajorID, int courseGroupID)
        {
            ID = iD;
            Course = clsCourse.Find(courseID);
            UniversityWithMajor = clsUniversityWithMajor.Find(universityWithMajorID);
            CourseGroup = clsCourseGroup.Find(courseGroupID);
        }

        public static clsCourseWithUniversityWithMajor Find(int CourseID,int UniversityWithMajorID)
        {
            int id=-1,courseGroupID=-1;
            if(clsCourseWithUniversityWithMajorData.
                getCourseWithUniversityWithMajor(CourseID, UniversityWithMajorID,ref id,ref courseGroupID)) 
                return new clsCourseWithUniversityWithMajor(id,CourseID,UniversityWithMajorID,courseGroupID);
            return null;

        }
    }
}
