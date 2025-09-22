using GPACalculatorDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
   

    public class clsGPASave
    {
        public int ID { get; set; }
        public DateTime SavingDate {  get; set; }
        public float GPA { get; set; }
        
        
        public clsUser User { get; set; }
        public DataTable dtCoursesResults {  get; set; }

        
        
        public clsGPASave()
        {
            dtCoursesResults = new DataTable();
            dtCoursesResults.Columns.Add("CourseID", typeof(int));
            dtCoursesResults.Columns.Add("GradeSymbolID",typeof(int));
        }
        private clsGPASave(int iD, DateTime savingDate, float gPA,int userID)
        {
            ID = iD;
            SavingDate = savingDate;
            GPA = gPA;
            
            User = clsUser.Find(userID);
        }
        
            public static clsGPASave GetLastGPASaveForUser(int userID)
        {
            int ID = -1;
            DateTime SavingDate=DateTime.Now;
            float GPA=-1;
            
            

            if(clsGPASaveData.GetLastGPASaveForUser(userID,ref ID,ref SavingDate
                ,ref GPA))
                return new clsGPASave(ID,SavingDate,GPA,userID);
            return null;
        }

        public static clsGPASave Find(int GPASaveID)
        {
            DateTime SavingDate = DateTime.Now;
            float GPA = -1;
            
            
            int UserID = -1;

            if (clsGPASaveData.getGpaSaveByID(GPASaveID, ref SavingDate, ref GPA,
                  ref UserID)) 
                return new clsGPASave(GPASaveID,SavingDate,GPA,UserID);
            return null;

        }

        public bool Save()
        {

           

            this.ID= clsGPASaveData.AddNewGpaSaveWithItsCoursesResults(this.GPA,
                this.User.UserID,this.dtCoursesResults);

            return this.ID != -1;
        }

    }
}
