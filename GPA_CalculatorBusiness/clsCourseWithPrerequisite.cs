using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsCourseWithPrerequisite
    {
        public int CourseWithPrerequisiteID {  get; set; }  
        public clsCourse Course { get; set; }
        public clsCourse Prerequisite { get; set; }
    }
}
