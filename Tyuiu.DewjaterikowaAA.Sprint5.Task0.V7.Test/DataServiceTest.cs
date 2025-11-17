using Tyuiu.DewjaterikowaAA.Sprint5.Task0.V7.Lib;
using System.IO;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            //string path = @"C:\Пользователи\user\source\repos\Tyuiu.DewjaterikowaAA.Sprint5\Tyuiu.DewjaterikowaAA.Sprint5.Task0.V7\bin\Debug\OutPutFileTask0.txt";


            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
