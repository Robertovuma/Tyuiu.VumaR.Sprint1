
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.VumaR.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
           double n = (x - 1) % 7 + 1;
            return (int)n;
        }
    }
}
