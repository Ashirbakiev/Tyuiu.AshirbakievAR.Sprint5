using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AshirbakievAR.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            string srtX = File.ReadAllText(path);

            double res = (Math.Pow(Convert.ToDouble(srtX), 4) + Math.Cos(Convert.ToDouble(srtX))) * Math.Sin(Convert.ToDouble(srtX));

            return Math.Round(res, 3);
        }
    }
}
