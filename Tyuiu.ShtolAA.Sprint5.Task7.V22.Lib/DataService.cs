using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtolAA.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V22.txt";

            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileex = fileInfo.Exists;
            if (fileex)
            {
                File.Delete(pathSave);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string forbid = "!.,:;?-";
                string str = reader.ReadLine();
                string res = "";

                StringBuilder res1str = new StringBuilder(str);
                for (int i = 0; i < res1str.Length; i++)
                {
                    for (int j = 0; j < forbid.Length; j++)
                    {
                        if (res1str[i] == forbid[j])
                        {
                            res1str[i] = '#';
                        }
                    }
                }
                for (int i = 0; i < res1str.Length; i++)
                {
                    res += res1str[i];
                }
                File.AppendAllText(pathSave, res + Environment.NewLine);
                res = "";
            }
            return (pathSave);
        }
    }
}
