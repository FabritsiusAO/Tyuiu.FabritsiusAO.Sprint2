using Tyuiu.FabritsiusAO.Sprint2.Task7.V2.Lib;

namespace Tyuiu.FabritsiusAO.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.2;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.IsTrue(res);
        }
    }
}