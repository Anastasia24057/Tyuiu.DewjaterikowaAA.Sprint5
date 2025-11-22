using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task3.V13.Lib
{
    public class DataService : ISprint5Task3V13
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });

            double y = Math.Round(((x) / (Math.Pow(x, 3) + 2)), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
