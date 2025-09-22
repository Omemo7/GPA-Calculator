using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public class clsUniversity
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public clsUniversity() { }
        private clsUniversity(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
        //imp find
        static public clsUniversity Find(int id)
        {
            string UniversityName = clsUniversityData.getUniversityNameByID(id);
            if (!string.IsNullOrEmpty(UniversityName))
                return new clsUniversity(id, UniversityName);
            return null;

        }

        static public DataTable AllUniversitiesDataTable()
        {
            return clsUniversityData.getAllUniversities();
        }
        static public Dictionary<int,string> AllUniversitiesNamesWithIDs()
        {
           
            return clsUniversityData.getUniversitiesNamesWithIDs();
            
        }
    }
}
