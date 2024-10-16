using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AsharabzyanovaAR.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool res=false;

            if (((x >= 1 && x <= 2) || (x <= -1 && x >= -2)) && (y >= 1 && y <= 2))
            {
                res = true;
            }
            else if (((x < 1 && x > -1) || (x > 2 || x < -2)) && (y< 1 || y > 2))
            {
                res = false;
            }
            return res;

            
        }
    }
}
