using Tyuiu.FabritsiusAO.Sprint2.Task4.V25.Lib;

namespace Tyuiu.FabritsiusAO.Sprint2.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}