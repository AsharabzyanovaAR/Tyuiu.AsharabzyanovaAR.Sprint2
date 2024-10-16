using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AsharabzyanovaAR.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (n, m)
            {
                case (1, 3):return $"30.02.{g}";
                case (1, 1): return $"31.12.{g-1}";
                case (1, 2):return $"31.01.{g}";
                case (1, 4):return $"31.03.{g}";
                case (1, 5): return $"30.04.{g}";
                case (1, 6):return $"31.05.{g}";
                case (1, 7):return $"30.06.{g}";
                case (1, 8):return $"31.07.{g}";
                case (1, 9):return $"31.08.{g}";
                case (1, 10):return $"30.09.{g}";
                case (1, 11): return $"31.10.{g}";
                case (1, 12):return $"30.11.{g}";

                

                default: return ($"0{n-1}.0{m}.{g}"); 
            }

            
        }
    }
}
