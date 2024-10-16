using Tyuiu.AsharabzyanovaAR.Sprint2.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = ("Спринт #2 | Выполнила: Ашарабзянова А.Р. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Ашарабзянова Алина Рустамовна | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая которая использует оператор switch вычисляет*");
        Console.WriteLine("* требуемое значение и возвращает результат.                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        
        int g = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        string res = ds.FindDateOfPreviousDay(g,m,n);
      
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);



        Console.ReadKey();
    }
}