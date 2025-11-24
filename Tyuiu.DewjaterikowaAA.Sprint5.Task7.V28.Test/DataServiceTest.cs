using Tyuiu.DewjaterikowaAA.Sprint5.Task7.V28.Lib;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSave()
        {
            string path = @"C:\temp\OutPutDataFileTask7V28.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
