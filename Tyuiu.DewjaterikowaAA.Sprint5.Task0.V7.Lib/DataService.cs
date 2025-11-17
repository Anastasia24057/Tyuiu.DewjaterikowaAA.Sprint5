using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task0.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
        
            double f = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            f = Math.Round(f, 3);
            File.WriteAllText(path, Convert.ToString(f));
            return path;
        }
    }
}
