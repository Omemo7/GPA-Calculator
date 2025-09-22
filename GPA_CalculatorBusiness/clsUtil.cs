using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    static public class clsUtil
    {
        static string projectDirectory = Directory.GetCurrentDirectory();
        static public bool WriteLineToFile(string fileName,string lineToWrite)
        {
            bool wrote=false;
            try
            {
                string filePath= Path.Combine(projectDirectory, fileName);
                using (StreamWriter writer = new StreamWriter(filePath, true)) { 
                    writer.WriteLine(lineToWrite);
                }
                wrote = true;
            }
            catch (Exception)
            {
                MessageBox.Show("File writing problem");
            }
            return wrote;
        }
        static public List<string> ReadLinesFromFile(string fileName)
        {
            List<string> linesToRead=new List<string>();
            try
            {
                string filePath = Path.Combine(projectDirectory, fileName);
                if (!File.Exists(filePath))
                {
                    return null;
                }
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine())!=null)
                    {
                        linesToRead.Add(line);
                    }
                   
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("File reading problem");
            }
            return linesToRead;
        }
        static public bool DeleteFileIfExists(string fileName)
        {
            bool deleted=false;
            
            try
            {
                string filePath = Path.Combine(projectDirectory, fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    deleted = true;
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("deleting file failed");
            }
            return deleted;
        }


    }
}
