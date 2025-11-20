using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            //string tempPath = Path.GetTempPath();
            //string path = Path.Combine(tempPath, "OutPutFileTask1.txt");

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
                if (2 * x - 1 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3, 2);
                }
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
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
