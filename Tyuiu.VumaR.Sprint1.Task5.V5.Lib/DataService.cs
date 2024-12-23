
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.VumaR.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double fractionalPart = Math.Abs(x) - Math.Truncate(Math.Abs(x));

            
            if (fractionalPart == 0)
            {
                return 0;
            }

            
            fractionalPart *= 10;

            
            return (int)Math.Truncate(fractionalPart);
        }
    }
}
