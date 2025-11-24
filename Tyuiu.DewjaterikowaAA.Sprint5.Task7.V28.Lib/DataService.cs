using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DewjaterikowaAA.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V28.txt" });

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            bool previousWasSpace = false;
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (char ch in line)
                    {
                        if (ch == ' ')
                        {
                            if (!previousWasSpace)
                            {
                                strLine += ' ';
                            }
                            previousWasSpace = true;
                        }
                        else
                        {
                            strLine += ch;
                            previousWasSpace = false;
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);

                }
            }

            return pathSaveFile;
        }
    }
}
