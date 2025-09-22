using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GPACalculatorBusiness
{
    public class clsUser
    {
        enum enMode { Add,Update}
        enMode mode;
        private string _password;
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string Password { get { return _password; } 
            set { _password = clsPasswordHasher.HashPassword(value); 
            } }
        public string Name {  get; set; }
        
        public clsUniversityWithMajor UniversityWithMajor { get; set; }
        public clsUser()
        {
            UserID = -1;
            UserName ="";
            _password = "";
            Name = "";
            UniversityWithMajor = new clsUniversityWithMajor();
           mode = enMode.Add;
        }
        private clsUser(int userID, string userName, string password, string name,
            int universityWithMajorID)
        {
            UserID = userID;
            UserName = userName;
            _password = password;
            Name = name;
            UniversityWithMajor= clsUniversityWithMajor.Find(universityWithMajorID);
           mode = enMode.Update;
        }
        static public bool DoesUsernameExist(string username)
        {
            return clsUserData.DoesUsernameExist(username);
        }
        
        static public clsUser Find(int userID)
        {
            string username="", password="",name="";
            int universityWithMajorID = -1;
            if(clsUserData.getUserByUserID(userID,ref username,ref password,ref name,
                ref universityWithMajorID))
                return new clsUser(userID,username,password,name,universityWithMajorID);
            return null;
        }
        public bool VerifyPassword(string password)
        {
           return clsPasswordHasher.VerifyPassword(password,this._password);
        }
        static public clsUser Find(string username)
        {
            string password = "", name = "";
            int userID = -1;
            int universityWithMajorID = -1;
            if (clsUserData.getUserByUsername(username, ref userID, ref password, ref name,
                ref universityWithMajorID))
                return new clsUser(userID, username, password, name, universityWithMajorID);
            return null;
        }
        public DataTable AllCertifiedCoursesResultsForUser()
        {
       
            DataTable dt = clsUserData.getAllCertifiedCoursesResultsForUser(UserID);
            clsHandleBugs.FixDataTableReplacBackSlashNBySpaceInStringColumn(dt, "Name");
            return dt;
            //there seems to be an issue when converting from database table to datatable, \n instead of space is replaced so i handled it
        }

        public clsGPASave LastGPASaveForUser()
        {
            return clsGPASave.GetLastGPASaveForUser(UserID);
        }

        
        private bool Add()
        {
            this.UserID=clsUserData.AddUser(this.UserName, this.Password,this.UniversityWithMajor.UniversityWithMajorID
                ,this.Name);
            return UserID!=-1;
        }
        private bool Update()
        {
            return clsUserData.UpdateUser(UserID,UserName,Password,
                UniversityWithMajor.UniversityWithMajorID,this.Name);
        }
        public bool IsCourseTaken(int courseID)
        {
            return clsUserData.IsCourseTakenForUser(courseID, UserID);
        }
        public DataTable AllCourseAttempts(int courseID)
        {
            return clsUserData.getAllCourseAttemptsUser(courseID, this.UserID);
        }
        public int TotalCompletedHours()
        {
            return clsUserData.getTotalCompletedHoursForUser(UserID);
        }
        public int TotalCertifiedHours() { 
        return clsUserData.getTotalCertifiedHoursForUser(UserID);
        }
        public DataTable AllAllowedToTakeCoursesTableForThisUser()
        {
             DataTable dt= clsUserData.getAllAllowedToTakeCoursesTableForThisUser(this.UserID);
            clsHandleBugs.FixDataTableReplacBackSlashNBySpaceInStringColumn(dt, "Name");
            //handles \n existence
            return dt;
                
        }
        public Dictionary<int,string> AllAllowedToTakeCoursesIdsWithNames()
        {
            return AllAllowedToTakeCoursesTableForThisUser().AsEnumerable()
                .Select(row => new
                {
                    CourseID = row.Field<int>("CourseID"),
                    Name = row.Field<string>("Name"),
                }
                ).ToDictionary(item => item.CourseID, item => item.Name); 
        }
        public bool ResetUser()
        {
            return clsUserData.ResetUser(this.UserID);
        }
        public clsCourseGroup FindCourseGroupForCourseForThisUser(int courseID)
        {
            int courseGroupID= clsCourseWithUniversityWithMajor.
                Find(courseID, this.UniversityWithMajor.UniversityWithMajorID).CourseGroup.GroupID;
            return clsCourseGroup.Find(courseGroupID);


        }
        public bool IsUserAllowedToRetakeThisCourse(int courseID)
        {
            return clsUserData.IsUserAllowedToRetakeCourseByUserID(this.UserID, courseID);
        }
        public clsCourseResult CertifiedCourseResultByCourseIDForUser(int courseID)
        {
            return clsCourseResult.CertifiedCourseResultByCourseIDForUser(courseID, this.UserID);
        }


        public bool Save()
        {
            switch(mode)
            {
                case enMode.Add:
                    if (Add())
                    {
                        mode = enMode.Update;
                        return true;
                    }break;
                case enMode.Update:
                    if(Update())
                        return true;
                    break;
               
            }
           
            return false;
        }
    }
}
