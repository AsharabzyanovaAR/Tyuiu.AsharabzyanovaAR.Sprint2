using Tyuiu.AsharabzyanovaAR.Sprint2.Task1.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 119;
        int b = 196;
        int c = 134;
        int d = 327;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = ("Спринт #2 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=          *");
        Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
        Console.WriteLine("* в выражении) и логических операций (|,&,||,&&,!,^,последовательность    *");
        Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,которая*");
        Console.WriteLine("* вернет логическую последовательность(массив):(True, False, True, False, *");
        Console.WriteLine("* True, False), при a = 119, b = 196, c = 134, d = 327                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("a=" + a);
        Console.WriteLine("b=" + b);
        Console.WriteLine("c=" + c);
        Console.WriteLine("d=" + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}