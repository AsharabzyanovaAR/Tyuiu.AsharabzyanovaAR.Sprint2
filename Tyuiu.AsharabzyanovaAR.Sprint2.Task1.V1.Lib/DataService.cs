using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AsharabzyanovaAR.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d);
            res[1] = (a == b) & (c + 193 == d);
            res[2] = (a != b) || (c != d);
            res[3] = (a <= b) && (c <= d - 300);
            res[4] = !res[1];
            res[5] = (a + 200 >= b) ^ (c + 193 >= d);

            return res;
        }
    }
}
