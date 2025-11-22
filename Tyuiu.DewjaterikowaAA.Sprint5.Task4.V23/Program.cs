// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint5.Task4.V23.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила: Девятерикова А.А. | ИИПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема:  Потоковый метод записи данных в бинарный файл                    *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Девятерикова А. А. | ИИПб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле.            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask4V23.txt";


Console.WriteLine("Данные находятся в файле: " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();