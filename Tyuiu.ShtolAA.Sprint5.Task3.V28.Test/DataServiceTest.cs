using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

namespace Tyuiu.ShtolAA.Sprint5.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\aleks\source\repos\Tyuiu.ShtolAA.Sprint5\Tyuiu.ShtolAA.Sprint5.Task3.V28\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
