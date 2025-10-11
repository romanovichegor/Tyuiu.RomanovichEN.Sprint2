using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RomanovichEN.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x >= -1 && x <= 0) && (y >= -1 && y <= 1)) { res = true; }
            else if ((x >= 0 && x <= 0.5) && (y >= x && y <= 1)) { res = true; }
            else { res = false; }
            return res;

        }
    }
}
