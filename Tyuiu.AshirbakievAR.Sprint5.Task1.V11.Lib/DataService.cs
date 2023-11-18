using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.AshirbakievAR.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Sin(x)-2*x)/(3*x-1)+ Math.Sin(x) - 3 * x + 2;
                strY = Convert.ToString(y);
                if (x != stopValue && (3 * x - 1) != 0)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else if (x != stopValue && (3 * x - 1) == 0)
                {
                    y = 0;
                    strY = Convert.ToString(y);
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
