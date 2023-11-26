using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtolAA.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double min = 10000000;
            double n;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    n = Convert.ToDouble(line);
                    if ((n>=10) && (n<100) && (n % 1 == 0) && (n<min))
                    {
                        min = Convert.ToDouble(line);
                    }
                }
            }
            return min;
        }
    }
}
 