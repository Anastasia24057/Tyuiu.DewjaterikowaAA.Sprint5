// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint5.Task3.V13.Lib;

int x = 3;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила: Девятерикова А.А. | ИИПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема:  Потоковый метод записи данных в бинарный файл                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Девятерикова А. А. | ИИПб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Вычислить значение выражения при х=3.                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("x = " + x);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();