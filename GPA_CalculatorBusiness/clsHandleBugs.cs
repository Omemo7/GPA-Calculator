using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculatorBusiness
{
    public static class clsHandleBugs
    {
        public static void FixDataTableReplacBackSlashNBySpaceInStringColumn(DataTable dt,string columnName)
        {
            foreach (DataRow row in dt.Rows)
            {
                row[columnName] = row[columnName].ToString().Replace("\n", " ");
            }
           
        }
    }
}
