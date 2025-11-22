using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path).Replace('.', ',');
            string[] strings = text.Split(' ');

            double minNumber = double.MaxValue;

            foreach (string str in strings)
            {
                if (double.TryParse(str.Trim(), out double number))
                {
                    if (number % 5 == 0)
                    {
                        minNumber = number;
                    }
                }
            }
            return minNumber;
        }
    }
}
