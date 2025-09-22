using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsCourseGroup
    {
        

        public int GroupID {  get; set; }   
        public string Name  { get;set; }

        private clsCourseGroup(int groupID, string name)
        {
            GroupID = groupID;
            Name = name;
        }
        static public clsCourseGroup Find(int id)
        {
            string name = "";
            
            if (clsCourseGroupData.getCourseGroupByGroupID(id,ref name))
                return new clsCourseGroup(id,name);
            return null;

        }
    }
}
