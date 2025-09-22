using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsUniversityWithMajor
    {
        public int UniversityWithMajorID {  get; set; }
        public clsUniversity University { get; set; }
        public clsMajor Major { get; set; }

        public clsUniversityWithMajor()
        {

        }
        private clsUniversityWithMajor(int universityWithMajorID, int universityID, int majorID)
        {
            UniversityWithMajorID = universityWithMajorID;
            University = clsUniversity.Find(universityID);
            Major = clsMajor.Find(majorID);
        }

        static public clsUniversityWithMajor Find(int universityWithMajorID)
        {
            int universityID = -1;
            int majorID = -1;

            if(clsUniversityWithMajorData.getUniversityWithMajorByID(universityWithMajorID,ref universityID,ref majorID))
                return new clsUniversityWithMajor(universityWithMajorID,universityID,majorID);
            return null;
        }

        static public List<string>  UniversityMajorsNamesList(int UniID)
        {
            return clsUniversityWithMajorData.getUniversityMajorsByUniversityID(UniID);
        }

        static public List<string> UniversityMajorsNamesList(string uniName)
        {
            return clsUniversityWithMajorData.getUniversityMajorsByUniversityName(uniName);
        }
        static public DataTable AllUniversitiesWithMajorsDataTable()
        {
            return clsUniversityWithMajorData.getAllUniversitiesWithMajors();
        }
    }
}
