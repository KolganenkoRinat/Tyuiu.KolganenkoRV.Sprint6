using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KolganenkoRV.Sprint6.Task2.V5.Lib
{
    public class DataService : ISprint6Task2V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;
            double s;
            for (int x = startValue; x <= stopValue; x++)
            {
                s = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6;
                valueArray[count] = Math.Round(s, 2);
                count++;
            }
            return valueArray;
        }
    }
}
