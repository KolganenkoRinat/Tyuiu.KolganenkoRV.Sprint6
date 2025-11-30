using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KolganenkoRV.Sprint6.Task1.V13.Lib
{
    public class DataService : ISprint6Task1V13
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
                s = ((3 * Math.Cos(x)) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2; 
                valueArray[count] = Math.Round(s, 2);
                count++;
            }
            return valueArray;
        }
    }
}
