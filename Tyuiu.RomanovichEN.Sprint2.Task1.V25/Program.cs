using Tyuiu.RomanovichEN.Sprint2.Task1.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = " Спринт #2 | Выполнил: Романович Е. Н. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Романович Егор Николаевич | ПКТб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последо *");
        Console.WriteLine("* вательность можно чередовать, но использовать один раз в выражении) и   *");
        Console.WriteLine("* логических операций (|, &, ||, &&, !, ^, последовательность операций не *");
        Console.WriteLine("* должна нарушаться), а также арифметических выражений, которая вернет    *");
        Console.WriteLine("*лог.  последовательность(массив): (True, False, True, False, True, False)*");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("* a = 247,  b = 155, c = 325, d = 857                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool[] res = new bool[6];
        int a = 247;
        int b = 155;
        int c = 325;
        int d = 857;
        res = ds.GetLogicOperations(a, b, c, d);
        for (int i =0; i < 6; i++) { Console.WriteLine(res[i]); }
    }
}