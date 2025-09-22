using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{ 
    public class clsCourse
    {
        public int CourseID {  get; set; }
        public string Name { get; set; }
        public int Hours {  get; set; } 
        

        

        public clsCourse()
        {

        }

        private clsCourse(int courseID, string name, int hours)
        {
            CourseID = courseID;
            Name = name;
            Hours = hours;
            
            
        }
        public DataTable PrerequisitsForCourse()
        {
            DataTable dt = clsCourseData.getPrerequisitsForCourse(this.CourseID);
            clsHandleBugs.FixDataTableReplacBackSlashNBySpaceInStringColumn(dt, "PrerequisiteName");
            return dt;
        }
        public DataTable CoursesThatThisCourseIsPrerequisiteFor()
        {
            DataTable dt= clsCourseData.getCoursesThatThisCourseIsPrerequisiteFor(this.CourseID);
            clsHandleBugs.FixDataTableReplacBackSlashNBySpaceInStringColumn(dt, "Name");
            return dt;
        }
        static public clsCourse Find(int id)
        {
            string name = "";
            int hours = -1;
            
            

            if (clsCourseData.getCourseByCourseID(id, ref name, ref hours
                ))
                return new clsCourse(id,name,hours);
            return null;

        }

    }
}
