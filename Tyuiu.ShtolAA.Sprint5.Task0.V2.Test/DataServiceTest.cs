using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ShtolAA.Sprint5.Task0.V2.Lib;

namespace Tyuiu.ShtolAA.Sprint5.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint5\Tyuiu.ShtolAA.Sprint5.Task0.V2\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
