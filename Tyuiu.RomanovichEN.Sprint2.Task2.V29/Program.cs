using Tyuiu.RomanovichEN.Sprint2.Task2.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = " Спринт #2 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Романович Егор Николаевич | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и*");
        Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int x, y;
        Console.WriteLine("Введите X:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        Console.ReadKey();
    }
}