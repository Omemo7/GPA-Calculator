using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsMajor
    {
        public int MajorID {  get; set; }
        public string Name { get; set;}

        public clsMajor() { }

        private clsMajor(int majorID,string name)
        {
            MajorID = majorID;
            Name = name;
        }

        //imp find
        static public clsMajor Find(int id)
        {
            string majorName=clsMajorData.getMajorNameByID(id);
            if (!string.IsNullOrEmpty(majorName))
                return new clsMajor(id, majorName);
            return null;

        }

    }
}
