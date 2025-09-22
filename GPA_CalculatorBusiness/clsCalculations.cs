using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public static class clsCalculations
    {
        public static double CalculateGPA(int prevHours, double prevGPA
            , List<(int Hours, double CurrentGradePoints,double PrevGradePoints)> CoursesResults)
        {
            double CurrentGPA;
            
            int HoursSum = prevHours;
            double ProductsSum = prevGPA * prevHours;

            foreach ((int Hours, double CurrentGradePoints,double PrevGradePoints) courseResult in CoursesResults)
            {
                if (courseResult.PrevGradePoints == -1)//course is not repeated
                {
                    ProductsSum += (courseResult.Hours * courseResult.CurrentGradePoints);
                    HoursSum += courseResult.Hours;
                }
                else
                {
                    if (courseResult.CurrentGradePoints >courseResult.PrevGradePoints ) 
                    {
                        ProductsSum -= (courseResult.Hours * courseResult.PrevGradePoints);
                        ProductsSum += (courseResult.Hours * courseResult.CurrentGradePoints);
                    }
                }
               
            }


            CurrentGPA = ProductsSum / HoursSum;
            return CurrentGPA;

        }
    }
}
