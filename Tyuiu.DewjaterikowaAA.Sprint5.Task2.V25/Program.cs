// See https://aka.ms/new-console-template for more information
using Tyuiu.DewjaterikowaAA.Sprint5.Task2.V25.Lib;

int[,] mtrx = new int[3, 3] { { 4, 8, 5 }, { 1, 4, 2 }, { 4, 9, 9 } };
int rows = mtrx.GetUpperBound(0) + 1;
int colums = mtrx.Length / rows;

DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнила: Девятерикова А.А. | ИИПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Девятерикова А. А. | ИИПб-25-1                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный массив 3 на элементов. Заменить нечётные элементы массива *");
Console.WriteLine("* на 0.                                                                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("Массив:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(mtrx);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();