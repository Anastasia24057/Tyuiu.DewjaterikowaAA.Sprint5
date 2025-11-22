using Tyuiu.DewjaterikowaAA.Sprint5.Task6.V28.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task6.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V28.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

    }
}
