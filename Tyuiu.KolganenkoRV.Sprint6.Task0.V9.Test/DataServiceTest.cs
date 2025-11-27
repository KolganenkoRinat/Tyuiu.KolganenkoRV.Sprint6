using Tyuiu.KolganenkoRV.Sprint6.Task0.V9.Lib;

namespace Tyuiu.KolganenkoRV.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = -2.556;
            Assert.AreEqual(res, wait);
        }
    }
}
